using MVCCodigo2024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<Producto> productos = new List<Producto>();

            if (Session["Productos"] != null)
            {
                productos = (List<Producto>)Session["Productos"];
            }
            else
            {
                Session["Productos"] = productos;
            }
            //productos.Add(new Producto { Id = 1, Nombre = "Laptop", Precio = 1000 });
            //productos.Add(new Producto { Id = 1, Nombre = "Laptop", Precio = 1000 });
            //productos.Add(new Producto { Id = 1, Nombre = "Laptop", Precio = 1000 });

            return View(productos);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Producto producto = new Producto();

            return View(producto);
        }

        [HttpPost]
        public ActionResult Create(Producto _producto)
        {
            ((List<Producto>)Session["Productos"]).Add(_producto);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Producto producto = ((List<Producto>)Session["Productos"]).Where(x => x.Id == id).FirstOrDefault();

            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto _producto)
        {
            Producto productoModificar = ((List<Producto>)Session["Productos"]).Where(x=> x.Id == _producto.Id).FirstOrDefault();
            productoModificar.Nombre = _producto.Nombre;
            productoModificar.Precio = _producto.Precio;

            return RedirectToAction("Index");
        }


        public ActionResult Delete()
        {
            Producto producto = new Producto();

            return View(producto);
        }

        public ActionResult Details()
        {
            Producto producto = new Producto();

            return View(producto);
        }
    }
}