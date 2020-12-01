namespace WindowsFormsApp1
{
    partial class Form1
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
            this.StripMenuForm = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFormConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFormFileReader = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuForm,
            this.StripMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(731, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuForm
            // 
            this.StripMenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFormConverter,
            this.StripMenuFormFileReader});
            this.StripMenuForm.Name = "StripMenuForm";
            this.StripMenuForm.Size = new System.Drawing.Size(57, 19);
            this.StripMenuForm.Text = "Форма";
            // 
            // StripMenuFormConverter
            // 
            this.StripMenuFormConverter.Name = "StripMenuFormConverter";
            this.StripMenuFormConverter.Size = new System.Drawing.Size(180, 22);
            this.StripMenuFormConverter.Text = "Конвертер";
            // 
            // StripMenuFormFileReader
            // 
            this.StripMenuFormFileReader.Name = "StripMenuFormFileReader";
            this.StripMenuFormFileReader.Size = new System.Drawing.Size(180, 22);
            this.StripMenuFormFileReader.Text = "Ридер";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(68, 19);
            this.StripMenuHelp.Text = "Помощь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(731, 482);
            this.Controls.Add(this.menuStrip1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuForm;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFormConverter;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFormFileReader;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelp;
    }
}

