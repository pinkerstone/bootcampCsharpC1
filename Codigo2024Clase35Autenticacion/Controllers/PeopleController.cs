using Codigo2024Clase35Autenticacion.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Codigo2024Clase35Autenticacion.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        [Authorize]
        [HttpGet]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });
            return response;
        }
        
        [HttpGet]
        public IEnumerable<PersonResponse> Get2()
        {
            List<PersonResponse> response = new List<PersonResponse>();
            response.Add(new PersonResponse { FirstName = "Hugo", LastName = "Torrico" });
            response.Add(new PersonResponse { FirstName = "Juan", LastName = "Torrico" });

            return response;
        }
    }
}
