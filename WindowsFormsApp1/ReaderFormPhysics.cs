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

        private void radioButtonPhysicPressure_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            switch (radio.Text)
            {
                case "Скорость":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Speed.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Длина":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Length.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Время":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Time.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Ускорение":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Acceleration.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Искревление":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Curve.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Частота":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Frequency.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Масса":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Mass.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Сила":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Force.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Энергия":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Energy.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Мощность":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Power.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Давление":
                    try
                    {
                        richTextBox1.LoadFile("../../Resources/Pressure.rtf");
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            richTextBox1.ScrollToCaret();
            richTextBox1.Focus();
        }

        private void ReaderFormPhysics_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
