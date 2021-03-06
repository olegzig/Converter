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
    public partial class ConverterForm_Physics_Volume : Form
    {
        public ConverterForm_Physics_Volume()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        double Check_Znach(ComboBox comboBox)
        {
            double multiplier = 0;
            switch (comboBox.SelectedIndex)
            {
                case -1:
                    //label1.Text = "Выберите единицы измерения для перевода";
                    break;
                case 0:
                    multiplier = 1000000;
                    break;
                case 1:
                    multiplier = 158987.29;
                    break;
                case 2:
                    multiplier = 4546.09;
                    break;
                case 3:
                    multiplier = 1000;
                    break;
                case 4:
                    multiplier = 473.18;
                    break;
                case 5:
                    multiplier = 1;
                    break;
            }
            return multiplier;
        }
        void show_result()//считает результат и выводит в бокс
        {
            textBox2.Text = Convert.ToString(Check_Znach(comboBox1) * double.Parse(textBox1.Text) / Check_Znach(comboBox2));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                show_result();
            }
        }

        private void button2_Click(object sender, EventArgs e)//меняет местами расчеты
        {
            int buf;
            buf = comboBox1.SelectedIndex;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = buf;
            if (textBox1.Text != "")
            {
                show_result();
            }
        }

        private void ConverterForm_Physics_Volume_Leave(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
