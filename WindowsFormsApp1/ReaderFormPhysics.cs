using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReaderFormPhysics : Form
    {
        public ReaderFormPhysics()
        {
            InitializeComponent();
        }

        private void RadioButtonPhysic_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("../../Resources/Physic.rtf");
        }

        private void RadioButtonChemistry_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("../../Resources/Chemistry.rtf");
        }
    }
}
