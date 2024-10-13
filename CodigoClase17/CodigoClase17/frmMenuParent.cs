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
    public partial class frmMenuParent : Form
    {
        public frmMenuParent()
        {
            InitializeComponent();
        }

        private void irAOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmOperaciones)
                {
                    form.BringToFront();
                    return; // Salir de la función si ya está abierto
                }
            }


            frmOperaciones frmOperaciones = new frmOperaciones();
            frmOperaciones.MdiParent = this;
            frmOperaciones.Show();
        }

        private void irAPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //frmPersona.Instance.Show();// Crea la instancia?  SI
            //frmPersona.Instance.Show();// Crea la instancia?  NO
            //frmPersona.Instance.Show();// Crea la instancia?  NO



            frmPersona.Instance.MdiParent = this;
            frmPersona.Instance.Show();
            



            //frmPersona frmPersona = new frmPersona();
            //frmPersona.MdiParent = this;
            //frmPersona.Show();
        }
    }
}
