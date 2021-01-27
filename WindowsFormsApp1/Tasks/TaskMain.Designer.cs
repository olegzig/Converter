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
            this.MathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задание2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пример2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.задание1ToolStripMenuItem,
            this.задание2ToolStripMenuItem});
            this.PhysicToolStripMenuItem.Name = "PhysicToolStripMenuItem";
            this.PhysicToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.PhysicToolStripMenuItem.Text = "Физика";
            // 
            // MathToolStripMenuItem
            // 
            this.MathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пример1ToolStripMenuItem,
            this.пример2ToolStripMenuItem});
            this.MathToolStripMenuItem.Name = "MathToolStripMenuItem";
            this.MathToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.MathToolStripMenuItem.Text = "Математика";
            // 
            // задание1ToolStripMenuItem
            // 
            this.задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            this.задание1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.задание1ToolStripMenuItem.Text = "Пример 1";
            // 
            // задание2ToolStripMenuItem
            // 
            this.задание2ToolStripMenuItem.Name = "задание2ToolStripMenuItem";
            this.задание2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.задание2ToolStripMenuItem.Text = "Задание 2";
            // 
            // пример1ToolStripMenuItem
            // 
            this.пример1ToolStripMenuItem.Name = "пример1ToolStripMenuItem";
            this.пример1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пример1ToolStripMenuItem.Text = "Пример 1";
            // 
            // пример2ToolStripMenuItem
            // 
            this.пример2ToolStripMenuItem.Name = "пример2ToolStripMenuItem";
            this.пример2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пример2ToolStripMenuItem.Text = "Пример 2";
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
        private System.Windows.Forms.ToolStripMenuItem задание1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задание2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пример2ToolStripMenuItem;
    }
}