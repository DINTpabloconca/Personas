using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista_Modelo
{
    class NuevaPersonaUserControlVM : ObservableObject
    {
        public RelayCommand DialogCommand { get; }
        private ServicioNavegacion servicioNavegacion;
        private ObservableCollection<String> nacionalidades;

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }
        public NuevaPersonaUserControlVM()
        {
            servicioNavegacion = new ServicioNavegacion();
            DialogCommand = new RelayCommand(CargarDialogo);
            Nacionalidades = new ObservableCollection<string>();
            Nacionalidades.Add("Español");
            Nacionalidades.Add("Rumano");
            Nacionalidades.Add("Americano");
        }
        public void CargarDialogo()
        {
            servicioNavegacion.AbrirDialogo();
        }
    }
}
