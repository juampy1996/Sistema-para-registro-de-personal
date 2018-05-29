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
    /// Lógica de interacción para Pantalla9Reporte.xaml
    /// </summary>
    public partial class Pantalla9Reporte : Window
    {
        Model1Container BD = new Model1Container();
        public Pantalla9Reporte()
        {
            InitializeComponent();
            dgEdicion.ItemsSource = BD.Reporte_edicionSet.ToList();
        }

        private void txtBuscar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            dgEdicion.ItemsSource = BD.Reporte_edicionSet.ToList().Where(o => o.Persona_Editada.ToUpper().Contains(txtBuscar.Text.ToUpper()));
            dgEdicion.Items.Refresh();
        }
    }
}
//*******************************************************************************************************************
//DESARROLLADO POR:
//JUAN PABLO MERILES - 76812623
//MARLENE CHOQUE - 77870397
//*******************************************************************************************************************