using System;
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
        private string[] rightAws = new string[] { "Senjor Le Costylio", "5", "400", "41,87", "12","5120","" };

        public TaskForm()
        {
            InitializeComponent();
        }

        public void LetsChange()
        {
            label1.Visible = false;
            switch (RichID.ID)
            {
                case 1:
                    richTextBox1.Text = "Дано: Груз весит 5000кг.\nНайти: его вес выраженный в тоннах.";//p1
                    break;

                case 2:
                    richTextBox1.Text = "Дано: квадрат со стороной 2см.\nНайти: площадь квадрата выраженную в мм^2.\nФормулы: площадь квадрата = a * a, где а - сторона квадрата";//m1
                    break;

                case 3:
                    richTextBox1.Text = "Дано: 10 калорий.\nНайти: их эквивалент в джоулях.\n";//p2
                    break;

                case 4:
                    richTextBox1.Text = "Дано: Треугольник с стороной 40 см, и высотой к стороне в 60 см .\nНайти: площадь треугольника выраженную в дм^2 .\nФормулы: Площадь = (1/2)*ah, где а - сторона, h - высота";//m2
                    break;
                case 5:
                    richTextBox1.Text = "Дано: файл 5 мб.\nНайти: его вес выраженные в кб .\n";//m2
                    break;
                case 6:
                    richTextBox1.Text = "Дано:.\n .\n";//m2
                    break;
            }
        }

        private void AwsChk_Click(object sender, EventArgs e)
        {
            
            label1.Visible = true;

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
