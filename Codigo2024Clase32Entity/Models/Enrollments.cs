//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Codigo2024Clase32Entity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollments
    {
        public int EnrollmentID { get; set; }
        public System.DateTime Date { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public bool Enable { get; set; }
    
        public virtual Courses Courses { get; set; }
    }
}
