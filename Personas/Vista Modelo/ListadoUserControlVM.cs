using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Mensajes;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista_Modelo
{
    class ListadoUserControlVM : ObservableObject
    {
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

  
        public ListadoUserControlVM()
        {
            Personas = new ObservableCollection<Persona>();
            Personas.Add(new Persona(16, "Pablo", "Rumano"));
            Personas.Add(new Persona(18, "Jacinto", "Español"));
            Personas.Add(new Persona(20, "Evaristo", "Español"));
            WeakReferenceMessenger.Default.Register<PersonaMessage>(
                this, (r, m) =>
                {
                    Personas.Add(m.Value);
                }
                );
            WeakReferenceMessenger.Default.Register<ListadoUserControlVM,ConsultaMessage>(
                 this, (r, m) =>
                {
                    m.Reply(r.PersonaSeleccionada);
                }
                );
        }
    }
}
