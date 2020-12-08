﻿using System;
using System.Numerics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ConverterFormInformaticMass : Form
    {
        public ConverterFormInformaticMass()
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
        BigInteger Check_Znach(ComboBox comboBox)
        {
            BigInteger multiplier = new BigInteger();
            
            multiplier = 0;
            switch (comboBox.Text)
            {
                default:
                    label1.Text = "Выберите единицы измерения для перевода";
                    break;
                case "Байт":
                    multiplier = 1;
                    break;
                case "Килобайт":
                    multiplier = 1024;
                    break;
                case "Мегабайт":
                    multiplier = 1048676;
                    break;
                case "Гигабайт":
                    multiplier = 1073741824;
                    break;
                case "Терабайт":
                    multiplier = 1099511627776;
                    break;
                case "Петабайт":
                    multiplier = 1125899906842624;
                    break;
                case "Экзабайт":
                    multiplier = 1152921504606846976;
                    break;
                case "Зетабайт":
                    multiplier = BigInteger.Parse("1180591620717411303424");
                    break;
                case "Йотабайт":
                    multiplier = BigInteger.Parse("1208925819614629174706176");
                    break;
            }
            return multiplier;
        }
        void show_result()//считает результат и выводит в бокс
        {
            //textBox2.Text = Convert.ToString(Check_Znach(comboBox1) * BigInteger.Parse(textBox1.Text) / Check_Znach(comboBox2));
            try
            {
                textBox2.Text = String.Format("{0:E}", BigInteger.Divide(BigInteger.Multiply(Check_Znach(comboBox1), BigInteger.Parse(textBox1.Text)), Check_Znach(comboBox2)));
                if (textBox2.Text == "0,000000E+000") textBox2.Text = "Не переводится";
            }
            catch (DivideByZeroException)
            {
                textBox2.Text = "0,000000E+000";
            }
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