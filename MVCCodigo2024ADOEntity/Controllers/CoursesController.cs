using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCodigo2024ADOEntity.Models;

namespace MVCCodigo2024ADOEntity.Controllers
{
    public class CoursesController : Controller
    {
        private DBClase34Entities2 db = new DBClase34Entities2();

        // GET: Courses
        public ActionResult Index()
        {
            return View(db.Courses.Where(x=> x.Enable == true).ToList());
        }

        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

        // GET: Courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseID,CourseName,Credit,Nuevo,Enable")] Courses courses)
        {
            if (ModelState.IsValid)
            {
                //Asegurar que el Enable sea True
                courses.Enable = true;
                db.Courses.Add(courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courses);
        }

        // GET: Courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

        // POST: Courses/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseID,CourseName,Credit,Nuevo,Enable")] Courses courses)
        {
            if (ModelState.IsValid)
            {
                //Obteniendo los datos del objeto de la vista para modificar los datos y enviar
                Courses courseUpdate = db.Courses.Find(courses.CourseID);
                courseUpdate.CourseName = courses.CourseName;
                courseUpdate.Credit = courses.Credit;
                courseUpdate.Nuevo = courses.Nuevo;

                db.Entry(courseUpdate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courses);
        }

        // GET: Courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Courses courses = db.Courses.Find(id);
            if (courses == null)
            {
                return HttpNotFound();
            }
            return View(courses);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Cambio del delete para hacer borrado logico
            Courses courses = db.Courses.Find(id);
            courses.Enable = false;
            db.Entry(courses).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
