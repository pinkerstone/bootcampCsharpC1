using Negocio;
using Entidad;

namespace Codigo2024Clase29
{
    public partial class Form1 : Form
    {

        List<EDetalle> eDetalles = new List<EDetalle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalle();

        }
        /// <summary>
        /// Agregar elementos al DataGridView
        /// </summary>
        void AgregarDetalle()
        {
            eDetalles.Add(new EDetalle
            {
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Producto = txtProducto.Text
            });
            dgvDetalle.DataSource = null;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            dgvDetalle.DataSource = eDetalles;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            NCabecera nCabecera = new NCabecera();
            ECabecera eCabecera = new ECabecera
            {
                Cliente = txtCliente.Text,
                Fecha = dtpFecha.Value,
                Direccion = ""
            };

            try
            {
                nCabecera.Grabar(eCabecera, eDetalles);
                eDetalles.Clear();
                dgvDetalle.DataSource = null;
                txtCliente.Text = "";
                dtpFecha.Value = DateTime.Today;
                MessageBox.Show("Registro exitoso");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDetalle.AutoGenerateColumns = false;
        }
    }
}
