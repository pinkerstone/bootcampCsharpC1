﻿using Entidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCabecera
    {

        public int Insertar(ECabecera entidad)
        {
            //USP_InsertarCabecera(fecha, cliente)
            using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("InsertarCabecera", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Fecha", entidad.Fecha);
                    command.Parameters.AddWithValue("@Cliente", entidad.Cliente);
                    command.Parameters.AddWithValue("@Direccion", entidad.Direccion);


                    SqlParameter idOutput = new SqlParameter("@IdCabecera", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(idOutput);
                    command.ExecuteNonQuery();

                    //(int)idOutput.Value: Retorna el valor del parámetro de salida

                    return (int)idOutput.Value;
                }
            }



        }

    

        public List<ECabecera> Listar(ECabecera cabecera)
        {
            SqlCommand command = null;
            List<ECabecera> cabeceras = null;
            SqlParameter parametroCliente = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(Constantes._connectionString))
                {
                    connection.Open();
                    command = new SqlCommand("ListarFacturasCliente", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    parametroCliente = new SqlParameter("@NombreCliente", SqlDbType.VarChar, 100);
                    parametroCliente.Value = cabecera.Cliente;
                    command.Parameters.Add(parametroCliente);

                    cabeceras = new List<ECabecera>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cabeceras.Add(new ECabecera()
                        {
                            IdCabecera = Convert.ToInt32(reader["IdCabecera"]),
                            Cliente = Convert.ToString(reader["Cliente"]),
                            Direccion = Convert.ToString(reader["Direccion"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"])
                        });
                    }

                    return cabeceras;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command = null;
                parametroCliente = null;

            }


        }
    }
}
