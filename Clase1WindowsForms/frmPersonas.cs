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
    public partial class frmPersonas : Form
    {
        private static frmPersonas _instance;

        public static frmPersonas Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new frmPersonas();
                }
                return _instance;
            }
        }
        
        public frmPersonas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPersonas_Load(object sender, EventArgs e)
        {

        }

        //public string CalculoMayoriaEdad(DateTime fechNacimiento)
        //{
        //    string mayor;
        //    if (DateTime.Now - fechNacimiento >= 18)
        //    {
        //        mayor = "Sí";
        //    }
        //    else
        //    {
        //        mayor = "No";
        //    }
        //    return mayor;
        //}

        public double CalculoRenta(int sueldo)
        {
            double impuesto = 0;
            if (sueldo < 1500)
            {
                impuesto = 0;
            }
            else
            {
                impuesto = sueldo * 0.08;
            }
            return impuesto;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento;
            int sueldo = 0;

            fechaNacimiento = dtpFechaNacimiento.Value;
            sueldo = Convert.ToInt32(txtSueldo.Text);

            //lvlMayorEdadRslt.Text = CalculoMayoriaEdad(fechaNacimiento);

            lvlImpuestoRslt.Text = Convert.ToString(CalculoRenta(sueldo));



        }

        private void gpbResultados_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarPersonas_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Close();
        }
    }
}

