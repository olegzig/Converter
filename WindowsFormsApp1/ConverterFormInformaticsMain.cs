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
    public partial class ConverterFormInformaticsMain : Form
    {
        public ConverterFormInformaticsMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConverterFormInformaticMass CFIMass = new ConverterFormInformaticMass();
            CFIMass.MdiParent = this.MdiParent;
            CFIMass.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConverterFormInformaitcsMath CFIMath = new ConverterFormInformaitcsMath();
            CFIMath.MdiParent = this.MdiParent;
            CFIMath.Show();
        }

        private void ConverterFormInformaticsMain_Leave(object sender, EventArgs e)
        {
            //мб тут  клоуз прописать
        }
    }
}
