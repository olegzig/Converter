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
        private string[] rightAws = new string[] { "Senjor Le Costylio", "1", "7853,9", "3", "4" };
        bool shitHappens = true;

        public TaskForm()
        {
            InitializeComponent();
        }

        public void LetsChange()
        {
            switch (RichID.ID)
            {
                case 1:
                    richTextBox1.Text = "Дано:";//p1
                    break;

                case 2:
                    richTextBox1.Text = "Дано: \nНайти: .\nФормулы: ";//m1
                    break;

                case 3:
                    richTextBox1.Text = "phys2";//p2
                    break;

                case 4:
                    richTextBox1.Text = "math2";//m2
                    break;
            }
        }

        private void AwsChk_Click(object sender, EventArgs e)
        {
            if (shitHappens)
            {
                label1.Visible = true;
                shitHappens = false;
            }

            if(textBox1.Text == rightAws[RichID.ID])
            {
                label1.Text = "Верно!";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Не верно!";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
