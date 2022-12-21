using System;
using System.Drawing;
using System.Windows.Forms;

namespace Class_Diagram_1
{
    public partial class ClassCreator : Form
    {
        public ClassCreator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int size = 20;
            pictureBox1.Height = (dataGridView1.Rows.Count + dataGridView2.Rows.Count -2) * size + size;
            Bitmap bitmap;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            Graphics graph = Graphics.FromImage(bitmap);
            graph.Clear(SystemColors.Window);
            Font fontName = new Font("Times New Roman", 10);
            Font font = new Font("Times New Roman", 8);
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            Rectangle rectName = new Rectangle(0, 0, pictureBox1.Width - 1, size);
            graph.DrawRectangle(pen, rectName);
            graph.DrawString(textBox1.Text, fontName, brush, 4, 4);

            Rectangle rectField = new Rectangle(0, size - 1, pictureBox1.Width - 1, (dataGridView2.Rows.Count-1) * size);
            graph.DrawRectangle(pen, rectField);
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                graph.DrawString(Convert.ToString(dataGridView2.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView2.Rows[i].Cells[2].Value) + ": " + Convert.ToString(dataGridView2.Rows[i].Cells[1].Value), font, brush, 5, 5 + size + i * size);
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                graph.DrawString(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + "(" + Convert.ToString(dataGridView1.Rows[i].Cells[3].Value) + "): " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value), font, brush, 5, 5 + size * (dataGridView2.Rows.Count-1) + size + i * size);
            }
            Rectangle rectMethod = new Rectangle(0, (dataGridView2.Rows.Count-1) * 20 + 20 - 1, pictureBox1.Width - 1, (dataGridView1.Rows.Count-1) * 20);
            graph.DrawRectangle(pen, rectMethod);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Invalidate();
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
