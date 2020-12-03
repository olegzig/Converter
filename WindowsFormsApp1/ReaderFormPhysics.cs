using System;
using System.Drawing;
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
            try
            {
                //richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                richTextBox1.LoadFile("../../Resources/Physic.rtf", RichTextBoxStreamType.RichText);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButtonChemistry_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("../../Resources/Chemistry.rtf");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenButtonRFPhysics_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an OpenFileDialog to request a file to open.
                OpenFileDialog openFile1 = new OpenFileDialog();

                // Initialize the OpenFileDialog to look for RTF files.
                openFile1.DefaultExt = "*.rtf";
                openFile1.Filter = "RTF Files|*.rtf";

                // Determine whether the user selected a file from the OpenFileDialog.
                if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                   openFile1.FileName.Length > 0)
                {
                    // Load the contents of the file into the RichTextBox.
                    richTextBox1.LoadFile(openFile1.FileName);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
