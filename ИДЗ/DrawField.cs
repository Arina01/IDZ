using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Class_Diagram_1
{
    public partial class DrawField : Form
    {
        List<PictureBox> listClass;
        List<PictureBox> listSvz;
        private object currObject = null;
        Point A, B;
        bool isDrawPoint = false;
        public DrawField()
        {
            InitializeComponent();
            listClass = new List<PictureBox>();
            listSvz = new List<PictureBox>();
            MouseMove += new MouseEventHandler(mouseEvent);
            //MouseClick += new MouseEventHandler(mouseClickRun);
            MouseClick += new MouseEventHandler(mouseClickStop);
            MouseClick += new MouseEventHandler(mouseClickDelete);
            MouseClick += new MouseEventHandler(mousePointA);
            MouseClick += new MouseEventHandler(mousePointB);
        }
        private void drawSvz(int index)
        {
            int width = Math.Abs(A.X - B.X) - 1;
            int height = Math.Abs(A.Y - B.Y) - 1;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(width / 2, height / 2);
            pictureBox.Height = height;
            pictureBox.Width = width;
            Bitmap bitmap;
            bitmap = new Bitmap(pictureBox.Image);
            pictureBox.Image = bitmap;
            pictureBox.MouseClick += mouseClickStop;
            pictureBox.MouseClick += mouseClickRun;
            pictureBox.MouseClick += mouseClickDelete;
            Controls.Add(pictureBox);
            listSvz.Add(pictureBox);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.Clear(SystemColors.Window);
            Pen pen = new Pen(Color.Black, 3);
            int mySize = 40;
            switch (index)
            {
                case 0:
                    {
                        graph.DrawLine(pen, 0, 0, width - mySize, height - mySize);
                        graph.DrawLine(pen, width - mySize, height - mySize, width - mySize, height);
                        graph.DrawLine(pen, width - mySize, height - mySize, width, height - mySize);
                        graph.DrawLine(pen, width, height, width - mySize, height);
                        graph.DrawLine(pen, width, height, width, height - mySize);
                        break;
                    }
                case 1:
                    {
                        graph.DrawLine(pen, 0, 0, width - mySize, height - mySize);
                        for (int i = 0; i < mySize; i += 2)
                        {
                            graph.DrawLine(pen, width - mySize, height - mySize, width - mySize + i, height - i);
                            graph.DrawLine(pen, width - mySize, height - mySize, width - i, height - mySize + i);
                            graph.DrawLine(pen, width, height, width - mySize + i, height - i);
                            graph.DrawLine(pen, width, height, width - i, height - mySize + i);
                        }
                        break;
                    }
                case 2:
                    {
                        graph.DrawLine(pen, 0, 0, width - mySize / 2, height - mySize / 2);
                        graph.DrawLine(pen, width, height, width - mySize, height);
                        graph.DrawLine(pen, width, height, width, height - mySize);
                        graph.DrawLine(pen, width - mySize, height, width, height - mySize);
                        break;
                    }
                case 3:
                    {
                        graph.DrawLine(pen, 0, 0, width, height);
                        graph.DrawLine(pen, width, height, width - mySize, height);
                        graph.DrawLine(pen, width, height, width, height - mySize);
                        Pen pen1 = new Pen(Color.White, 10);
                        for (int i = 0; i < width - 50; i += 20)
                        {
                            graph.DrawLine(pen1, i, 0, i, height);
                        }
                        break;
                    }

            }
        }
        private void mousePointB(object sender, MouseEventArgs e)
        {
            if (isDrawPoint == true && e.Button.ToString() == "Left")
            {
                B.X = e.X;
                B.Y = e.Y;
                isDrawPoint = false;
            }

        }

        private void mousePointA(object sender, MouseEventArgs e)
        {
            if (isDrawPoint == false && e.Button.ToString() == "Middle")
            {
                A.X = e.X;
                A.Y = e.Y;
                isDrawPoint = true;
            }
        }

        private void mouseClickDelete(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right" && currObject == null)
            {
                sender.GetType().GetProperty("Visible").SetValue(sender, false);
            }
        }
        private void mouseClickRun(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                currObject = sender;
            }
        }
        private void mouseClickStop(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Left")
            {
                currObject = null;
            }
        }
        private void mouseEvent(object sender, MouseEventArgs e)
        {
            if (currObject != null)
            {
                currObject.GetType().GetProperty("Location").SetValue(currObject, new Point(Cursor.Position.X - 220, Cursor.Position.Y - 220));
            }
        }

        private void добавитьКлассToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(300, 150);
                pictureBox.Size = bitmap.Size;
                pictureBox.Image = bitmap;
                pictureBox.MouseDown += mouseEvent;
                pictureBox.MouseClick += mouseClickStop;
                pictureBox.MouseClick += mouseClickRun;
                pictureBox.MouseClick += mouseClickDelete;
                Controls.Add(pictureBox);
                listClass.Add(pictureBox);
            }
        }


        private void агрегацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSvz(0);
        }

        private void композицияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSvz(1);
        }

        private void наследованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSvz(2);
        }

        private void зависимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSvz(3);
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ctrl = this;
                Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height);
                ctrl.DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(saveFileDialog1.FileName);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьКлассВБиблиотекуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassCreator form2 = new ClassCreator();
            form2.Show();
        }
    }
}
