
using MVVM.Models;
using MVVM.Utilitarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class PersonasViewModel : ViewModelBase
    {
        #region Propiedades
        private string _nombres;
        public string Nombres
        {
            get { return _nombres; }
            set
            {
                _nombres = value;
                OnPropertyChanged(nameof(Nombres));
            }
        }

        private string _apellidos;
        public string Apellidos
        {
            get { return _apellidos; }
            set
            {
                _apellidos = value;
                OnPropertyChanged(nameof(Apellidos));
            }
        }

        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set
            {
                _edad = value;
                OnPropertyChanged(nameof(Edad));
            }
        }

        private string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set
            {
                _direccion = value;
                OnPropertyChanged(nameof(Direccion));
            }
        }

        private string _resultado;
        public string Resultado
        {
            get { return _resultado; }
            set
            {
                _resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        public ObservableCollection<PersonaModel> Personas { get; set; }

        public ICommand GuardarCommand { get; }
        #endregion

        #region Constructor
        public PersonasViewModel()
        {
            GuardarCommand = new RelayCommand(Guardar);
            Personas = new ObservableCollection<PersonaModel>();
        }
        #endregion

        #region Comandos
        private void Guardar()
        {
            Personas.Add(new PersonaModel
            {
                Apellidos = this.Apellidos,
                Nombres = this.Nombres,
                FechaCreacion = DateTime.Now,
                UsuarioCreacion = "Luis Ulloa"
            });

            //Resultado = string.Concat(Nombres, " ", Apellidos, " ", Direccion, " ",Edad);
        }
        #endregion


    }
}
