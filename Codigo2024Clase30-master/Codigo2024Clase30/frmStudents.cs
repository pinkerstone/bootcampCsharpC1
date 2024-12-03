using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo2024Clase30
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            BStudent student = new BStudent();
            students = student.Get(firstName, lastName);

            dgvStudents.DataSource = students;
            //Capa de negocio que lista los estudiantes
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
