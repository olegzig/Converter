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
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFormConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFormFileReader = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuForm
            // 
            this.StripMenuForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFormConverter,
            this.StripMenuFormFileReader});
            this.StripMenuForm.Name = "StripMenuForm";
            this.StripMenuForm.Size = new System.Drawing.Size(71, 24);
            this.StripMenuForm.Text = "Форма";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(83, 24);
            this.StripMenuHelp.Text = "Помощь";
            // 
            // StripMenuFormConverter
            // 
            this.StripMenuFormConverter.Name = "StripMenuFormConverter";
            this.StripMenuFormConverter.Size = new System.Drawing.Size(224, 26);
            this.StripMenuFormConverter.Text = "Конвертер";
            // 
            // StripMenuFormFileReader
            // 
            this.StripMenuFormFileReader.Name = "StripMenuFormFileReader";
            this.StripMenuFormFileReader.Size = new System.Drawing.Size(224, 26);
            this.StripMenuFormFileReader.Text = "Ридер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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

