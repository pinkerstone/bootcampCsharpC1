
using Negocio;
using Entidad;



void Grabar()
{

    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Juan Torrico",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 3000, Producto = "PC" });
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 2000, Producto = "TV" });
    eDetalles.Add(new EDetalle { Cantidad = 4, Precio = 1000, Producto = "Equipo" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        
    }
   




}

//Grabar();
//GrabarFerreteria();
//GrabarMercado();
GrabarComputo();
//Console.Read();

void GrabarFerreteria()
{
    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Luis Ulloa",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 120, Producto = "Pintura" });
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 40, Producto = "Brocha" });
    eDetalles.Add(new EDetalle { Cantidad = 4, Precio = 10, Producto = "Lija" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}

void GrabarMercado()
{
    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Luis Flores",
        Fecha = DateTime.Now
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 4, Precio = 5, Producto = "Pan" });
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 25, Producto = "Pollo" });
    eDetalles.Add(new EDetalle { Cantidad = 2, Precio = 3, Producto = "Tomate" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}

void GrabarComputo()
{
    NCabecera nCabecera = new NCabecera();

    ECabecera eCabecera = new ECabecera
    {
        Cliente = "Luis Flores",
        Fecha = DateTime.Now,
        Direccion = "Jorge Chavez Miraflores"
    };

    List<EDetalle> eDetalles = new List<EDetalle>();
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 3000, Producto = "Laptop Lenvo" });
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 100, Producto = "Mouse Lenovo" });
    eDetalles.Add(new EDetalle { Cantidad = 1, Precio = 200, Producto = "Teclado Lenovo" });

    try
    {
        nCabecera.Grabar(eCabecera, eDetalles);
        Console.WriteLine("Registro exitosamente");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());

    }
}