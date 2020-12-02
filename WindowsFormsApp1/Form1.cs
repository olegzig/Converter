using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DefaultImage - картинка которая ебашится на старте

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        HelpForm help = new HelpForm();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void StripMenuHelp_Click(object sender, EventArgs e)
        {
            help.Show();
        }

    }
}
