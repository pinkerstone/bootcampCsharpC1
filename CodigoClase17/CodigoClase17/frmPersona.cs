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
    public partial class frmPersona : Form
    {


        //public static frmPersona Instance { get; set; }



        private static frmPersona _instance;

        // Propiedad estática para obtener la única instancia
        public static frmPersona Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmPersona();
                }
                return _instance;
            }
        }
        public frmPersona()
        {
            InitializeComponent();            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
