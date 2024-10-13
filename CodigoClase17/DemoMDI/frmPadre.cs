using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMDI
{
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void primeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hijo = new Form1();  // Instancia del formulario hijo
            hijo.MdiParent = this;     // Establece el MDI Parent
            hijo.Show();               // Muestra 
        }
    }
}
