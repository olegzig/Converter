﻿using System;
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
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
