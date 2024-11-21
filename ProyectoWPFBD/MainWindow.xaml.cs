using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAO;

namespace ProyectoWPFBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand command = null; ;
            SqlParameter sqlParameter = null;
            List<Categoria> categorias = null;

            try
            {


                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarCategoria", conexion);
                    command.CommandType = CommandType.StoredProcedure;


                    sqlParameter = new SqlParameter("@NombreCategoria", SqlDbType.VarChar, 50);
                    sqlParameter.Value = txtNombre.Text;

                    command.Parameters.Add(sqlParameter);

                    categorias = new List<Categoria>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            IdCategoria = Convert.ToString(reader["idcategoria"]),
                            NombreCategoria = Convert.ToString(reader["nombrecategoria"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),
                            Activo = reader["Activo"] == DBNull.Value ? false : Convert.ToBoolean(reader["Activo"]),
                            CodCategoria = Convert.ToString(reader["CodCategoria"]),
                        }
                       );
                    }

                    dgCategorias.ItemsSource = categorias;

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
                categorias = null;
            }


        }

        private void btnBuscarClientes_Click(object sender, RoutedEventArgs e)
        {
        }
    }
    
}