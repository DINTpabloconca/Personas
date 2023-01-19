using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Personas.Mensajes
{
    class NacionalidadMessage: ValueChangedMessage<string>
    {
        public NacionalidadMessage(string texto) : base(texto)
        {

        }
    }
}
