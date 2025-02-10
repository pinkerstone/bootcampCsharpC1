using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class SchoolContext : DbContext
    {

        public DbSet<Alumno> Alumnos { get; set; }  
        public DbSet<Profesor> Profesores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-RMV50JMD\\SQLEXPRESS; " + "Database=DBExamenMVC; Integrated Security=True;" + "Trust Server Certificate=True ");
        }
    }
}
