namespace WindowsFormsApp1.Tasks
{
    partial class TaskMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PhysicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhyisicT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhyisicT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MathT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MathT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.PhysicToolStripMenuItem,
            this.MathToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // PhysicToolStripMenuItem
            // 
            this.PhysicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhyisicT1ToolStripMenuItem,
            this.PhyisicT2ToolStripMenuItem});
            this.PhysicToolStripMenuItem.Name = "PhysicToolStripMenuItem";
            this.PhysicToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.PhysicToolStripMenuItem.Text = "Физика";
            // 
            // PhyisicT1ToolStripMenuItem
            // 
            this.PhyisicT1ToolStripMenuItem.Name = "PhyisicT1ToolStripMenuItem";
            this.PhyisicT1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PhyisicT1ToolStripMenuItem.Text = "Пример 1";
            this.PhyisicT1ToolStripMenuItem.Click += new System.EventHandler(this.PhyisicT1ToolStripMenuItem_Click);
            // 
            // PhyisicT2ToolStripMenuItem
            // 
            this.PhyisicT2ToolStripMenuItem.Name = "PhyisicT2ToolStripMenuItem";
            this.PhyisicT2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PhyisicT2ToolStripMenuItem.Text = "Задание 2";
            this.PhyisicT2ToolStripMenuItem.Click += new System.EventHandler(this.PhyisicT2ToolStripMenuItem_Click);
            // 
            // MathToolStripMenuItem
            // 
            this.MathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MathT1ToolStripMenuItem,
            this.MathT2ToolStripMenuItem});
            this.MathToolStripMenuItem.Name = "MathToolStripMenuItem";
            this.MathToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.MathToolStripMenuItem.Text = "Математика";
            // 
            // MathT1ToolStripMenuItem
            // 
            this.MathT1ToolStripMenuItem.Name = "MathT1ToolStripMenuItem";
            this.MathT1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MathT1ToolStripMenuItem.Text = "Пример 1";
            this.MathT1ToolStripMenuItem.Click += new System.EventHandler(this.MathT1ToolStripMenuItem_Click);
            // 
            // MathT2ToolStripMenuItem
            // 
            this.MathT2ToolStripMenuItem.Name = "MathT2ToolStripMenuItem";
            this.MathT2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MathT2ToolStripMenuItem.Text = "Пример 2";
            this.MathT2ToolStripMenuItem.Click += new System.EventHandler(this.MathT2ToolStripMenuItem_Click);
            // 
            // TaskMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Безымян22ный;
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TaskMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TaskPhysic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PhysicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhyisicT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhyisicT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MathT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MathT2ToolStripMenuItem;
    }
}