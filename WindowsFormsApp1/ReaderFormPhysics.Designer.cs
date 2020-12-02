namespace WindowsFormsApp1
{
    partial class ReaderFormPhysics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonPhysic = new System.Windows.Forms.RadioButton();
            this.RadioButtonChemistry = new System.Windows.Forms.RadioButton();
            this.OpenButtonRFPhysics = new System.Windows.Forms.Button();
            this.SaveButtonRFPhysics = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenButtonRFPhysics);
            this.groupBox1.Controls.Add(this.SaveButtonRFPhysics);
            this.groupBox1.Controls.Add(this.RadioButtonChemistry);
            this.groupBox1.Controls.Add(this.RadioButtonPhysic);
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RadioButtonPhysic
            // 
            this.RadioButtonPhysic.AutoSize = true;
            this.RadioButtonPhysic.Location = new System.Drawing.Point(7, 22);
            this.RadioButtonPhysic.Name = "RadioButtonPhysic";
            this.RadioButtonPhysic.Size = new System.Drawing.Size(80, 21);
            this.RadioButtonPhysic.TabIndex = 0;
            this.RadioButtonPhysic.TabStop = true;
            this.RadioButtonPhysic.Text = "Физика";
            this.RadioButtonPhysic.UseVisualStyleBackColor = true;
            // 
            // RadioButtonChemistry
            // 
            this.RadioButtonChemistry.AutoSize = true;
            this.RadioButtonChemistry.Location = new System.Drawing.Point(6, 49);
            this.RadioButtonChemistry.Name = "RadioButtonChemistry";
            this.RadioButtonChemistry.Size = new System.Drawing.Size(71, 21);
            this.RadioButtonChemistry.TabIndex = 1;
            this.RadioButtonChemistry.TabStop = true;
            this.RadioButtonChemistry.Text = "Химия";
            this.RadioButtonChemistry.UseVisualStyleBackColor = true;
            // 
            // OpenButtonRFPhysics
            // 
            this.OpenButtonRFPhysics.Location = new System.Drawing.Point(6, 94);
            this.OpenButtonRFPhysics.Name = "OpenButtonRFPhysics";
            this.OpenButtonRFPhysics.Size = new System.Drawing.Size(71, 28);
            this.OpenButtonRFPhysics.TabIndex = 1;
            this.OpenButtonRFPhysics.Text = "Открыть";
            this.OpenButtonRFPhysics.UseVisualStyleBackColor = true;
            // 
            // SaveButtonRFPhysics
            // 
            this.SaveButtonRFPhysics.Location = new System.Drawing.Point(83, 95);
            this.SaveButtonRFPhysics.Name = "SaveButtonRFPhysics";
            this.SaveButtonRFPhysics.Size = new System.Drawing.Size(103, 27);
            this.SaveButtonRFPhysics.TabIndex = 2;
            this.SaveButtonRFPhysics.Text = "Сохранить";
            this.SaveButtonRFPhysics.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(204, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 450);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ReaderFormPhysics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReaderFormPhysics";
            this.Text = "ReaderFormPhysics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonChemistry;
        private System.Windows.Forms.RadioButton RadioButtonPhysic;
        private System.Windows.Forms.Button OpenButtonRFPhysics;
        private System.Windows.Forms.Button SaveButtonRFPhysics;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}