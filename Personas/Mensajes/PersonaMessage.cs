using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajes
{
    class PersonaMessage : ValueChangedMessage<Persona>
    {
        public PersonaMessage(Persona persona) : base(persona) { }
    }
}
