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

//PhysicConverterPanel - панель, на которой происходит выбор хуйни для фищики
//ChemistryConverterPanel - панель, на которой происходит выбор хуйни для фищики

//PhysicReaderPanel - панель, на которой происходит выбор хуйни для фищики
//ChemistryReaderPanel - панель, на которой происходит выбор хуйни для фищики


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        HelpForm help = new HelpForm();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void MenuConverterPhysics_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;
        }

        private void MenuConverterChemistry_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;
        }

        private void MenuReaderPhysics_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;
        }

        private void MenuReaderChemistry_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;
        }

        private void StripMenuHelp_Click(object sender, EventArgs e)
        {
            help.Show();
        }


    }
}
