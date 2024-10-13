using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoClase17
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            frmOperaciones operaciones = new frmOperaciones();
            operaciones.ShowDialog();

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frmPersona frmPersona = new frmPersona();
            frmPersona.ShowDialog();

        }
    }
}
