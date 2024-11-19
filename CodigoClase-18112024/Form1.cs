using Microsoft.Data.SqlClient;
using System.Data;

namespace CodigoClase_18112024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            try
            {
                //Objeto para establecer la conexión
                SqlConnection conexion = new SqlConnection("data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; Integrated Security=true; TrustServerCertificate=true");

                conexion.Open();

                //Objeto de la petición
                SqlCommand command = new SqlCommand("SELECT * FROM productos", conexion);

                //Objeto para recibir la información
                DataTable dataTable = new DataTable();

                //Objeto que envía y recibe la consulta
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                //Función para colocar la data en el objeto tabla
                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvData.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListarAuth_Click(object sender, EventArgs e)
        {
            //Objeto para establecer la conexión
            SqlConnection conexion = new SqlConnection("data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; User id=userPrueba; Password=123456; TrustServerCertificate=true");

            try
            {


                conexion.Open();

                //Objeto de la petición
                SqlCommand command = new SqlCommand("SELECT * FROM productos", conexion);

                //Objeto para recibir la información
                DataTable dataTable = new DataTable();

                //Objeto que envía y recibe la consulta
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                //Función para colocar la data en el objeto tabla
                dataAdapter.Fill(dataTable);

                conexion.Close();

                dgvData.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnUsing_Click(object sender, EventArgs e)
        {

            try
            {

                //el using controla a apertura y cierre de la conexión
                using (SqlConnection conexion = new SqlConnection("data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; User id=userPrueba; Password=123456; TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM productos", conexion);


                    DataTable dataTable = new DataTable();


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    dataAdapter.Fill(dataTable);

                    dgvData.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection("data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; User id=userPrueba; Password=123456; TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("ListarPedidosEnvios", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable();


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    dataAdapter.Fill(dataTable);

                    dgvPedidos.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnListarPedidosObj_Click(object sender, EventArgs e)
        {
            string procedimiento = "ListarPedidosEnvios";
            BaseConexionSQL tabla = new BaseConexionSQL(procedimiento);

            dgvPedidos.DataSource = tabla.DataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
