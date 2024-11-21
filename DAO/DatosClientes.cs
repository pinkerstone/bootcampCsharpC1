using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatosClientes
    {
        public static List<Cliente> ListarClientes (string nombre, string cargo, string pais)
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
                    sqlParameter.Value = nombre;


                    sqlParameter2 = new SqlParameter("@CargoContacto", SqlDbType.VarChar, 50);
                    sqlParameter2.Value = cargo;

                    sqlParameter3 = new SqlParameter("@Pais", SqlDbType.VarChar, 50);
                    sqlParameter3.Value = pais;

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


                    return clientes;

                }
            }
            catch (Exception ex)
            {
                throw ex;
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

    }
}
