using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FrmEmpleado frm= new FrmEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmMedicamentos frm = new FrmMedicamentos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
