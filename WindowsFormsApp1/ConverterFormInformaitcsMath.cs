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
    public partial class ConverterFormInformaitcsMath : Form
    {
        public ConverterFormInformaitcsMath()
        {
            InitializeComponent();
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
                    label1.Text = "Выберите единицы измерения для перевода";
                    break;
                case 0:
                    multiplier = 1;
                    break;
                case 1:
                    multiplier = 10;
                    break;
                case 2:
                    multiplier = 25.4;
                    break;
                case 3:
                    multiplier = 100;
                    break;
                case 4:
                    multiplier = 304.8;
                    break;
                case 5:
                    multiplier = 914.4;
                    break;
                case 6:
                    multiplier = 1000;
                    break;
                case 7:
                    multiplier = 1000000;
                    break;
                case 8:
                    multiplier = 1609344;
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
            show_result();
        }
    }
}
