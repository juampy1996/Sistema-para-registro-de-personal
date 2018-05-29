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
    /// Lógica de interacción para Pantalla7Nivel.xaml
    /// </summary>
    public partial class Pantalla7Nivel : Window
    {
        Model1Container BD = new Model1Container();
        Nivel obj;
        public Pantalla7Nivel()
        {
            InitializeComponent();
            dgNivel.ItemsSource = BD.NivelSet.ToList();
            txtNombre.Text = "";
        }

        private void dgGrupo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                txtNombre.Text = "";
                obj = (Nivel)dgNivel.SelectedItem;
                txtNombre.Text = obj.NombreNivel;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un nivel");   
            }

        }

        private void btbguardar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Asigne un nombre al nivel que desea crear");
            }
            else
            {

                obj = new Nivel();
                obj.NombreNivel = txtNombre.Text;
                BD.NivelSet.Add(obj);
                BD.SaveChanges();
                txtNombre.Text = "";
                dgNivel.ItemsSource = BD.NivelSet.ToList();
                dgNivel.Items.Refresh();
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                obj = (Nivel)dgNivel.SelectedItem;
                BD.NivelSet.Remove(obj);
                BD.SaveChanges();
                dgNivel.ItemsSource = BD.NivelSet.ToList();
                dgNivel.Items.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("no se puede elimar por que este cargo se esta utilizando");
            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            obj.NombreNivel = txtNombre.Text;
            BD.SaveChanges();
            dgNivel.ItemsSource = BD.NivelSet.ToList();
            dgNivel.Items.Refresh();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            txtNombre.Text = "";
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            //Pantalla4RegistroEmpleado pr = new Pantalla4RegistroEmpleado(0, "", 0);
            this.Close();
            //pr.ShowDialog();
        }
    }
}
//*******************************************************************************************************************
//DESARROLLADO POR:
//JUAN PABLO MERILES - 76812623
//MARLENE CHOQUE - 77870397
//*******************************************************************************************************************