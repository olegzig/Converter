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
        bool formNotInv = true;

        Tasks.TaskForm form = new Tasks.TaskForm();

        public void IfInvoke()
        {
            if (formNotInv)
            {
                form.MdiParent = this;
                form.Show();
                pictureBox1.Hide();
                formNotInv = false;
                
            }
        }

        public TaskMain()
        {
            InitializeComponent();
        }

        private void PhyisicT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 1;
            form.LetsChange();
        }

        private void MathT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 2;
            form.LetsChange();
        }

        private void PhyisicT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 3;
            form.LetsChange();
        }

        private void MathT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 4;
            form.LetsChange();
        }

        private void inform1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 5;
            form.LetsChange();
        }

        private void inform2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IfInvoke();
            RichID.ID = 6;
            form.LetsChange();
        }
    }
}
