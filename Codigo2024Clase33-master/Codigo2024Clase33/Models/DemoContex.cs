using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase33.Models
{
    public class DemoContex: DbContext
    {     
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        public DbSet<Detalle> Detalles { get; set; }

        public DbSet<Vendedor> Vendedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-RMV50JMD\\SQLEXPRESS; " +
                "Database=BDPruebas; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }
    }
}
