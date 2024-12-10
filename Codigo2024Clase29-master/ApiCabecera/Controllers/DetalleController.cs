using Entidad;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace ApiCabecera.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {

        [HttpPost]
        public bool Insert(EDetalle _eDetalle)
        {
            try
            {
                NDetalle nDetalle = new NDetalle();
                nDetalle.Insertar(_eDetalle);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
