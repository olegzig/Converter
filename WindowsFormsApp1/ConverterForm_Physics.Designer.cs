namespace WindowsFormsApp1
{
    partial class ConverterForm_Physics
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
            this.button_Weight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Distance = new System.Windows.Forms.Button();
            this.button_Speed = new System.Windows.Forms.Button();
            this.button_Frequency = new System.Windows.Forms.Button();
            this.button_Power = new System.Windows.Forms.Button();
            this.button_Temperature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Weight
            // 
            this.button_Weight.Location = new System.Drawing.Point(82, 72);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(75, 23);
            this.button_Weight.TabIndex = 0;
            this.button_Weight.Text = "Масса";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Конвертер величин для физики";
            // 
            // button_Distance
            // 
            this.button_Distance.Location = new System.Drawing.Point(296, 72);
            this.button_Distance.Name = "button_Distance";
            this.button_Distance.Size = new System.Drawing.Size(124, 23);
            this.button_Distance.TabIndex = 2;
            this.button_Distance.Text = "Расстояние";
            this.button_Distance.UseVisualStyleBackColor = true;
            this.button_Distance.Click += new System.EventHandler(this.button_Distance_Click);
            // 
            // button_Speed
            // 
            this.button_Speed.Location = new System.Drawing.Point(82, 163);
            this.button_Speed.Name = "button_Speed";
            this.button_Speed.Size = new System.Drawing.Size(88, 23);
            this.button_Speed.TabIndex = 3;
            this.button_Speed.Text = "Скорость";
            this.button_Speed.UseVisualStyleBackColor = true;
            // 
            // button_Frequency
            // 
            this.button_Frequency.Location = new System.Drawing.Point(345, 116);
            this.button_Frequency.Name = "button_Frequency";
            this.button_Frequency.Size = new System.Drawing.Size(75, 23);
            this.button_Frequency.TabIndex = 4;
            this.button_Frequency.Text = "Частота";
            this.button_Frequency.UseVisualStyleBackColor = true;
            // 
            // button_Power
            // 
            this.button_Power.Location = new System.Drawing.Point(345, 163);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(75, 23);
            this.button_Power.TabIndex = 5;
            this.button_Power.Text = "Сила";
            this.button_Power.UseVisualStyleBackColor = true;
            // 
            // button_Temperature
            // 
            this.button_Temperature.Location = new System.Drawing.Point(82, 116);
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.Size = new System.Drawing.Size(108, 23);
            this.button_Temperature.TabIndex = 6;
            this.button_Temperature.Text = "Температура";
            this.button_Temperature.UseVisualStyleBackColor = true;
            // 
            // ConverterForm_Physics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_Temperature);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_Frequency);
            this.Controls.Add(this.button_Speed);
            this.Controls.Add(this.button_Distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Weight);
            this.Name = "ConverterForm_Physics";
            this.Text = "ConverterForm_Physics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Distance;
        private System.Windows.Forms.Button button_Speed;
        private System.Windows.Forms.Button button_Frequency;
        private System.Windows.Forms.Button button_Power;
        private System.Windows.Forms.Button button_Temperature;
    }
}