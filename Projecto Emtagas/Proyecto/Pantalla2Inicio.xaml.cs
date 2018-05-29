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
using System.Data.SqlClient;

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Pantalla2Inicio.xaml
    /// </summary>
    public partial class Pantalla2Inicio : Window
    {
        Model1Container BD = new Model1Container();
        Personal obj;
        string nombreUsuario;
        int idUsuario;
        public Pantalla2Inicio( string datoLogin, int datoId)
        {
            //dgUsuarios.Columns.Remove(dgUsuarios.Columns[dgUsuarios.Columns.Count - 1]);
            nombreUsuario = datoLogin;
            idUsuario = datoId;
            InitializeComponent();
            PantallaLogin pantallaLoguin = new PantallaLogin();
            pantallaLoguin.Close();
            dgUsuarios.ItemsSource = BD.PersonalSet.ToList();
            //lblFecha.Content = DateTime.Now.ToString();
            lblUsuario.Content = datoLogin;
            //dgUsuarios.Columns.RemoveAt(1);
            //dgUsuarios.Columns.Remove(dgUsuarios.Columns[4]);
            if (nombreUsuario != "Admin")
            {
                reportemostrar.IsEnabled = false;
            }
       }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void NuevoEmpleado(object sender, RoutedEventArgs e)
        {
            //Pantalla4RegistroEmpleado PRegistro = new Pantalla4RegistroEmpleado();
            //PRegistro.Show();
         
        }

        private void RegistroEmpleado(object sender, RoutedEventArgs e)
        {
            Pantalla3Empleado Pantallaempleado = new Pantalla3Empleado();
            Pantallaempleado.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CajaTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CajaTexto_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            dgUsuarios.ItemsSource = BD.PersonalSet.ToList().Where(o => o.Persona.Apellido.ToUpper().Contains(txtBuscar.Text.ToUpper()) || o.Persona.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) || o.Persona.Ci.ToUpper().Contains(txtBuscar.Text.ToUpper()));
            dgUsuarios.Items.Refresh();
        }
        int EnviarId;
        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //obj = (Personal)dgUsuarios.SelectedItem;
            ////datoEnviar = obj.Persona.Id;
            //EnviarId = obj.Persona.Id;
            //Pantalla4RegistroEmpleado pr = new Pantalla4RegistroEmpleado(EnviarId, nombreUsuario);
            //pr.Show();
            //this.Close();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Pantalla4RegistroEmpleado PE = new Pantalla4RegistroEmpleado(EnviarId, nombreUsuario, idUsuario);
            this.Close();           
            PE.ShowDialog();
        }
        private void dgUsuarios_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            try
            {
                obj = (Personal)dgUsuarios.SelectedItem;
                EnviarId = obj.Persona.Id;
                Pantalla6Detalle pd = new Pantalla6Detalle(EnviarId, nombreUsuario, idUsuario);
                this.Close();
                pd.ShowDialog();
    
            }
            catch (Exception)
            {
                
                MessageBox.Show("Seleccione una persona");
            }          
          
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //obj = (Personal)dgUsuarios.SelectedItem;
            //EnviarId = obj.Persona.Id;
            //Pantalla6Detalle pd = new Pantalla6Detalle(EnviarId);
            //pd.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
    
              Pantalla9Reporte rp9 = new Pantalla9Reporte();
                rp9.ShowDialog();
            
        }

        private void lblSalir_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
        SqlConnection conexion = new SqlConnection("server=toshiba ; database=EMTAGAS ; integrated security = true");
        //string direccion = Environment.CurrentDirectory + "\\CopiaSeguridad";
        
        private void copiaSeguridad_Click(object sender, RoutedEventArgs e)
        {
            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " DatosPersonal.bak");
            string comando_consulta = "BACKUP DATABASE [EMTAGAS] TO  DISK = N'E:\\Sistema Personal Emtagas\\CopiasDeSeguridad\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'EMTAGAS-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta, conexion);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia se ha creado satisfactoriamente");

            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        //*******************************************************************************************************************
        //DESARROLLADO POR:
        //JUAN PABLO MERILES - 76812623
        //MARLENE CHOQUE - 77870397
        //*******************************************************************************************************************
    }
}
