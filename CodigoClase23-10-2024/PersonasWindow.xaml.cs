using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para PersonasWindow.xaml
    /// </summary>
    public partial class PersonasWindow : Window
    {
        ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        public PersonasWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            personas.Add(new Persona
            {
                Apellidos = "Ulloa Flores",
                Nombres = "Luis Gabriel",
                Edad = 36
            });
            personas.Add(new Persona
            {
                Apellidos = "Marquez",
                Nombres = "Fernando",
                Edad = 38
            });
            personas.Add(new Persona
            {
                Apellidos = "Arevalo Calonge",
                Nombres = "Luis Eduardo",
                Edad = 32
            });

            lvPersonas.ItemsSource = personas;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            personas.Add(new Persona
            {
                Apellidos = txtApellidos.Text,
                Nombres = txtNombres.Text,
                Edad = Convert.ToInt32(txtEdad.Text)
            });

            lvPersonas.ItemsSource= personas;
            lvPersonas.Items.Refresh();
        }
    }
}
