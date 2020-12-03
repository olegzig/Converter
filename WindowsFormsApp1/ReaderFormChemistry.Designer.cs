namespace WindowsFormsApp1
{
    partial class ReaderFormChemistry
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OpenButtonRFPhysics = new System.Windows.Forms.Button();
            this.RadioButtonChemistry = new System.Windows.Forms.RadioButton();
            this.RadioButtonPhysic = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(672, 446);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OpenButtonRFPhysics);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButtonChemistry);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButtonPhysic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 120;
            this.splitContainer1.TabIndex = 1;
            // 
            // OpenButtonRFPhysics
            // 
            this.OpenButtonRFPhysics.Location = new System.Drawing.Point(3, 67);
            this.OpenButtonRFPhysics.Name = "OpenButtonRFPhysics";
            this.OpenButtonRFPhysics.Size = new System.Drawing.Size(113, 28);
            this.OpenButtonRFPhysics.TabIndex = 7;
            this.OpenButtonRFPhysics.Text = "Открыть";
            this.OpenButtonRFPhysics.UseVisualStyleBackColor = true;
            // 
            // RadioButtonChemistry
            // 
            this.RadioButtonChemistry.AutoSize = true;
            this.RadioButtonChemistry.Location = new System.Drawing.Point(3, 30);
            this.RadioButtonChemistry.Name = "RadioButtonChemistry";
            this.RadioButtonChemistry.Size = new System.Drawing.Size(71, 21);
            this.RadioButtonChemistry.TabIndex = 8;
            this.RadioButtonChemistry.TabStop = true;
            this.RadioButtonChemistry.Text = "Химия";
            this.RadioButtonChemistry.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPhysic
            // 
            this.RadioButtonPhysic.AutoSize = true;
            this.RadioButtonPhysic.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonPhysic.Name = "RadioButtonPhysic";
            this.RadioButtonPhysic.Size = new System.Drawing.Size(80, 21);
            this.RadioButtonPhysic.TabIndex = 6;
            this.RadioButtonPhysic.TabStop = true;
            this.RadioButtonPhysic.Text = "Физика";
            this.RadioButtonPhysic.UseVisualStyleBackColor = true;
            // 
            // ReaderFormChemistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReaderFormChemistry";
            this.Text = "ReaderFormChemistry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OpenButtonRFPhysics;
        private System.Windows.Forms.RadioButton RadioButtonChemistry;
        private System.Windows.Forms.RadioButton RadioButtonPhysic;
    }
}