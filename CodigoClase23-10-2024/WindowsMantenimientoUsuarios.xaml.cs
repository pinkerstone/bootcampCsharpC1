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
    /// Lógica de interacción para WindowsMantenimientoUsuarios.xaml
    /// </summary>
    public partial class WindowsMantenimientoUsuarios : Window
    {
        List<Usuario> usuarios = new List<Usuario>();
        public WindowsMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            
            Usuario usuario = new Usuario();

            usuario.Apellidos = txtApellidos.Text;
            usuario.Nombres = txtNombres.Text;
            usuario.Correo = txtCorreo.Text;

            usuarios.Add(usuario);

            this.dgUsuariosRegistrados.ItemsSource = usuarios;
            this.dgUsuariosRegistrados.Items.Refresh();

            Limpiar();
        }

        private void Limpiar()
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtCorreo.Text = "";
        }
    }
}
