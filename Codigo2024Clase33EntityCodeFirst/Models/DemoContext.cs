using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33EntityCodeFirst.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-RMV50JMD\\SQLEXPRESS; " +
                "Database=BDClase2024; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }
    }
    
}
