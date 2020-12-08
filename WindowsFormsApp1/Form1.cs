using System;
using System.Windows.Forms;
//DefaultImage - картинка которая ебашится на старте

//ConverterForm_Physics.cs - форма для конвертера физики (я не буду писать мне елнь. Они все подобно называются)
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuConverterPhysics_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;

            ConverterForm_Physics CFPhysics = new ConverterForm_Physics();
            CFPhysics.MdiParent = this;

            CFPhysics.Show();
        }

        private void MenuConverterChemistry_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;

            ConverterFormChemistry CFChemistry = new ConverterFormChemistry();
            CFChemistry.MdiParent = this;

            CFChemistry.Show();
        }

        private void MenuReaderPhysics_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;

            ReaderFormPhysics RFPhysics = new ReaderFormPhysics();
            RFPhysics.MdiParent = this;

            RFPhysics.Show();
        }

        private void MenuReaderChemistry_Click(object sender, EventArgs e)
        {
            DefaultImage.Visible = false;

            ReaderFormInformaic RFCemistry = new ReaderFormInformaic();
            RFCemistry.MdiParent = this;

            RFCemistry.Show();
        }

        private void StripMenuHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }


    }
}
