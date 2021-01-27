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
    public partial class TaskMain : Form
    {
        public TaskMain()
        {
            InitializeComponent();
        }

        private void PhyisicT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks.PhyisicT1 form = new Tasks.PhyisicT1();
            form.MdiParent = this;

            form.Show();
        }

        private void MathT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks.MathT1 form = new Tasks.MathT1();
            form.MdiParent = this;

            form.Show();
        }

        private void PhyisicT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks.PhyisicT2 form = new Tasks.PhyisicT2();
            form.MdiParent = this;

            form.Show();
        }

        private void MathT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tasks.MathT2 form = new Tasks.MathT2();
            form.MdiParent = this;

            form.Show();
        }
    }
}
