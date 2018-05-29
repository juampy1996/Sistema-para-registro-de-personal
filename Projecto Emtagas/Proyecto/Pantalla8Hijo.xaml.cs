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
    /// Lógica de interacción para Pantalla8Hijo.xaml
    /// </summary>
    public partial class Pantalla8Hijo : Window
    {
        Model1Container BD = new Model1Container();
        Hijo obj;
        Reporte_edicion objReporte;
        int idPapa;
        string nombreUsers;
        string NombrePa;
        public Pantalla8Hijo(int idPadre, string NombreDelUsuario, string NombrePadre)
        {
            InitializeComponent();
            idPapa = idPadre;
            nombreUsers = NombreDelUsuario;
            NombrePa = NombrePadre;
            //dgHijo.ItemsSource = BD.HijoSet.ToList().Where(o=>o.Persona.Id.Equals(idPadre));
            List<Hijo> lista = new List<Hijo>();
            foreach (var item in BD.HijoSet.ToList())
            {
                if (item.Persona.Id == idPadre)
                {
                    lista.Add(item);
                }
            }
            dgHijo.ItemsSource = lista;
            if (NombreDelUsuario != "Admin")
            {
                EditarHijos.IsEnabled = false;
                EliminarHijos.IsEnabled = false;
            }
        }

        private void AgregarHijos_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void AgregarHijos_Click_1(object sender, RoutedEventArgs e)
        {
            if (Nombrehijo.Text == "" || Apellidohijo.Text == "" || Cihijo.Text == "" || dtFechahijo.Text == "")
            {
                MessageBox.Show("llenar todos los campos");
            }
            else
            {

                try
                {
                    var ma = BD.PersonaSet.Max(o => o.Id);
                    int a = ma;
                    obj = new Hijo();
                    obj.Persona = new Persona();
                    obj.Ci_Hijo = Cihijo.Text;
                    obj.Nombre_Hijo = Nombrehijo.Text;
                    obj.Apellido_Hijo = Apellidohijo.Text;
                    obj.FechaNaciemiento_Hijo = dtFechahijo.SelectedDate.ToString();
                    if (RBHF.IsChecked == true)
                    {
                        obj.Genero_Hijo = "Femenino";
                    }
                    else
                    {
                        obj.Genero_Hijo = "Masculino";
                    }
                    if (idPapa == 0)
                    {
                        foreach (var item in BD.PersonaSet)
                        {
                            if (item.Id == a)
                            {
                                obj.Persona = (Persona)item;
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in BD.PersonaSet)
                        {
                            if (item.Id == idPapa)
                            {
                                obj.Persona = (Persona)item;
                            }
                        }
                    }
                    BD.HijoSet.Add(obj);
                    BD.SaveChanges();
                    Report("Registro de hijo");
                    MessageBox.Show("Hijo Registrado");
                    List<Hijo> lista = new List<Hijo>();
                    foreach (var item in BD.HijoSet.ToList())
                    {
                        if (item.Persona.Id == idPapa)
                        {
                            lista.Add(item);
                        }
                    }
                    dgHijo.ItemsSource = lista;
                    Cihijo.Text = "";
                    Apellidohijo.Text = "";
                    Nombrehijo.Text = "";
                    dtFechahijo.Text = "";
                    RBHF.IsChecked = false;
                    RBHM.IsChecked = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Llenar todos los campos");
                }
            }
        }

        private void dgHijo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                EditarHijos.IsEnabled = true;
                obj = (Hijo)dgHijo.SelectedItem;
                Cihijo.Text = obj.Ci_Hijo;
                Nombrehijo.Text = obj.Nombre_Hijo;
                Apellidohijo.Text = obj.Apellido_Hijo;
                dtFechahijo.SelectedDate = Convert.ToDateTime(obj.FechaNaciemiento_Hijo);
                if (obj.Genero_Hijo == "Femenino")
                {
                    RBHF.IsChecked = true;
                }
                else
                {
                    RBHM.IsChecked = true;
                }
            }
            catch (Exception)
            {
               
            }
           
        }

        private void EditarHijos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obj.Ci_Hijo = Cihijo.Text;
                obj.Nombre_Hijo = Nombrehijo.Text;
                obj.Apellido_Hijo = Apellidohijo.Text;
                obj.FechaNaciemiento_Hijo = dtFechahijo.SelectedDate.ToString();
                if (RBHF.IsChecked == true)
                {
                    obj.Genero_Hijo = "Femenino";
                }
                else
                {
                    obj.Genero_Hijo = "Masculino";
                }
                foreach (var item in BD.PersonaSet)
                {
                    if (item.Id == idPapa)
                    {
                        obj.Persona = (Persona)item;
                    }
                }
                BD.SaveChanges();
                dgHijo.Items.Refresh();
                Report("Hijo Editado");
                MessageBox.Show("Hijo Editado");

            }
            catch (Exception)
            {
                
                MessageBox.Show("Seleccione la persona que desea editar");
            }
           

        }

        private void EliminarHijos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obj = (Hijo)dgHijo.SelectedItem;
                BD.HijoSet.Remove(obj);
                BD.SaveChanges();
                dgHijo.Items.Refresh();
                dgHijo.ItemsSource = BD.HijoSet.ToList();
                //dgHijo.Items.Refresh();
                Report("Hijo Eliminado");
                MessageBox.Show("Hijo Eliminado");
                Cihijo.Text = "";
                Apellidohijo.Text = "";
                Nombrehijo.Text = "";
                dtFechahijo.Text = "";
                RBHF.IsChecked = false;
                RBHM.IsChecked = false;
                EditarHijos.IsEnabled = false;               
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione la persona que desea eliminar");
            }
         
        }

        private void LimpiarHijos_Click(object sender, RoutedEventArgs e)
        {
            Cihijo.Text = "";
            Apellidohijo.Text = "";
            Nombrehijo.Text = "";
            dtFechahijo.Text = "";
            RBHF.IsChecked = false;
            RBHM.IsChecked = false;
           EditarHijos.IsEnabled = false;

        }
        private void Report(string tipoEdicion)
        {
            objReporte = new Reporte_edicion();
            objReporte.Fecha_Edicion = DateTime.Now.ToString();
            objReporte.Persona_Editada = NombrePa;
            objReporte.Usario_Editor = nombreUsers;
            objReporte.Tipo_edicion = tipoEdicion;
            BD.Reporte_edicionSet.Add(objReporte);
            BD.SaveChanges();
        }

        private void dgHijo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}

//*******************************************************************************************************************
//DESARROLLADO POR:
//JUAN PABLO MERILES - 76812623
//MARLENE CHOQUE - 77870397
//*******************************************************************************************************************