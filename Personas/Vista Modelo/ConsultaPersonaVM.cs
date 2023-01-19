using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajes;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista_Modelo
{
    class ConsultaPersonaVM : ObservableRecipient
    {
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

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }
        public ConsultaPersonaVM()
        {
            Persona persona = WeakReferenceMessenger.Default.Send<ConsultaMessage>();
            if(persona != null)
            {
                Nacionalidad = persona.Nacionalidad;
                Edad = persona.Edad.ToString();
                Nombre = persona.Nombre;
            }

        }
    }
}
