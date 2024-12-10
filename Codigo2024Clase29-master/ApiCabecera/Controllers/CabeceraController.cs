using Entidad;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace ApiCabecera.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CabeceraController : ControllerBase
    {
        [HttpGet]
        public List<ECabecera> Listar()
        {
            ECabecera _eCabecera = new ECabecera();
            NCabecera nCabecera = new NCabecera();
            return nCabecera.Listar(_eCabecera);
        }

     
    }
}
