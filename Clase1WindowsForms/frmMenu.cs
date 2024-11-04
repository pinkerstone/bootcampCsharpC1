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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            frmOperaciones frmOperaciones = new frmOperaciones();
            frmOperaciones.Show();


        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            //frmPersonas frmPersonas = new frmPersonas();
            //frmPersonas.Show();
            new frmPersonas().ShowDialog();
        }
    }
}
