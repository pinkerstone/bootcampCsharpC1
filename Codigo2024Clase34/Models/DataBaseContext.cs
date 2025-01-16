using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase34.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=LAPTOP-RMV50JMD\\SQLEXPRESS; " +
            //    "Database=DBClase34; Integrated Security=True;" +
            //   "Trust Server Certificate=True ");
            optionsBuilder.UseSqlServer("Server=LAPTOP-RMV50JMD\\SQLEXPRESS; " +
                "Database=DBClase34; User Id=userPrueba; Pwd=123456;" +
                "Trust Server Certificate=True ");
        }
    }
}
