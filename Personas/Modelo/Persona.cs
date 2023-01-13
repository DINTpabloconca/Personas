using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Modelo
{
    class Persona:ObservableObject
    {
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona(int edad, string nombre, string nacionalidad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
            this.Nacionalidad = nacionalidad;
        }
    }
}
