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
using System.Windows.Shapes;

namespace Personas.Vistas
{
    /// <summary>
    /// Lógica de interacción para DialogoHijo.xaml
    /// </summary>
    public partial class DialogoHijo : Window
    {
        DialogoVM vm;
        public DialogoHijo()
        {
            InitializeComponent();
            vm = new DialogoVM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            vm.EnviarMensaje();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
