using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public string Mensaje()
        {
            return "Hola mundo!";
        }

        public string MensajeHTML()
        {
            return "<H1>Hola mundo!</H1>";
        }

    }
}