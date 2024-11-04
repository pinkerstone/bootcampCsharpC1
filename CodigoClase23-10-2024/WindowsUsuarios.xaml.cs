using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CodigoClase23_10_2024
{
    /// <summary>
    /// Lógica de interacción para WindowsUsuarios.xaml
    /// </summary>
    public partial class WindowsUsuarios : Window
    {
        public WindowsUsuarios()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario
            {
                Apellidos = "Ulloa Flores",
                Nombres = "Luis Gabriel",
                Correo = "luis.ulloa@delfosti.com"
            });
            usuarios.Add(new Usuario
            {
                Apellidos = "Ulloa Flores",
                Nombres = "Luis Gabriel",
                Correo = "luis.ulloa@delfosti.com"
            });
            usuarios.Add(new Usuario
            {
                Apellidos = "Ulloa Flores",
                Nombres = "Luis Gabriel",
                Correo = "luis.ulloa@delfosti.com"
            });

            this.dgUsuarios.ItemsSource = usuarios;
            
        }
    }
}
