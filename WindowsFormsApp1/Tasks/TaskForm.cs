﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Tasks
{
    public partial class TaskForm : Form
    {
        private string[] rightAws = new string[] { "1", "2", "3", "4" };

        public TaskForm()
        {
            InitializeComponent();
        }

        public void LetsChange()
        {
            switch (RichID.ID)
            {
                case 1:
                    richTextBox1.Text = "1";
                    break;

                case 2:
                    richTextBox1.Text = "2";
                    break;

                case 3:
                    richTextBox1.Text = "3";
                    break;

                case 4:
                    richTextBox1.Text = "4";
                    break;
            }
        }
    }
}