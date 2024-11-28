using Datos;
using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo2024Clase29
{
    public partial class frmListadoFactura : Form
    {
        public frmListadoFactura()
        {
            InitializeComponent();
        }

        private void btnBuscarFacturas_Click(object sender, EventArgs e)
        {
            ECabecera cabecera = new ECabecera();
            cabecera.Cliente = txtNombreCliente.Text;
            NCabecera nCabecera = new NCabecera();
            List<ECabecera> eCabeceras = new List<ECabecera>();
            eCabeceras = nCabecera.Listar(cabecera);

            dgvFacturas.DataSource = eCabeceras;

        }

        private void frmListadoFactura_Load(object sender, EventArgs e)
        {
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.MultiSelect = false;
            dgvDetalle.AutoGenerateColumns = false;
        }


        private void dgvFacturas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvFacturas.SelectedRows[0];

                // Obtén el valor del ID (supongamos que está en la columna "ID")
                int idCabecera = Convert.ToInt32(filaSeleccionada.Cells["IdCabecera"].Value);

                EDetalle entidad = new EDetalle();
                entidad.IdCabecera = idCabecera;
                NDetalle nDetalle = new NDetalle();

                dgvDetalle.DataSource = nDetalle.Listar(entidad);


            }
        }
    }
}
