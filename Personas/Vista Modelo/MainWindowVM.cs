using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.Vista_Modelo
{
    class MainWindowVM : ObservableObject
    {
        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }
        public RelayCommand NuevaPersonaCommand { get; }
        public RelayCommand ListadoPersonasCommand { get; }
        public RelayCommand ConsultaPersonasCommand { get; }


        private ServicioNavegacion servicioNavegacion;

        public MainWindowVM()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Properties.Settings.Default.clave);
            servicioNavegacion = new ServicioNavegacion();
            NuevaPersonaCommand = new RelayCommand(CargarNuevaPersona);
            ListadoPersonasCommand = new RelayCommand(CargarListadoPersonas);
            ConsultaPersonasCommand = new RelayCommand(CargarConsultaPersonas);
        }
        public void CargarNuevaPersona()
        {
            ContenidoVentana = servicioNavegacion.ObtenerNuevoUsuario();
        }
        public void CargarListadoPersonas()
        {
            ContenidoVentana = servicioNavegacion.ObtenerListadoUsuarios();
        }
        public void CargarConsultaPersonas()
        {
            ContenidoVentana = servicioNavegacion.ObtenerConsultaPersonas();
        }
    }
}
