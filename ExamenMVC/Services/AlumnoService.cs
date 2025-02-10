using Domain;
using Infraestructure;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class AlumnoService
    {
        public List<Alumno> Get()
        {
            using (var context = new SchoolContext())
            {
                return context.Alumnos.Where(x=> x.Estado == true).ToList();
            }
        }

        public Alumno FindId(int _Id)
        {
            using (var context = new SchoolContext())
            {
                return context.Alumnos.Find(_Id);
            }
        }
        public void Insert(Alumno _alumno)
        {
            using (var context = new SchoolContext())
            {
                _alumno.Estado = true;
                context.Alumnos.Add(_alumno);
                context.SaveChanges();
            }
        }

        public void Update(Alumno _alumno)
        {
            using (var context = new SchoolContext())
            {
                var alumno = context.Alumnos.Find(_alumno.Id);
                alumno.Nombre = _alumno.Nombre;
                alumno.Apellido = _alumno.Apellido;
                alumno.Correo = _alumno.Correo;
                alumno.FechaNacimiento = _alumno.FechaNacimiento;
                context.Entry(alumno).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete (int _Id)
        {
            using (var context = new SchoolContext())
            {
                var alumno = context.Alumnos.Find(_Id);
                alumno.Estado = false;
                context.Entry(alumno).State = EntityState.Modified;
                context.SaveChanges();
            }
        }


    }
}
