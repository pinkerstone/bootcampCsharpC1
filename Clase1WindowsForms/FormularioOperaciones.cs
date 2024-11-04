using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1WindowsForms
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularReslt_Click(object sender, EventArgs e)
        {
            lvlResultado.Text = Convert.ToString(Convert.ToInt32(txtValor1.Text) + Convert.ToInt32(txtValor2.Text));
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            lvlResultado.Text = Convert.ToString(Convert.ToInt32(txtValor1.Text) - Convert.ToInt32(txtValor2.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lvlResultado.Text = Convert.ToString(Convert.ToInt32(txtValor1.Text) * Convert.ToInt32(txtValor2.Text));
        }

        private void btnCerrarPersona_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvlMenu_Click(object sender, EventArgs e)
        {
            new frmMenu().ShowDialog();
        }
    }
}
