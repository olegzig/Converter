﻿namespace WindowsFormsApp1
{
    partial class ReaderFormInformaic
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
            this.RadioButtonInformaticsMass = new System.Windows.Forms.RadioButton();
            this.RadioButtonInformaticsMathSystems = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(395, 380);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.OpenButtonRFPhysics);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButtonInformaticsMass);
            this.splitContainer1.Panel1.Controls.Add(this.RadioButtonInformaticsMathSystems);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(617, 384);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 1;
            // 
            // OpenButtonRFPhysics
            // 
            this.OpenButtonRFPhysics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenButtonRFPhysics.Location = new System.Drawing.Point(51, 55);
            this.OpenButtonRFPhysics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButtonRFPhysics.Name = "OpenButtonRFPhysics";
            this.OpenButtonRFPhysics.Size = new System.Drawing.Size(113, 32);
            this.OpenButtonRFPhysics.TabIndex = 7;
            this.OpenButtonRFPhysics.Text = "Открыть файл";
            this.OpenButtonRFPhysics.UseVisualStyleBackColor = true;
            this.OpenButtonRFPhysics.Click += new System.EventHandler(this.OpenButtonRFPhysics_Click);
            // 
            // RadioButtonInformaticsMass
            // 
            this.RadioButtonInformaticsMass.AutoSize = true;
            this.RadioButtonInformaticsMass.Location = new System.Drawing.Point(3, 30);
            this.RadioButtonInformaticsMass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonInformaticsMass.Name = "RadioButtonInformaticsMass";
            this.RadioButtonInformaticsMass.Size = new System.Drawing.Size(53, 21);
            this.RadioButtonInformaticsMass.TabIndex = 8;
            this.RadioButtonInformaticsMass.Text = "Вес";
            this.RadioButtonInformaticsMass.UseVisualStyleBackColor = true;
            this.RadioButtonInformaticsMass.CheckedChanged += new System.EventHandler(this.RadioButtonChemistry_CheckedChanged);
            // 
            // RadioButtonInformaticsMathSystems
            // 
            this.RadioButtonInformaticsMathSystems.AutoSize = true;
            this.RadioButtonInformaticsMathSystems.Location = new System.Drawing.Point(3, 2);
            this.RadioButtonInformaticsMathSystems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonInformaticsMathSystems.Name = "RadioButtonInformaticsMathSystems";
            this.RadioButtonInformaticsMathSystems.Size = new System.Drawing.Size(161, 21);
            this.RadioButtonInformaticsMathSystems.TabIndex = 6;
            this.RadioButtonInformaticsMathSystems.TabStop = true;
            this.RadioButtonInformaticsMathSystems.Text = "Системы счисления";
            this.RadioButtonInformaticsMathSystems.UseVisualStyleBackColor = true;
            this.RadioButtonInformaticsMathSystems.CheckedChanged += new System.EventHandler(this.RadioButtonChemistry_CheckedChanged);
            // 
            // ReaderFormInformaic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 384);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReaderFormInformaic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReaderFormInformatics";
            this.Leave += new System.EventHandler(this.ReaderFormInformaic_Leave);
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
        private System.Windows.Forms.RadioButton RadioButtonInformaticsMass;
        private System.Windows.Forms.RadioButton RadioButtonInformaticsMathSystems;
    }
}