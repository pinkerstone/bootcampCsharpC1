namespace Codigo2024Clase33.Models
{
    public class Detalle
    {

        public int DetalleId { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad {  get; set; }

        public int ProductoID { get; set; }
        public Producto Producto { get; set; }

        public int? FacturaID { get; set; }
        public Factura? Factura { get; set; }

    }
}
