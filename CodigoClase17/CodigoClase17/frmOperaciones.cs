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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Convert.ToString(Convert.ToInt32(txtValor1.Text) +
                Convert.ToInt32(txtValor2.Text));
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            lblResta.Text = Convert.ToString(Convert.ToInt32(txtValor3.Text) -
                Convert.ToInt32(txtValor4.Text));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario actual
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
