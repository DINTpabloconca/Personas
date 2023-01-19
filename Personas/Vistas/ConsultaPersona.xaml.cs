using Personas.Vista_Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas.Vistas
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersona.xaml
    /// </summary>
    public partial class ConsultaPersona : UserControl
    {
        ConsultaPersonaVM vm;
        public ConsultaPersona()
        {
            InitializeComponent();
            vm = new ConsultaPersonaVM();
            this.DataContext = vm;
        }
    }
}
