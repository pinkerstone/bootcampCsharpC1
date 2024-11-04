using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSIngleton1
{
    public partial class ListarProductos : Form
    {
        private static ListarProductos _instance;

        public static ListarProductos Instance
        {
            get
            {
                if( _instance == null || _instance.IsDisposed)
                {
                    _instance = new ListarProductos();
                }

                return _instance;
            }
        }
        public ListarProductos()
        {
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
