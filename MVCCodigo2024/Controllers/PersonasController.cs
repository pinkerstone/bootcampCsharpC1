using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona { ID = 1, Nombres = "Luis", Apellidos = "Ulloa" });
            personas.Add(new Persona { ID = 1, Nombres = "Luis", Apellidos = "Ulloa" });
            personas.Add(new Persona { ID = 1, Nombres = "Luis", Apellidos = "Ulloa" });

            return View(personas);
        }

        public ActionResult Create()
        {
            Persona persona = new Persona();
            
            return View(persona);
        }
    }
}