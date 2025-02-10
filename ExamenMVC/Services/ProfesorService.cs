using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class ProfesorService
    {
        public List<Profesor> Get()
        {
            using (var context = new SchoolContext())
            {
                return context.Profesores.Where(x=> x.Estado==true).ToList();
            }
        }

        public Profesor FindId (int _id)
        {
            using (var context = new SchoolContext())
            {
                return context.Profesores.Find(_id);
            }
        }
        public void Insert(Profesor _profesor)
        {
            using (var context = new SchoolContext())
            {
                _profesor.Estado = true;
                context.Profesores.Add(_profesor);
                context.SaveChanges();
            }
        }

        public void Update(Profesor _profesor)
        {
            using (var context = new SchoolContext())
            {
                var profesor = context.Profesores.Find(_profesor.Id);
                profesor.Nombre = _profesor.Nombre;
                profesor.Apellido = _profesor.Apellido;
                profesor.Correo = _profesor.Correo;
                profesor.Especialidad = _profesor.Especialidad;
                context.Entry(profesor).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int _Id)
        {
            using ( var context = new SchoolContext())
            {
                var profesor = context.Profesores.Find(_Id);
                profesor.Estado = false;
                context.Entry(profesor).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }

    
}
