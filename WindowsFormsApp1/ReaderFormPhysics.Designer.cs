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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButtonPhysicPressure = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicPower = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicForce = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicEnergy = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicMass = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicFrequency = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicCurve = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicSpeed = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicAcceleration = new System.Windows.Forms.RadioButton();
            this.OpenButtonRFPhysics = new System.Windows.Forms.Button();
            this.radioButtonPhysicTime = new System.Windows.Forms.RadioButton();
            this.radioButtonPhysicRange = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicPressure);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicPower);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicForce);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicEnergy);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicMass);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicFrequency);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicCurve);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicSpeed);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicAcceleration);
            this.splitContainer1.Panel1.Controls.Add(this.OpenButtonRFPhysics);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicTime);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonPhysicRange);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Size = new System.Drawing.Size(617, 384);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButtonPhysicPressure
            // 
            this.radioButtonPhysicPressure.AutoSize = true;
            this.radioButtonPhysicPressure.Location = new System.Drawing.Point(3, 273);
            this.radioButtonPhysicPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicPressure.Name = "radioButtonPhysicPressure";
            this.radioButtonPhysicPressure.Size = new System.Drawing.Size(95, 21);
            this.radioButtonPhysicPressure.TabIndex = 17;
            this.radioButtonPhysicPressure.TabStop = true;
            this.radioButtonPhysicPressure.Text = "Давление";
            this.radioButtonPhysicPressure.UseVisualStyleBackColor = true;
            this.radioButtonPhysicPressure.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicPower
            // 
            this.radioButtonPhysicPower.AutoSize = true;
            this.radioButtonPhysicPower.Location = new System.Drawing.Point(3, 246);
            this.radioButtonPhysicPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicPower.Name = "radioButtonPhysicPower";
            this.radioButtonPhysicPower.Size = new System.Drawing.Size(96, 21);
            this.radioButtonPhysicPower.TabIndex = 16;
            this.radioButtonPhysicPower.TabStop = true;
            this.radioButtonPhysicPower.Text = "Мощность";
            this.radioButtonPhysicPower.UseVisualStyleBackColor = true;
            this.radioButtonPhysicPower.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicForce
            // 
            this.radioButtonPhysicForce.AutoSize = true;
            this.radioButtonPhysicForce.Location = new System.Drawing.Point(3, 192);
            this.radioButtonPhysicForce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicForce.Name = "radioButtonPhysicForce";
            this.radioButtonPhysicForce.Size = new System.Drawing.Size(62, 21);
            this.radioButtonPhysicForce.TabIndex = 15;
            this.radioButtonPhysicForce.TabStop = true;
            this.radioButtonPhysicForce.Text = "Сила";
            this.radioButtonPhysicForce.UseVisualStyleBackColor = true;
            this.radioButtonPhysicForce.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicEnergy
            // 
            this.radioButtonPhysicEnergy.AutoSize = true;
            this.radioButtonPhysicEnergy.Location = new System.Drawing.Point(3, 219);
            this.radioButtonPhysicEnergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicEnergy.Name = "radioButtonPhysicEnergy";
            this.radioButtonPhysicEnergy.Size = new System.Drawing.Size(83, 21);
            this.radioButtonPhysicEnergy.TabIndex = 14;
            this.radioButtonPhysicEnergy.TabStop = true;
            this.radioButtonPhysicEnergy.Text = "Энергия";
            this.radioButtonPhysicEnergy.UseVisualStyleBackColor = true;
            this.radioButtonPhysicEnergy.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicMass
            // 
            this.radioButtonPhysicMass.AutoSize = true;
            this.radioButtonPhysicMass.Location = new System.Drawing.Point(3, 165);
            this.radioButtonPhysicMass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicMass.Name = "radioButtonPhysicMass";
            this.radioButtonPhysicMass.Size = new System.Drawing.Size(70, 21);
            this.radioButtonPhysicMass.TabIndex = 13;
            this.radioButtonPhysicMass.TabStop = true;
            this.radioButtonPhysicMass.Text = "Масса";
            this.radioButtonPhysicMass.UseVisualStyleBackColor = true;
            this.radioButtonPhysicMass.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicFrequency
            // 
            this.radioButtonPhysicFrequency.AutoSize = true;
            this.radioButtonPhysicFrequency.Location = new System.Drawing.Point(3, 138);
            this.radioButtonPhysicFrequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicFrequency.Name = "radioButtonPhysicFrequency";
            this.radioButtonPhysicFrequency.Size = new System.Drawing.Size(84, 21);
            this.radioButtonPhysicFrequency.TabIndex = 12;
            this.radioButtonPhysicFrequency.TabStop = true;
            this.radioButtonPhysicFrequency.Text = "Частота";
            this.radioButtonPhysicFrequency.UseVisualStyleBackColor = true;
            this.radioButtonPhysicFrequency.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicCurve
            // 
            this.radioButtonPhysicCurve.AutoSize = true;
            this.radioButtonPhysicCurve.Location = new System.Drawing.Point(3, 111);
            this.radioButtonPhysicCurve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicCurve.Name = "radioButtonPhysicCurve";
            this.radioButtonPhysicCurve.Size = new System.Drawing.Size(116, 21);
            this.radioButtonPhysicCurve.TabIndex = 11;
            this.radioButtonPhysicCurve.TabStop = true;
            this.radioButtonPhysicCurve.Text = "Искревление";
            this.radioButtonPhysicCurve.UseVisualStyleBackColor = true;
            this.radioButtonPhysicCurve.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicSpeed
            // 
            this.radioButtonPhysicSpeed.AutoSize = true;
            this.radioButtonPhysicSpeed.Location = new System.Drawing.Point(3, 57);
            this.radioButtonPhysicSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicSpeed.Name = "radioButtonPhysicSpeed";
            this.radioButtonPhysicSpeed.Size = new System.Drawing.Size(90, 21);
            this.radioButtonPhysicSpeed.TabIndex = 10;
            this.radioButtonPhysicSpeed.TabStop = true;
            this.radioButtonPhysicSpeed.Text = "Скорость";
            this.radioButtonPhysicSpeed.UseVisualStyleBackColor = true;
            this.radioButtonPhysicSpeed.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicAcceleration
            // 
            this.radioButtonPhysicAcceleration.AutoSize = true;
            this.radioButtonPhysicAcceleration.Location = new System.Drawing.Point(3, 84);
            this.radioButtonPhysicAcceleration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicAcceleration.Name = "radioButtonPhysicAcceleration";
            this.radioButtonPhysicAcceleration.Size = new System.Drawing.Size(100, 21);
            this.radioButtonPhysicAcceleration.TabIndex = 9;
            this.radioButtonPhysicAcceleration.TabStop = true;
            this.radioButtonPhysicAcceleration.Text = "Ускорение";
            this.radioButtonPhysicAcceleration.UseVisualStyleBackColor = true;
            this.radioButtonPhysicAcceleration.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // OpenButtonRFPhysics
            // 
            this.OpenButtonRFPhysics.Location = new System.Drawing.Point(12, 294);
            this.OpenButtonRFPhysics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenButtonRFPhysics.Name = "OpenButtonRFPhysics";
            this.OpenButtonRFPhysics.Size = new System.Drawing.Size(109, 28);
            this.OpenButtonRFPhysics.TabIndex = 7;
            this.OpenButtonRFPhysics.Text = "Открыть";
            this.OpenButtonRFPhysics.UseVisualStyleBackColor = true;
            this.OpenButtonRFPhysics.Click += new System.EventHandler(this.OpenButtonRFPhysics_Click);
            // 
            // radioButtonPhysicTime
            // 
            this.radioButtonPhysicTime.AutoSize = true;
            this.radioButtonPhysicTime.Location = new System.Drawing.Point(3, 30);
            this.radioButtonPhysicTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicTime.Name = "radioButtonPhysicTime";
            this.radioButtonPhysicTime.Size = new System.Drawing.Size(71, 21);
            this.radioButtonPhysicTime.TabIndex = 8;
            this.radioButtonPhysicTime.TabStop = true;
            this.radioButtonPhysicTime.Text = "Время";
            this.radioButtonPhysicTime.UseVisualStyleBackColor = true;
            this.radioButtonPhysicTime.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // radioButtonPhysicRange
            // 
            this.radioButtonPhysicRange.AutoSize = true;
            this.radioButtonPhysicRange.Location = new System.Drawing.Point(3, 2);
            this.radioButtonPhysicRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonPhysicRange.Name = "radioButtonPhysicRange";
            this.radioButtonPhysicRange.Size = new System.Drawing.Size(72, 21);
            this.radioButtonPhysicRange.TabIndex = 6;
            this.radioButtonPhysicRange.TabStop = true;
            this.radioButtonPhysicRange.Text = "Длина";
            this.radioButtonPhysicRange.UseVisualStyleBackColor = true;
            this.radioButtonPhysicRange.CheckedChanged += new System.EventHandler(this.radioButtonPhysicPressure_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(469, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // ReaderFormPhysics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(617, 384);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReaderFormPhysics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReaderFormPhysics";
            this.Leave += new System.EventHandler(this.ReaderFormPhysics_Leave);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button OpenButtonRFPhysics;
        private System.Windows.Forms.RadioButton radioButtonPhysicTime;
        private System.Windows.Forms.RadioButton radioButtonPhysicRange;
        private System.Windows.Forms.RadioButton radioButtonPhysicPressure;
        private System.Windows.Forms.RadioButton radioButtonPhysicPower;
        private System.Windows.Forms.RadioButton radioButtonPhysicForce;
        private System.Windows.Forms.RadioButton radioButtonPhysicEnergy;
        private System.Windows.Forms.RadioButton radioButtonPhysicMass;
        private System.Windows.Forms.RadioButton radioButtonPhysicFrequency;
        private System.Windows.Forms.RadioButton radioButtonPhysicCurve;
        private System.Windows.Forms.RadioButton radioButtonPhysicSpeed;
        private System.Windows.Forms.RadioButton radioButtonPhysicAcceleration;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}