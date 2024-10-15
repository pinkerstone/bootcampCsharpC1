namespace CodigoClase18Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();

            for (int i = 0; i <= 20; i++)
            {
                productos.Add(new Producto
                { ProductoID = i, Nombre = "Nombre", Descripcion = "Descripción", Precio = 200});
            }
            dgvProductos.DataSource = productos;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
