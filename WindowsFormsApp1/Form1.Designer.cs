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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.конвертерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.ридерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.калькуляторToolStripMenuItem,
            this.StripMenuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(622, 30);
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
            this.MenuConverterPhysics.Size = new System.Drawing.Size(189, 26);
            this.MenuConverterPhysics.Text = "Физика";
            this.MenuConverterPhysics.Click += new System.EventHandler(this.MenuConverterPhysics_Click);
            // 
            // MenuConverterChemistry
            // 
            this.MenuConverterChemistry.Name = "MenuConverterChemistry";
            this.MenuConverterChemistry.Size = new System.Drawing.Size(189, 26);
            this.MenuConverterChemistry.Text = "Информатика";
            this.MenuConverterChemistry.Click += new System.EventHandler(this.MenuConverterChemistry_Click);
            // 
            // ридерToolStripMenuItem
            // 
            this.ридерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReaderPhysics,
            this.MenuReaderChemistry});
            this.ридерToolStripMenuItem.Name = "ридерToolStripMenuItem";
            this.ридерToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ридерToolStripMenuItem.Text = "Глоссарий";
            // 
            // MenuReaderPhysics
            // 
            this.MenuReaderPhysics.Name = "MenuReaderPhysics";
            this.MenuReaderPhysics.Size = new System.Drawing.Size(189, 26);
            this.MenuReaderPhysics.Text = "Физика";
            this.MenuReaderPhysics.Click += new System.EventHandler(this.MenuReaderPhysics_Click);
            // 
            // MenuReaderChemistry
            // 
            this.MenuReaderChemistry.Name = "MenuReaderChemistry";
            this.MenuReaderChemistry.Size = new System.Drawing.Size(189, 26);
            this.MenuReaderChemistry.Text = "Информатика";
            this.MenuReaderChemistry.Click += new System.EventHandler(this.MenuReaderChemistry_Click);
            // 
            // калькуляторToolStripMenuItem
            // 
            this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
            this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.калькуляторToolStripMenuItem.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.CalcInvoke_Click);
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(128, 24);
            this.StripMenuHelp.Text = "О приложении";
            this.StripMenuHelp.Click += new System.EventHandler(this.StripMenuHelp_Click);
            // 
            // DefaultImage
            // 
            this.DefaultImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultImage.Image = global::WindowsFormsApp1.Properties.Resources.qSRqh_bJOak;
            this.DefaultImage.Location = new System.Drawing.Point(0, 30);
            this.DefaultImage.Name = "DefaultImage";
            this.DefaultImage.Size = new System.Drawing.Size(622, 383);
            this.DefaultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefaultImage.TabIndex = 1;
            this.DefaultImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.DefaultImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Converter";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
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
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
    }
}

