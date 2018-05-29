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
    /// Lógica de interacción para Pantalla6Detalle.xaml
    /// </summary>
    public partial class Pantalla6Detalle : Window
    {
        Model1Container BD = new Model1Container();
        int Id;
        string usuario = "";
        int idUsuarioo;
        public Pantalla6Detalle( int recibiID, string nombreusuario, int idUsuario)
        {
           
            InitializeComponent();
            usuario = nombreusuario;
            idUsuarioo = idUsuario;
            Id = recibiID;
            foreach (var item in BD.PersonalSet.ToList())
            {
                if (item.Id==recibiID)
                {
                    ci.Content = item.Persona.Ci;
                    nomre.Content = item.Persona.Nombre;
                    apellido.Content = item.Persona.Apellido;
                    genero.Content = item.Persona.Genero;
                    Fnacimiento.Content = item.Persona.FechaNacimiento;
                    telefono.Content = item.Persona.Telefono;
                    direccion.Content = item.Persona.Direccion;
                    haberBasico.Content = item.HaberBasico;
                    TipoContrato.Content = item.Tipo_Contrato.Nombre_TipoContrato;
                    Nivel.Content = item.Nivel1.NombreNivel;
                    Cargo.Content = item.Cargo1.NombreCargo;
                    FechaIngreso.Content = item.FechaIngreso;
                    Profesion.Content = item.Persona.Profesion;
                    Estado.Content = item.Estado.NombreEstado;
                    DireccionRegional.Content = item.Persona.Personal.DireccionRegional;
                    try
                    {
                        BitmapImage imagen = new BitmapImage();
                        imagen.BeginInit();
                        imagen.UriSource = new Uri(item.Persona.Foto);
                        imagen.EndInit();
                        imgFoto.Source = imagen;
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("esta persona no tiene foto");
                        //bitmapimage imagen = new bitmapimage();
                        //imagen.begininit();
                        //imagen.urisource = new uri(@"c:\users\usuario\desktop\projecto emtagas18 (crud, login)\proyecto\bin\debug\\nofoto.png");
                        //imagen.endinit();
                        //imgfoto.source = imagen;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pantalla4RegistroEmpleado pr = new Pantalla4RegistroEmpleado(Id, usuario, idUsuarioo);
            pr.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          Pantalla2Inicio pii = new Pantalla2Inicio(usuario, idUsuarioo);
          this.Close();
          pii.ShowDialog();
        }

 
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Pantalla2Inicio pii = new Pantalla2Inicio(usuario, idUsuarioo);
            ////this.Close();
            //pii.ShowDialog();
            //MessageBox.Show("sa");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Pantalla2Inicio pii = new Pantalla2Inicio(usuario, idUsuarioo);
            ////this.Close();
            //pii.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            atras.Visibility = System.Windows.Visibility.Hidden;
            ver.Visibility = System.Windows.Visibility.Hidden;
            imprimir.Visibility = System.Windows.Visibility.Hidden;
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {

                dialog.PrintVisual(this, "Impresión");

            }
            atras.Visibility = System.Windows.Visibility.Visible;
            ver.Visibility = System.Windows.Visibility.Visible;
            imprimir.Visibility = System.Windows.Visibility.Visible;
        }

        //*******************************************************************************************************************
        //DESARROLLADO POR:
        //JUAN PABLO MERILES - 76812623
        //MARLENE CHOQUE - 77870397
        //*******************************************************************************************************************
    }
}
