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
    public partial class ConverterForm_Physics_Temperature : Form
    {
        public ConverterForm_Physics_Temperature()
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
        double Check_Znach(ComboBox comboBox1, ComboBox comboBox2)
        {
            double multiplier = 0;
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    label1.Text = "Выберите единицы измерения для перевода";
                    break;
                case 0:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        multiplier = double.Parse(textBox1.Text);
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        multiplier = double.Parse(textBox1.Text) * 9 / 5 + 32;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        multiplier = double.Parse(textBox1.Text) + 273.15;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        multiplier = double.Parse(textBox1.Text) * 4 / 5;
                    }
                        break;
                case 1:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        multiplier = (double.Parse(textBox1.Text) - 32) * 5 / 9;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        multiplier = double.Parse(textBox1.Text);
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        multiplier = (double.Parse(textBox1.Text) + 459.67) * 5 / 9;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        multiplier = (double.Parse(textBox1.Text) - 32) * 4 / 9;
                    }
                    break;
                case 2:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        multiplier = double.Parse(textBox1.Text) - 273.15;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        multiplier = double.Parse(textBox1.Text) * 9 / 5 - 459.67;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        multiplier = double.Parse(textBox1.Text);
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        multiplier = (double.Parse(textBox1.Text) - 273.15) * 4 / 5;
                    }
                    break;
                case 3:
                    if (comboBox2.SelectedIndex == 0)
                    {
                        multiplier = double.Parse(textBox1.Text) * 4 / 5;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        multiplier = double.Parse(textBox1.Text) * 9 / 4 + 32;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        multiplier = double.Parse(textBox1.Text) * 5 / 4 + 273.15;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        multiplier = double.Parse(textBox1.Text);
                    }
                    break;
            }
            return multiplier;
        }
        void show_result()//считает результат и выводит в бокс
        {
            textBox2.Text = Convert.ToString(Check_Znach(comboBox1,comboBox2));
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
            show_result();
        }

        private void ConverterForm_Physics_Temperature_Leave(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
