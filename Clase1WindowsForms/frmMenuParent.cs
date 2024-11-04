using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1WindowsForms
{
    public partial class frmMenuParent : Form
    {
        public frmMenuParent()
        {
            InitializeComponent();
        }

        private void frmMenuParent_Load(object sender, EventArgs e)
        {

        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperaciones frmOperaciones = new frmOperaciones();
            frmOperaciones.MdiParent = this;
            frmOperaciones.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonas.Instance.Show();
            frmPersonas.Instance.MdiParent = this;
            
            //frmPersonas frmPersonas = new frmPersonas();
            //frmPersonas.MdiParent = this;
            //frmPersonas.Show();
        }
    }
}
