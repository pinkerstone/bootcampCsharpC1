using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase_18112024
{
    public class BaseConexionSQL
    {
        private static string CadenaConexion = "data source=LAPTOP-RMV50JMD\\SQLEXPRESS; Initial catalog= Neptuno; User id=userPrueba; Password=123456; TrustServerCertificate=true";

        public DataTable DataTable { get; set; }
        
        public BaseConexionSQL(string storeProc)
        {
            
            SqlConnection connection = new SqlConnection(CadenaConexion);
            SqlCommand command = new SqlCommand(storeProc, connection);
            command.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            this.DataTable = dataTable;

        }



    }
}
