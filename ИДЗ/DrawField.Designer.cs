namespace Class_Diagram_1
{
    partial class DrawField
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьКлассВБиблиотекуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлассToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.агрегацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.композицияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наследованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зависимостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлассВБиблиотекуToolStripMenuItem,
            this.добавитьКлассToolStripMenuItem,
            this.добавитьСвязьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(743, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьКлассВБиблиотекуToolStripMenuItem
            // 
            this.добавитьКлассВБиблиотекуToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьКлассВБиблиотекуToolStripMenuItem.Name = "добавитьКлассВБиблиотекуToolStripMenuItem";
            this.добавитьКлассВБиблиотекуToolStripMenuItem.Size = new System.Drawing.Size(189, 23);
            this.добавитьКлассВБиблиотекуToolStripMenuItem.Text = "Добавить класс в файл";
            this.добавитьКлассВБиблиотекуToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлассВБиблиотекуToolStripMenuItem_Click);
            // 
            // добавитьКлассToolStripMenuItem
            // 
            this.добавитьКлассToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.добавитьКлассToolStripMenuItem.Name = "добавитьКлассToolStripMenuItem";
            this.добавитьКлассToolStripMenuItem.Size = new System.Drawing.Size(229, 23);
            this.добавитьКлассToolStripMenuItem.Text = "Добавить класс в диаграмму";
            this.добавитьКлассToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлассToolStripMenuItem_Click);
            // 
            // добавитьСвязьToolStripMenuItem
            // 
            this.добавитьСвязьToolStripMenuItem.Checked = true;
            this.добавитьСвязьToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.добавитьСвязьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.агрегацияToolStripMenuItem,
            this.композицияToolStripMenuItem,
            this.наследованиеToolStripMenuItem,
            this.зависимостьToolStripMenuItem});
            this.добавитьСвязьToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.добавитьСвязьToolStripMenuItem.Name = "добавитьСвязьToolStripMenuItem";
            this.добавитьСвязьToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.добавитьСвязьToolStripMenuItem.Text = "Добавить связь";
            // 
            // агрегацияToolStripMenuItem
            // 
            this.агрегацияToolStripMenuItem.Name = "агрегацияToolStripMenuItem";
            this.агрегацияToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.агрегацияToolStripMenuItem.Text = "Агрегация";
            this.агрегацияToolStripMenuItem.Click += new System.EventHandler(this.агрегацияToolStripMenuItem_Click);
            // 
            // композицияToolStripMenuItem
            // 
            this.композицияToolStripMenuItem.Name = "композицияToolStripMenuItem";
            this.композицияToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.композицияToolStripMenuItem.Text = "Композиция";
            this.композицияToolStripMenuItem.Click += new System.EventHandler(this.композицияToolStripMenuItem_Click);
            // 
            // наследованиеToolStripMenuItem
            // 
            this.наследованиеToolStripMenuItem.Name = "наследованиеToolStripMenuItem";
            this.наследованиеToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.наследованиеToolStripMenuItem.Text = "Наследование";
            this.наследованиеToolStripMenuItem.Click += new System.EventHandler(this.наследованиеToolStripMenuItem_Click);
            // 
            // зависимостьToolStripMenuItem
            // 
            this.зависимостьToolStripMenuItem.Name = "зависимостьToolStripMenuItem";
            this.зависимостьToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.зависимостьToolStripMenuItem.Text = "Зависимость";
            this.зависимостьToolStripMenuItem.Click += new System.EventHandler(this.зависимостьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Диаграмма классв";
            this.saveFileDialog1.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*\\\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "test";
            this.openFileDialog1.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*\"";
            // 
            // DrawField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DrawField";
            this.Text = "Классовая диаграмма";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлассToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлассВБиблиотекуToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСвязьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem агрегацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem композицияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наследованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зависимостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

