using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConverterForm_Physics : Form
    {
        public ConverterForm_Physics()
        {
            InitializeComponent();
        }

        private void button_Distance_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Distance CFPDistance = new ConverterForm_Physics_Distance();
            CFPDistance.MdiParent = this.MdiParent;
            CFPDistance.Show();
        }

        private void button_Weight_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Weight CFPWeight = new ConverterForm_Physics_Weight();
            CFPWeight.MdiParent = this.MdiParent;
            CFPWeight.Show();
        }

        private void button_Temperature_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Temperature CFPTemperature = new ConverterForm_Physics_Temperature();
            CFPTemperature.MdiParent = this.MdiParent;
            CFPTemperature.Show();
        }

        private void button_Frequency_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Frequency CFPFrequency = new ConverterForm_Physics_Frequency();
            CFPFrequency.MdiParent = this.MdiParent;
            CFPFrequency.Show();
        }

        private void button_Speed_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Speed CFPSpeed = new ConverterForm_Physics_Speed();
            CFPSpeed.MdiParent = this.MdiParent;
            CFPSpeed.Show();
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Power CFPPower = new ConverterForm_Physics_Power();
            CFPPower.MdiParent = this.MdiParent;
            CFPPower.Show();
        }

        private void button_Volume_Click(object sender, EventArgs e)
        {
            ConverterForm_Physics_Volume CFPVolume = new ConverterForm_Physics_Volume();
            CFPVolume.MdiParent = this.MdiParent;
            CFPVolume.Show();
        }
    }
}
