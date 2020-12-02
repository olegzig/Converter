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
            this.конвертерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.ридерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конвертерToolStripMenuItem,
            this.ридерToolStripMenuItem,
            this.StripMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(731, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // конвертерToolStripMenuItem
            // 
            this.конвертерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConverterPhysics,
            this.MenuConverterChemistry});
            this.конвертерToolStripMenuItem.Name = "конвертерToolStripMenuItem";
            this.конвертерToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.конвертерToolStripMenuItem.Text = "Конвертер";
            // 
            // MenuConverterPhysics
            // 
            this.MenuConverterPhysics.Name = "MenuConverterPhysics";
            this.MenuConverterPhysics.Size = new System.Drawing.Size(143, 26);
            this.MenuConverterPhysics.Text = "Физика";
            // 
            // MenuConverterChemistry
            // 
            this.MenuConverterChemistry.Name = "MenuConverterChemistry";
            this.MenuConverterChemistry.Size = new System.Drawing.Size(143, 26);
            this.MenuConverterChemistry.Text = "Химия";
            // 
            // ридерToolStripMenuItem
            // 
            this.ридерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReaderPhysics,
            this.MenuReaderChemistry});
            this.ридерToolStripMenuItem.Name = "ридерToolStripMenuItem";
            this.ридерToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ридерToolStripMenuItem.Text = "Ридер";
            // 
            // MenuReaderPhysics
            // 
            this.MenuReaderPhysics.Name = "MenuReaderPhysics";
            this.MenuReaderPhysics.Size = new System.Drawing.Size(143, 26);
            this.MenuReaderPhysics.Text = "Физика";
            // 
            // MenuReaderChemistry
            // 
            this.MenuReaderChemistry.Name = "MenuReaderChemistry";
            this.MenuReaderChemistry.Size = new System.Drawing.Size(143, 26);
            this.MenuReaderChemistry.Text = "Химия";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(83, 24);
            this.StripMenuHelp.Text = "Помощь";
            this.StripMenuHelp.Click += new System.EventHandler(this.StripMenuHelp_Click);
            // 
            // DefaultImage
            // 
            this.DefaultImage.Image = global::WindowsFormsApp1.Properties.Resources.qSRqh_bJOak;
            this.DefaultImage.Location = new System.Drawing.Point(0, 28);
            this.DefaultImage.Name = "DefaultImage";
            this.DefaultImage.Size = new System.Drawing.Size(731, 454);
            this.DefaultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefaultImage.TabIndex = 1;
            this.DefaultImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(731, 482);
            this.Controls.Add(this.DefaultImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem конвертерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuConverterPhysics;
        private System.Windows.Forms.ToolStripMenuItem MenuConverterChemistry;
        private System.Windows.Forms.ToolStripMenuItem ридерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuReaderPhysics;
        private System.Windows.Forms.ToolStripMenuItem MenuReaderChemistry;
        private System.Windows.Forms.PictureBox DefaultImage;
    }
}

