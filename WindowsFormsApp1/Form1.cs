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
    public partial class Form1 : Form
    {
        Help HelpForm = new Help();//Форма для вкладки "помощь" //кек, как же ему похер на названия
        Converter ConverterForm = new Converter();
        Reader ReaderForm = new Reader();
        (int,int) windowSize = (500, 500);//для размера окон

        public Form1()
        {
            InitializeComponent();
        }

        private void StripMenuHelp_Click(object sender, EventArgs e) //вроде сделана
        {
            HelpForm.Show();
        }

        private void StripMenuFormConverter_Click(object sender, EventArgs e)
        {
            ConverterForm.Size = new Size(windowSize.Item1, windowSize.Item2);
            this.Hide();
            ConverterForm.ShowDialog();
        }

        private void StripMenuFormFileReader_Click(object sender, EventArgs e)
        {
            ReaderForm.Size = new Size(windowSize.Item1, windowSize.Item2);
            this.Hide();
            ReaderForm.ShowDialog();
        }
    }
}
