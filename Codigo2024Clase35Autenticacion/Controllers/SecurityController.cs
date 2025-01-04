using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase35Autenticacion.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        [HttpGet]
        public string Login(string username,  string password)
        {

            return "";
        }
    }
}
