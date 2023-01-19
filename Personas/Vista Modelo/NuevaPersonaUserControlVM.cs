using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajes;
using Personas.Modelo;
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
        public RelayCommand AddPersonaCommand { get; }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private String edad;

        public String Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private String nacionalidadSeleccionada;

        public String NacionalidadSeleccionada
        {
            get { return nacionalidadSeleccionada; }
            set { SetProperty(ref nacionalidadSeleccionada, value); }
        }

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
            AddPersonaCommand = new RelayCommand(AddPersona);
            Nacionalidades = new ObservableCollection<string>();
            Nacionalidades.Add("Español");
            Nacionalidades.Add("Rumano");
            Nacionalidades.Add("Americano");

            string nacionalidadNueva = "";

            WeakReferenceMessenger.Default.Register<NacionalidadMessage>(
                this, (r, m) =>
                {
                    nacionalidadNueva = m.Value;
                    Nacionalidades.Add(nacionalidadNueva);
                }
                );

        }
        public void AddPersona()
        {
            WeakReferenceMessenger.Default.Send(new PersonaMessage(new Persona(Int32.Parse(Edad),Nombre,nacionalidadSeleccionada)));
        }
        public void CargarDialogo()
        {
            servicioNavegacion.AbrirDialogo();
        }
    }
}
