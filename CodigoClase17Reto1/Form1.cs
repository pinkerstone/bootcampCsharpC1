using System.ComponentModel;

namespace CodigoClase17Reto1
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void btnMostarDatos_Click(object sender, EventArgs e)
        {

            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = personas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime fechaNacimiento = dpFechaNacimiento.Value;

            Persona nuevaPersona = new Persona
            {
                Nombres = nombres,
                Apellidos = apellidos,
                FechaNacimiento = fechaNacimiento,
                Direccion = "Dirección",
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = "Usuario Creador"
            };

            personas.Add(nuevaPersona);
            MessageBox.Show(Convert.ToString(personas.Count));

        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvPersonas.CurrentCell.RowIndex;
            MessageBox.Show(Convert.ToString(row));
            dgvPersonas.Rows.RemoveAt(row);
            MessageBox.Show(Convert.ToString(personas.Count));
        }
    }
}
