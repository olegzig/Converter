﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

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

    }
}
