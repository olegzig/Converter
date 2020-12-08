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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm_Physics));
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
            resources.ApplyResources(this.button_Weight, "button_Weight");
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button_Distance
            // 
            resources.ApplyResources(this.button_Distance, "button_Distance");
            this.button_Distance.Name = "button_Distance";
            this.button_Distance.UseVisualStyleBackColor = true;
            this.button_Distance.Click += new System.EventHandler(this.button_Distance_Click);
            // 
            // button_Speed
            // 
            resources.ApplyResources(this.button_Speed, "button_Speed");
            this.button_Speed.Name = "button_Speed";
            this.button_Speed.UseVisualStyleBackColor = true;
            this.button_Speed.Click += new System.EventHandler(this.button_Speed_Click);
            // 
            // button_Frequency
            // 
            resources.ApplyResources(this.button_Frequency, "button_Frequency");
            this.button_Frequency.Name = "button_Frequency";
            this.button_Frequency.UseVisualStyleBackColor = true;
            this.button_Frequency.Click += new System.EventHandler(this.button_Frequency_Click);
            // 
            // button_Power
            // 
            resources.ApplyResources(this.button_Power, "button_Power");
            this.button_Power.Name = "button_Power";
            this.button_Power.UseVisualStyleBackColor = true;
            this.button_Power.Click += new System.EventHandler(this.button_Power_Click);
            // 
            // button_Temperature
            // 
            resources.ApplyResources(this.button_Temperature, "button_Temperature");
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.UseVisualStyleBackColor = true;
            this.button_Temperature.Click += new System.EventHandler(this.button_Temperature_Click);
            // 
            // button_Volume
            // 
            resources.ApplyResources(this.button_Volume, "button_Volume");
            this.button_Volume.Name = "button_Volume";
            this.button_Volume.UseVisualStyleBackColor = true;
            this.button_Volume.Click += new System.EventHandler(this.button_Volume_Click);
            // 
            // button_Energy
            // 
            resources.ApplyResources(this.button_Energy, "button_Energy");
            this.button_Energy.Name = "button_Energy";
            this.button_Energy.UseVisualStyleBackColor = true;
            this.button_Energy.Click += new System.EventHandler(this.button_Energy_Click);
            // 
            // ConverterForm_Physics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "ConverterForm_Physics";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
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