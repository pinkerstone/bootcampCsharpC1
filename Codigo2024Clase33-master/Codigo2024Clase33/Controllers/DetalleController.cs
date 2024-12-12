using Codigo2024Clase33.Models;
using Codigo2024Clase33.Requests;
using Codigo2024Clase33.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase33.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {

        //private readonly DemoContex _context;

        //public DetalleController(DemoContex context)
        //{
        //    _context = context;
        //}

        [HttpPost]
        public ResponseBase Insertar(DetalleRequest1 request)
        {
            ResponseBase response = new ResponseBase();
            using (var _context = new DemoContex())
            {
                 try
                {
                    Detalle detalle = new Detalle{
                        ProductoID = request.ProductoID,
                        PrecioVenta = request.PrecioVenta,
                        Cantidad = request.Cantidad,
                    };


                    _context.Detalles.Add(detalle);
                    _context.SaveChanges();
                    response.CodigoError = 0;
                    response.Mensaje = "Registro exitoso";

                }
                catch (Exception ex)
                {
                    response.CodigoError = -100;
                    response.Mensaje = ex.ToString();
                }
                return response;
            }
           

        }

        [HttpGet]
        public List<Detalle> GetDetallesRangoPrecio(decimal p1, decimal p2)
        {
            using (var _context = new DemoContex())
            {
                var query = _context.Detalles.Where(x => x.PrecioVenta >= p1 && x.PrecioVenta <= p2).ToList();
                return query;
            }
                
        }

        [HttpGet]
        public List<Detalle> GetDetalleSubTotalMayor(decimal subTotal)
        {
            using (var _context = new DemoContex())
            {
                var query = _context.Detalles.Where(x => x.Cantidad * x.PrecioVenta >= subTotal).ToList();
                return query;
            }

                
        }
    }       
}
