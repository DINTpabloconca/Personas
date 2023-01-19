using Personas.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class ServicioNavegacion
    {
        ListadoUserControl listado;
        public ServicioNavegacion()
        {
            listado = new ListadoUserControl();
        }
        public NuevaPersonaUserControl ObtenerNuevoUsuario()
        {
            return new NuevaPersonaUserControl();
        }
        public ListadoUserControl ObtenerListadoUsuarios()
        {
            return listado;
        }
        public ConsultaPersona ObtenerConsultaPersonas()
        {
            return new ConsultaPersona();
        }
        public bool? AbrirDialogo()
        {
            DialogoHijo dialogo = new DialogoHijo();
            return dialogo.ShowDialog();
        }
    }
}
