using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {



           
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("about.rtf");
            }
            catch (FileNotFoundException ) {
                DialogResult = MessageBox.Show("Файл не найден","Ошибка" ,MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Close();  
            }

        }
    }
}
