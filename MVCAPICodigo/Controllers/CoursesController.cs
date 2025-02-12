using Microsoft.AspNetCore.Mvc;
using MVCAPICodigo.Models;
using System.Text.Json;

namespace MVCAPICodigo.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Get()
        {
            HttpClient httpclient = new HttpClient();
            string url = "https://localhost:7116/api/Courses/Get";

            HttpResponseMessage response = await httpclient.GetAsync(url);
            List<CourseResponse> model = null;

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                //Convertir Json en lista de Objeto
                model = JsonSerializer.Deserialize<List<CourseResponse>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                model = new List<CourseResponse>();
            }
            return Json(model);
        }

    }

}
