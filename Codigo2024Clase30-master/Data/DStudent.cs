using Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Data;

namespace Data
{
    public class DStudent
    {
       public List<Student> Get(string name, string lastname)
        {
            SqlCommand command = null;
            SqlParameter parameterFirstName = null;
            SqlParameter parameterLastName = null;
            List<Student> students = null;
            
            try
            {
                using(SqlConnection connection = new SqlConnection(Constantes._conecctionString))
                {
                    connection.Open();
                    command = new SqlCommand("StudentList", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    parameterFirstName = new SqlParameter("@FirstName", SqlDbType.NVarChar, 100);
                    parameterLastName = new SqlParameter("@LastName", SqlDbType.NVarChar, 100);
                    parameterFirstName.Value = name;
                    parameterLastName.Value = lastname;
                    
                    command.Parameters.Add(parameterFirstName);
                    command.Parameters.Add(parameterLastName);

                    students = new List<Student>();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        students.Add(new Student()
                        {
                            StudentID = Convert.ToInt32(reader["StudentId"]),
                            FirstName = Convert.ToString(reader["FirstName"]),
                            LastName = Convert.ToString(reader["LastName"]),
                            IsActive = Convert.ToBoolean(reader["IsActive"])
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
                parameterFirstName = null;
                parameterLastName = null;
            }

            return students;
        }
    }
}
