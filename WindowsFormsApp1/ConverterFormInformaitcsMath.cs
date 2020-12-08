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
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44&&(number >= 'a' || number<='f')) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
        void show_result()//считает результат и выводит в бокс
        {

            try
            {
                switch (comboBox2.Text)
                {
                    default:
                        label1.Text = "Выберите единицы измерения для перевода";
                        break;
                    case "Десятиричная":
                        switch (comboBox1.Text)
                        {
                            default:
                                label1.Text = "Выберите единицы измерения для перевода";
                                break;
                            case "Десятиричная": //10 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 10));
                                break;
                            case "Двоичная": // 2 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 2));
                                break;
                            case "Восьмеричная"://8 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 8));
                                break;
                            case "Шестнадцатеричная"://16 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 16));
                                break;
                        }
                        break;
                    case "Двоичная":
                        switch (comboBox1.Text)
                        {
                            default:
                                label1.Text = "Выберите единицы измерения для перевода";
                                break;
                            case "Десятиричная": //10 to 2
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 10), 2);
                                break;
                            case "Двоичная": // 2 to 2
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 2), 2);
                                break;
                            case "Восьмеричная"://8 to 2
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 8), 2);
                                break;
                            case "Шестнадцатеричная"://16 to 2
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 16), 2);
                                break;
                        }
                        break;
                    case "Восьмеричная":
                        switch (comboBox1.Text)
                        {
                            default:
                                label1.Text = "Выберите единицы измерения для перевода";
                                break;
                            case "Десятиричная": //10 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 10), 8);
                                break;
                            case "Двоичная": // 2 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 2), 8);
                                break;
                            case "Восьмеричная"://8 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 8), 8);
                                break;
                            case "Шестнадцатеричная"://16 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 16), 8);
                                break;
                        }
                        break;
                    case "Шестнадцатеричная":
                        switch (comboBox1.Text)
                        {
                            default:
                                label1.Text = "Выберите единицы измерения для перевода";
                                break;
                            case "Десятиричная": //10 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 10), 16);
                                break;
                            case "Двоичная": // 2 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 2), 16);
                                break;
                            case "Восьмеричная"://8 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 8), 16);
                                break;
                            case "Шестнадцатеричная"://16 to 10
                                textBox2.Text = Convert.ToString(Convert.ToInt64(textBox1.Text, 16), 16);
                                break;
                        }
                        break;
                }
            }
            catch (OverflowException) {
                textBox2.Text = "слишком большое для перевода";
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
