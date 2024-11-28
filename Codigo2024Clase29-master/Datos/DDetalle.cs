using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class DDetalle
    {
        public void Insertar(EDetalle entidad)
        {
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarDetalle", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdCabecera", entidad.IdCabecera);
                    command.Parameters.AddWithValue("@Producto", entidad.Producto);
                    command.Parameters.AddWithValue("@Cantidad", entidad.Cantidad);
                    command.Parameters.AddWithValue("@Precio", entidad.Precio);

                    command.ExecuteNonQuery();
                }

            }
        }

        public List<EDetalle> ListarDetalle(EDetalle entidad)
        {
            SqlCommand command = null;
            SqlParameter parameterIdCabecera = null;
            List<EDetalle> eDetalles = null;
            try
            {
                using(SqlConnection connection = new SqlConnection(Constantes._connectionString))
                {
                    connection.Open();
                    command = new SqlCommand("VerDetalleFactura", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    parameterIdCabecera = new SqlParameter("@IdCabecera", SqlDbType.Int);
                    parameterIdCabecera.Value = entidad.IdCabecera;
                    command.Parameters.Add(parameterIdCabecera);

                    eDetalles = new List<EDetalle>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        eDetalles.Add(new EDetalle()
                        {
                            IdDetalle = Convert.ToInt32(reader["IdDetalle"]),
                            Producto = Convert.ToString(reader["Producto"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            Precio = Convert.ToDecimal(reader["Precio"])
                        });
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                parameterIdCabecera = null;
            }

            return eDetalles;
        }
    }
}
