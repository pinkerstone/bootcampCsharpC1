using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSIngleton1
{
    public partial class ListarPersonas : Form
    {
        private static ListarPersonas _instance;

        public static ListarPersonas Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ListarPersonas();  
                }
                
                return _instance;
                
            }
        }
        public ListarPersonas()
        {
            InitializeComponent();
        }

        private void ListarPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
