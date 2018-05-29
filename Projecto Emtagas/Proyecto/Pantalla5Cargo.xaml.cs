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
    /// Lógica de interacción para Pantalla5Cargo.xaml
    /// </summary>
    public partial class Pantalla5Cargo : Window
    {
        Model1Container BD = new Model1Container();
        Cargo obj;
        public Pantalla5Cargo()
        {
            InitializeComponent();
            //var a = BD.CargoSet.ToList();
            //MessageBox.Show(""+a);
            dgCargo.ItemsSource = BD.CargoSet.ToList();
            txtNombre.Text = "";
        }

        private void dgGrupo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                txtNombre.Text = "";
                obj = (Cargo)dgCargo.SelectedItem;
                txtNombre.Text = obj.NombreCargo;
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione un cargo");
            }
    
        }

        private void btbguardar_Click(object sender, RoutedEventArgs e)
        {
             if (txtNombre.Text == "")
            {
                MessageBox.Show("Asigne un nombre al cargo que desea crear");
            }
            else
            {
            obj = new Cargo();
            obj.NombreCargo = txtNombre.Text;
            BD.CargoSet.Add(obj);
            BD.SaveChanges();
            txtNombre.Text = "";
            dgCargo.ItemsSource = BD.CargoSet.ToList();
            dgCargo.Items.Refresh();
             }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obj = (Cargo)dgCargo.SelectedItem;
                BD.CargoSet.Remove(obj);
                BD.SaveChanges();
                dgCargo.ItemsSource = BD.CargoSet.ToList();
                dgCargo.Items.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("no se puede elimar por que este cargo se esta utilizando");
            }
           
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            obj.NombreCargo = txtNombre.Text;
            BD.SaveChanges();
            dgCargo.ItemsSource = BD.CargoSet.ToList();
            dgCargo.Items.Refresh();
        }

        private void btnnuevo_Click(object sender, RoutedEventArgs e)
        {
            //txtNombre.IsEnabled = true;
            txtNombre.Text = "";
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            //Pantalla4RegistroEmpleado pr = new Pantalla4RegistroEmpleado(0,"",0);
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