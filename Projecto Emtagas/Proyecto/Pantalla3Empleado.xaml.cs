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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Pantalla3Empleado.xaml
    /// </summary>
    public partial class Pantalla3Empleado : Window
    {
        public Pantalla3Empleado()
        {
            InitializeComponent();
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NuevoEmpleado(object sender, RoutedEventArgs e)
        {
            //Pantalla4RegistroEmpleado PRegistro = new Pantalla4RegistroEmpleado();
            //PRegistro.Show();
        }
    }
}

//*******************************************************************************************************************
//DESARROLLADO POR:
//JUAN PABLO MERILES - 76812623
//MARLENE CHOQUE - 77870397
//*******************************************************************************************************************