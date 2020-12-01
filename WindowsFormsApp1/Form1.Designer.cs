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
            this.StripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConverterChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.ридерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderPhysics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReaderChemistry = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultImage = new System.Windows.Forms.PictureBox();
            this.PhysicConverterPanel = new System.Windows.Forms.Panel();
            this.ChemistryConverterPanel = new System.Windows.Forms.Panel();
            this.PhysicReaderPanel = new System.Windows.Forms.Panel();
            this.ChemistryReaderPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DefaultImage)).BeginInit();
            this.PhysicConverterPanel.SuspendLayout();
            this.ChemistryConverterPanel.SuspendLayout();
            this.PhysicReaderPanel.SuspendLayout();
            this.ChemistryReaderPanel.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(731, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuHelp
            // 
            this.StripMenuHelp.Name = "StripMenuHelp";
            this.StripMenuHelp.Size = new System.Drawing.Size(68, 19);
            this.StripMenuHelp.Text = "Помощь";
            this.StripMenuHelp.Click += new System.EventHandler(this.StripMenuHelp_Click);
            // 
            // конвертерToolStripMenuItem
            // 
            this.конвертерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConverterPhysics,
            this.MenuConverterChemistry});
            this.конвертерToolStripMenuItem.Name = "конвертерToolStripMenuItem";
            this.конвертерToolStripMenuItem.Size = new System.Drawing.Size(77, 19);
            this.конвертерToolStripMenuItem.Text = "Конвертер";
            // 
            // MenuConverterPhysics
            // 
            this.MenuConverterPhysics.Name = "MenuConverterPhysics";
            this.MenuConverterPhysics.Size = new System.Drawing.Size(180, 22);
            this.MenuConverterPhysics.Text = "Физика";
            this.MenuConverterPhysics.Click += new System.EventHandler(this.MenuConverterPhysics_Click);
            // 
            // MenuConverterChemistry
            // 
            this.MenuConverterChemistry.Name = "MenuConverterChemistry";
            this.MenuConverterChemistry.Size = new System.Drawing.Size(180, 22);
            this.MenuConverterChemistry.Text = "Химия";
            this.MenuConverterChemistry.Click += new System.EventHandler(this.MenuConverterChemistry_Click);
            // 
            // ридерToolStripMenuItem
            // 
            this.ридерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReaderPhysics,
            this.MenuReaderChemistry});
            this.ридерToolStripMenuItem.Name = "ридерToolStripMenuItem";
            this.ридерToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.ридерToolStripMenuItem.Text = "Ридер";
            // 
            // MenuReaderPhysics
            // 
            this.MenuReaderPhysics.Name = "MenuReaderPhysics";
            this.MenuReaderPhysics.Size = new System.Drawing.Size(180, 22);
            this.MenuReaderPhysics.Text = "Физика";
            this.MenuReaderPhysics.Click += new System.EventHandler(this.MenuReaderPhysics_Click);
            // 
            // MenuReaderChemistry
            // 
            this.MenuReaderChemistry.Name = "MenuReaderChemistry";
            this.MenuReaderChemistry.Size = new System.Drawing.Size(180, 22);
            this.MenuReaderChemistry.Text = "Химия";
            this.MenuReaderChemistry.Click += new System.EventHandler(this.MenuReaderChemistry_Click);
            // 
            // DefaultImage
            // 
            this.DefaultImage.Image = ((System.Drawing.Image)(resources.GetObject("DefaultImage.Image")));
            this.DefaultImage.Location = new System.Drawing.Point(0, 28);
            this.DefaultImage.Name = "DefaultImage";
            this.DefaultImage.Size = new System.Drawing.Size(731, 454);
            this.DefaultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefaultImage.TabIndex = 1;
            this.DefaultImage.TabStop = false;
            // 
            // PhysicConverterPanel
            // 
            this.PhysicConverterPanel.Controls.Add(this.ChemistryConverterPanel);
            this.PhysicConverterPanel.Location = new System.Drawing.Point(0, 29);
            this.PhysicConverterPanel.Name = "PhysicConverterPanel";
            this.PhysicConverterPanel.Size = new System.Drawing.Size(731, 453);
            this.PhysicConverterPanel.TabIndex = 2;
            this.PhysicConverterPanel.Visible = false;
            // 
            // ChemistryConverterPanel
            // 
            this.ChemistryConverterPanel.Controls.Add(this.PhysicReaderPanel);
            this.ChemistryConverterPanel.Location = new System.Drawing.Point(8, 8);
            this.ChemistryConverterPanel.Name = "ChemistryConverterPanel";
            this.ChemistryConverterPanel.Size = new System.Drawing.Size(731, 453);
            this.ChemistryConverterPanel.TabIndex = 3;
            this.ChemistryConverterPanel.Visible = false;
            // 
            // PhysicReaderPanel
            // 
            this.PhysicReaderPanel.Controls.Add(this.ChemistryReaderPanel);
            this.PhysicReaderPanel.Location = new System.Drawing.Point(8, 8);
            this.PhysicReaderPanel.Name = "PhysicReaderPanel";
            this.PhysicReaderPanel.Size = new System.Drawing.Size(731, 453);
            this.PhysicReaderPanel.TabIndex = 4;
            this.PhysicReaderPanel.Visible = false;
            // 
            // ChemistryReaderPanel
            // 
            this.ChemistryReaderPanel.Controls.Add(this.panel1);
            this.ChemistryReaderPanel.Location = new System.Drawing.Point(8, 8);
            this.ChemistryReaderPanel.Name = "ChemistryReaderPanel";
            this.ChemistryReaderPanel.Size = new System.Drawing.Size(731, 453);
            this.ChemistryReaderPanel.TabIndex = 5;
            this.ChemistryReaderPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 453);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(731, 482);
            this.Controls.Add(this.PhysicConverterPanel);
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
            this.PhysicConverterPanel.ResumeLayout(false);
            this.ChemistryConverterPanel.ResumeLayout(false);
            this.PhysicReaderPanel.ResumeLayout(false);
            this.ChemistryReaderPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PhysicConverterPanel;
        private System.Windows.Forms.Panel ChemistryConverterPanel;
        private System.Windows.Forms.Panel PhysicReaderPanel;
        private System.Windows.Forms.Panel ChemistryReaderPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

