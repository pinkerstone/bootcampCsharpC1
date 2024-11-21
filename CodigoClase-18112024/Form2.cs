using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoClase_18112024
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection("data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; User id=userPrueba; Password=123456; TrustServerCertificate=true"))
                {

                    SqlCommand command = new SqlCommand("USP_BuscarClientesPorFiltros", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro1 = new SqlParameter("@NombreContacto", SqlDbType.VarChar, 50);
                    parametro1.Value = txtNombre.Text;

                    SqlParameter parametro2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    parametro2.Value = txtCargo.Text;

                    command.Parameters.Add(parametro1);
                    command.Parameters.Add(parametro2);

                    DataTable dataTable = new DataTable();


                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnBuscarSDT_Click(object sender, EventArgs e)
        {
            SqlCommand command = null; ;
            SqlParameter sqlParameter = null;
            SqlParameter sqlParameter2 = null;
            SqlParameter sqlParameter3 = null;
            List<Cliente> clientes = null;

            try
            {


                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarClientesPorFiltros", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    sqlParameter = new SqlParameter("@NombreContacto", SqlDbType.VarChar, 50);
                    sqlParameter.Value = txtNombre.Text;


                    sqlParameter2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    sqlParameter2.Value = txtCargo.Text;

                    sqlParameter3 = new SqlParameter("@Pais", SqlDbType.VarChar, 50);
                    sqlParameter3.Value = txtPais.Text;

                    command.Parameters.Add(sqlParameter);
                    command.Parameters.Add(sqlParameter2);
                    command.Parameters.Add(sqlParameter3);

                    //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    //dataAdapter.Fill(datatable);

                    clientes = new List<Cliente>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            IdCliente = Convert.ToString(reader["IdCliente"]),
                            NombreContacto = Convert.ToString(reader["NombreContacto"]),
                            CargoContacto = Convert.ToString(reader["CargoContacto"]),
                            Direccion = Convert.ToString(reader["Direccion"]),
                            Ciudad = Convert.ToString(reader["Ciudad"]),
                            Pais = Convert.ToString(reader["Pais"]),
                            CodigoPostal = Convert.ToString(reader["CodPostal"]),
                        }
                       );
                    }


                    dataGridView1.DataSource = clientes;

                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command = null;
                sqlParameter = null;
                sqlParameter2 = null;
                sqlParameter3 = null;
                clientes = null;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}