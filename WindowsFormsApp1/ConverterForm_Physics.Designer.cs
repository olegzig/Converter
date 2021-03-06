﻿namespace WindowsFormsApp1
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
            this.button_Volume = new System.Windows.Forms.Button();
            this.button_Energy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Weight
            // 
            this.button_Weight.Location = new System.Drawing.Point(15, 24);
            this.button_Weight.Margin = new System.Windows.Forms.Padding(2);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(158, 32);
            this.button_Weight.TabIndex = 0;
            this.button_Weight.Text = "Масса";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Конвертер величин для физики";
            // 
            // button_Distance
            // 
            this.button_Distance.Location = new System.Drawing.Point(16, 122);
            this.button_Distance.Margin = new System.Windows.Forms.Padding(2);
            this.button_Distance.Name = "button_Distance";
            this.button_Distance.Size = new System.Drawing.Size(158, 32);
            this.button_Distance.TabIndex = 2;
            this.button_Distance.Text = "Расстояние";
            this.button_Distance.UseVisualStyleBackColor = true;
            this.button_Distance.Click += new System.EventHandler(this.button_Distance_Click);
            // 
            // button_Speed
            // 
            this.button_Speed.Location = new System.Drawing.Point(188, 73);
            this.button_Speed.Margin = new System.Windows.Forms.Padding(2);
            this.button_Speed.Name = "button_Speed";
            this.button_Speed.Size = new System.Drawing.Size(158, 32);
            this.button_Speed.TabIndex = 3;
            this.button_Speed.Text = "Скорость";
            this.button_Speed.UseVisualStyleBackColor = true;
            this.button_Speed.Click += new System.EventHandler(this.button_Speed_Click);
            // 
            // button_Frequency
            // 
            this.button_Frequency.Location = new System.Drawing.Point(188, 122);
            this.button_Frequency.Margin = new System.Windows.Forms.Padding(2);
            this.button_Frequency.Name = "button_Frequency";
            this.button_Frequency.Size = new System.Drawing.Size(158, 32);
            this.button_Frequency.TabIndex = 4;
            this.button_Frequency.Text = "Частота";
            this.button_Frequency.UseVisualStyleBackColor = true;
            this.button_Frequency.Click += new System.EventHandler(this.button_Frequency_Click);
            // 
            // button_Power
            // 
            this.button_Power.Location = new System.Drawing.Point(16, 171);
            this.button_Power.Margin = new System.Windows.Forms.Padding(2);
            this.button_Power.Name = "button_Power";
            this.button_Power.Size = new System.Drawing.Size(158, 32);
            this.button_Power.TabIndex = 5;
            this.button_Power.Text = "Сила";
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click);
            // 
            // button_Temperature
            // 
            this.button_Temperature.Location = new System.Drawing.Point(188, 171);
            this.button_Temperature.Margin = new System.Windows.Forms.Padding(2);
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.Size = new System.Drawing.Size(158, 32);
            this.button_Temperature.TabIndex = 6;
            this.button_Temperature.Text = "Температура";
            this.button_Temperature.UseVisualStyleBackColor = true;
            this.button_Temperature.Click += new System.EventHandler(this.button_Temperature_Click);
            // 
            // button_Volume
            // 
            this.button_Volume.Location = new System.Drawing.Point(188, 24);
            this.button_Volume.Margin = new System.Windows.Forms.Padding(2);
            this.button_Volume.Name = "button_Volume";
            this.button_Volume.Size = new System.Drawing.Size(158, 32);
            this.button_Volume.TabIndex = 7;
            this.button_Volume.Text = "Объем";
            this.button_Volume.UseVisualStyleBackColor = true;
            this.button_Volume.Click += new System.EventHandler(this.button_Volume_Click);
            // 
            // button_Energy
            // 
            this.button_Energy.Location = new System.Drawing.Point(15, 73);
            this.button_Energy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Energy.Name = "button_Energy";
            this.button_Energy.Size = new System.Drawing.Size(158, 32);
            this.button_Energy.TabIndex = 8;
            this.button_Energy.Text = "Энергия";
            this.button_Energy.UseVisualStyleBackColor = true;
            this.button_Energy.Click += new System.EventHandler(this.button_Energy_Click);
            // 
            // ConverterForm_Physics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 215);
            this.ControlBox = false;
            this.Controls.Add(this.button_Energy);
            this.Controls.Add(this.button_Volume);
            this.Controls.Add(this.button_Temperature);
            this.Controls.Add(this.button_Power);
            this.Controls.Add(this.button_Frequency);
            this.Controls.Add(this.button_Speed);
            this.Controls.Add(this.button_Distance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Weight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConverterForm_Physics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConverterForm_Physics";
            this.Leave += new System.EventHandler(this.ConverterForm_Physics_Leave);
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
        private System.Windows.Forms.Button button_Volume;
        private System.Windows.Forms.Button button_Energy;
    }
}