using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para Pantalla4RegistroEmpleado.xaml
    /// </summary>
    public partial class Pantalla4RegistroEmpleado : Window
    {
        Model1Container BD = new Model1Container();
        Personal obj;
        Conyugue obj2;
        Reporte_edicion objReporte;
        string foto;
        string origen;
        string destino;
        int id = 0;
        //int enviarId;
        int idPersona;
        string nombrePersona;
        string nameUSers;
        int idUsuarioo;
        string PrimerNombreCarpeta = "";
        public Pantalla4RegistroEmpleado(int idDelOtroLado, string NombreUsuario, int idUsuario)
        {
            InitializeComponent();
            idPersona = idDelOtroLado;
            nameUSers = NombreUsuario;
            idUsuarioo = idUsuario;
            nombrePersona = NombreUsuario;
            FechaMaquina.Content = DateTime.Now.ToString();
            txtCi.IsEnabled = true;
            if (idDelOtroLado > 0)
            {
               
                //btnGuardar.IsEnabled = false;
                id = idDelOtroLado;
                foreach (var item in BD.PersonalSet)
                {
                    if (item.Id == idDelOtroLado)
                    {
                        txtCi.Text = item.Persona.Ci;
                        txtApellidos.Text = item.Persona.Apellido;
                        txtNombre.Text = item.Persona.Nombre;
                        PrimerNombreCarpeta = Environment.CurrentDirectory + "\\documentos\\" + txtNombre.Text + " " + txtApellidos.Text;
                        if (item.Persona.Genero == "Femenino")
                        {
                            RbF.IsChecked = true;
                        }
                        else
                        {
                            RbM.IsChecked = true;
                        }
                        dtFecha.SelectedDate = Convert.ToDateTime(item.Persona.FechaNacimiento);
                        txtTelefono.Text = item.Persona.Telefono;
                        txtDireccion.Text = item.Persona.Direccion;
                        
                        cbTipoContrato.ItemsSource = BD.Tipo_ContratoSet.ToList().Where(o=>o.Nombre_TipoContrato.Contains(item.Tipo_Contrato.Nombre_TipoContrato));
                        cbTipoContrato.SelectedIndex = 0;
                        cbTipoContrato.ItemsSource = BD.Tipo_ContratoSet.ToList();

                        cbCargo.ItemsSource = BD.CargoSet.ToList().Where(o => o.NombreCargo.Contains(item.Cargo1.NombreCargo));
                        cbCargo.SelectedIndex = 0;
                        cbCargo.ItemsSource = BD.CargoSet.ToList();

                        cbNivel.ItemsSource = BD.NivelSet.ToList().Where(o=> o.NombreNivel.Contains(item.Nivel1.NombreNivel));
                        cbNivel.SelectedIndex = 0;
                        cbNivel.ItemsSource = BD.NivelSet.ToList();

                        /**/
                        cbEstado.ItemsSource = BD.EstadoSet.ToList().Where(o => o.NombreEstado.Contains(item.Estado.NombreEstado));
                        cbEstado.SelectedIndex = 0;
                        cbEstado.ItemsSource = BD.EstadoSet.ToList();
                        txtDireccionalRegional.Text = item.DireccionRegional;
                        /**/
                        
                        txtContraseña.Text = item.Usuario.Passsword;
                        txtUsuario.Text = item.Usuario.Login;

                        txtHaberBasico.Text = item.HaberBasico;
                        dtFecha_Copy.SelectedDate = Convert.ToDateTime(item.FechaIngreso);
                        txtProfesion.Text = item.Persona.Profesion;
                        try
                        {
                            CiConyugue.Text = item.Persona.Conyugue.Ci_Conyugue;
                            NombreConyugue.Text = item.Persona.Conyugue.Nombre_Conyugue;
                            ApellidoConyugue.Text = item.Persona.Conyugue.Apellido_Conyugue;
                            dtFechaConyugue.SelectedDate = Convert.ToDateTime(item.Persona.Conyugue.FechaNacimiento_Conyugue);
                            if (item.Persona.Conyugue.Genero_Conyugue == "Femenino")
                            {
                                RBCF.IsChecked = true;
                            }
                            else
                            {
                                RBCM.IsChecked = true;
                            }
                            AgregarConyugue.IsEnabled = false;
                      
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            BitmapImage imagen = new BitmapImage();
                            imagen.BeginInit();
                            imagen.UriSource = new Uri(item.Persona.Foto);
                            foto = item.Persona.Foto;
                            imagen.EndInit();
                            imgFoto.Source = imagen;
                            
                        }
                        catch (Exception)
                        {

                        }
                        Crear.IsEnabled = false;
                    }
                }
            }
            else if (idDelOtroLado == 0)
            {
                btnDocumentacion_Copy6.IsEnabled = false;
                btnDocumentacion_Copy7.IsEnabled = false;               
                cbCargo.ItemsSource = BD.CargoSet.ToList();
                cbNivel.ItemsSource = BD.NivelSet.ToList();
                cbTipoContrato.ItemsSource = BD.Tipo_ContratoSet.ToList();
                /**/
                cbEstado.ItemsSource = BD.EstadoSet.ToList();
                txtDireccionalRegional.IsEnabled = true;
                /**/
                txtCi.IsEnabled = true;
                txtApellidos.IsEnabled = true;
                txtDireccion.IsEnabled = true;
                txtNombre.IsEnabled = true;
                txtTelefono.IsEnabled = true;
                RbF.IsEnabled = true;
                RbM.IsEnabled = true;
                txtHaberBasico.IsEnabled = true;
            }
            if (NombreUsuario!="Admin")
            {
                txtContraseña.Visibility = Visibility.Hidden;
                txtUsuario.Visibility = Visibility.Hidden;
                lblUsuario.Visibility = Visibility.Hidden;
                lblContraseña.Visibility = Visibility.Hidden;
                btnDocumentacion_Copy6.IsEnabled = false;
                btnDocumentacion_Copy7.IsEnabled = false;

            }
        }
        private void nuevoCargo_Click(object sender, RoutedEventArgs e)
        {
            Pantalla5Cargo pc = new Pantalla5Cargo();
            pc.ShowDialog();
        }

        private void txtHaberBasico_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
      
        private void btnFoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*bmp";

            if (dialogo.ShowDialog() == true)
            {
                string nombre = dialogo.SafeFileName;
                origen = dialogo.FileName;
                destino = Environment.CurrentDirectory + "\\FotosDePerfil\\" + nombre;


                BitmapImage imagen = new BitmapImage();
                imagen.BeginInit();
                imagen.UriSource = new Uri(origen);
                imagen.EndInit();
                imgFoto.Source = imagen;
                foto = destino;
                ////System.IO.File.Copy(origen, destino, true);

            }
        }

        private void btnDocumentacion_Copy4_Click(object sender, RoutedEventArgs e)
        {

            Pantalla2Inicio pi = new Pantalla2Inicio(nameUSers, idUsuarioo);
            this.Close();
            pi.ShowDialog();
         
           
        }

        private void btnDocumentacion_Copy6_Click(object sender, RoutedEventArgs e)
        {
            
          MessageBoxResult result = MessageBox.Show("Esta seguro que desea guardar la edicion de esta persona", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                foreach (var item in BD.PersonalSet)
                {
                    if (item.Id == id)
                    {
                        item.Persona.Ci = txtCi.Text;
                        item.Persona.Nombre = txtNombre.Text;
                        item.Persona.Apellido = txtApellidos.Text;
                        if (RbF.IsChecked==true)
                        {
                            item.Persona.Genero = "Femenino";   
                        }
                        else
                        {
                            item.Persona.Genero = "Masculino";
                        }
                        item.Persona.FechaNacimiento = dtFecha.ToString();
                        item.Persona.Telefono = txtTelefono.Text;
                        item.Persona.Direccion = txtDireccion.Text;
                        item.Usuario.Login = txtUsuario.Text;
                        item.Usuario.Passsword = txtContraseña.Text;
                        item.Persona.Personal.Tipo_Contrato = (Tipo_Contrato)cbTipoContrato.SelectedItem;
                        item.Persona.Personal.Cargo1 = (Cargo)cbCargo.SelectedItem;
                        item.Persona.Personal.Nivel1 = (Nivel)cbNivel.SelectedItem;
                        /**/
                        item.Persona.Personal.Estado = (Estado)cbEstado.SelectedItem;
                        item.Persona.Personal.DireccionRegional = txtDireccionalRegional.Text;
                        /**/
                        item.Persona.Personal.HaberBasico = txtHaberBasico.Text;
                        item.Persona.Personal.FechaIngreso = dtFecha_Copy.ToString();
                        item.Persona.Foto = foto;
                        item.Usuario.Login = txtUsuario.Text;
                        item.Usuario.Passsword = txtContraseña.Text;
                        try
                        {
                            item.Persona.Conyugue.Ci_Conyugue = CiConyugue.Text;
                            item.Persona.Conyugue.Apellido_Conyugue = ApellidoConyugue.Text;
                            item.Persona.Conyugue.Nombre_Conyugue = NombreConyugue.Text;
                            item.Persona.Conyugue.FechaNacimiento_Conyugue = dtFechaConyugue.ToString();
                            if (RBCF.IsChecked == true)
                            {

                                item.Persona.Conyugue.Genero_Conyugue = "Femenino";
                            }
                            else
                            {
                                item.Persona.Conyugue.Genero_Conyugue = "Masculino";
                            }
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            System.IO.File.Copy(origen, destino, true);
                        }
                        catch (Exception)
                        {
                        }
                                               
                        BD.SaveChanges();
                    }
                }
                //File.Move(@"C:\Dir1\SomeFile.txt", @"C:\Dir1\RenamedFileName.txt");
                Report("Edicion");
                MessageBox.Show("Edicion exitosa");
                Pantalla2Inicio ppi = new Pantalla2Inicio(nameUSers, idUsuarioo);
                this.Close();
                ppi.ShowDialog();
         
              
            }
        }
        private void btnDocumentacion_Copy7_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Esta seguro que desea eliminar esta persona", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                foreach (var item in BD.PersonaSet)
                {
                    if (item.Id == id)
                    {
                        BD.PersonalSet.Remove(item.Personal);
                        try
                        {
                            BD.ConyugueSet.Remove(item.Conyugue);
                            BD.HijoSet.RemoveRange(item.Hijo);
                        }
                        catch (Exception)
                        {

                        }
                        BD.PersonaSet.Remove(item);
                        BD.SaveChanges();
                        Report("Eliminacion");
                        Pantalla2Inicio pp = new Pantalla2Inicio(nameUSers, idUsuarioo);
                        this.Close();
                        pp.ShowDialog();
                    }
                }
            }
        }

        private void btnFuardad_Click(object sender, RoutedEventArgs e)
        {
            Pantalla2Inicio pii = new Pantalla2Inicio(nameUSers, idUsuarioo);
            this.Close();
            pii.ShowDialog();
        }

        private void btnDocumentacion_Copy8_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void nuevoNivel_Click(object sender, RoutedEventArgs e)
        {
            Pantalla7Nivel pc = new Pantalla7Nivel();
            pc.ShowDialog();
        }

        private void VerSolicitudVacasiones_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Vacaciones");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void AñosDeServicio_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Curriculum");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Renta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Documentos");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Documentos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\otros");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Otros_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Bajas Medicas");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void AgregarHijos_Click(object sender, RoutedEventArgs e)
        {
            //Report("Registro Hijo"); 
            Pantalla8Hijo ph = new Pantalla8Hijo(idPersona, nombrePersona, txtNombre.Text+" "+txtApellidos.Text);
            ph.ShowDialog();
        }
        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtHaberBasico.Text != "" && dtFecha_Copy.Text!="")
                {

                    obj = new Personal();
                    obj.Persona = new Persona();
                    obj.Usuario = new Usuario();
                    obj.Persona.Ci = txtCi.Text;
                    obj.Persona.Nombre = txtNombre.Text;
                    obj.Persona.Apellido = txtApellidos.Text;
                    if (RbF.IsChecked == true)
                    {
                        obj.Persona.Genero = "Femenino";
                    }
                    else
                    {
                        obj.Persona.Genero = "Masculino";
                    }
                    obj.Persona.FechaNacimiento = dtFecha.SelectedDate.ToString();
                    obj.Persona.Telefono = txtTelefono.Text;
                    obj.Persona.Direccion = txtDireccion.Text;

                    obj.HaberBasico = txtHaberBasico.Text;
                    obj.FechaIngreso = dtFecha_Copy.SelectedDate.ToString();

                    obj.Cargo1 = (Cargo)cbCargo.SelectedItem;
                    obj.Tipo_Contrato = (Tipo_Contrato)cbTipoContrato.SelectedItem;
                    obj.Nivel1 = (Nivel)cbNivel.SelectedItem;
                    /**/
                    obj.Estado = (Estado)cbEstado.SelectedItem;
                    obj.DireccionRegional = txtDireccionalRegional.Text;
                    /**/
                    obj.Persona.Foto = foto;
                    if (txtUsuario.Text == "" && txtContraseña.Text == "")
                    {
                        obj.Usuario.Login = "Null";
                        obj.Usuario.Passsword = "Null";
                    }
                    else
                    {
                        obj.Usuario.Login = txtUsuario.Text;
                        obj.Usuario.Passsword = txtContraseña.Text;
                    }
                    obj.Persona.Profesion = txtProfesion.Text;
                    obj.FechaRegistro = FechaMaquina.Content.ToString();
                   
                    MessageBoxResult result = MessageBox.Show("Esta seguro que desea guardar los datos de esta peronsa " + '\n' + "Ci: " + txtCi.Text + '\n' + "Nombres: " + txtNombre.Text +
                    '\n' + "Apellido: " + txtApellidos.Text + '\n' + "Genero: " + obj.Persona.Genero + '\n' + "Año de nacimiento : " + obj.Persona.FechaNacimiento
                    + '\n' + "Telefono: " + txtTelefono.Text + '\n' + "Direccion: " + txtDireccion.Text + '\n' + "Profesion: " + txtProfesion.Text + '\n' + "Tipo de contrato: " + obj.Tipo_Contrato.Nombre_TipoContrato
                    + '\n' + "Nivel: " + obj.Nivel1.NombreNivel + '\n' + "Cargo: " + obj.Cargo1.NombreCargo + '\n' + "Haber Basico: " + obj.HaberBasico + '\n' + "Fecha de ingreso: " + obj.FechaIngreso + '\n' + "Estado: " + obj.Estado.NombreEstado + '\n' + "Direccional o regional: " + obj.DireccionRegional
                    , "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        if (obj.Persona.Foto == null)
                        {
                            obj.Persona.Foto = "no foto";
                        }
                        else
                        {
                            System.IO.File.Copy(origen, destino, true);
                        }
                        BD.PersonalSet.Add(obj);
                        BD.SaveChanges();
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id);
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Vacaciones");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Curriculum");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Documentos");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\otros");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Bajas Medicas");

                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Memorandum");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Instructivo");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Compensaciones");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Comisiones de viaje");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Años de servicio");
                        System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\documentos\\" + obj.Id + "\\Sanciones");

                        Report("Registro");
                        MessageBox.Show("Persona creada exitosamente");
                        Pantalla2Inicio pii = new Pantalla2Inicio(nameUSers, idUsuarioo);
                        this.Close();
                        pii.ShowDialog();
                    }
                }
                else
                {
                MessageBox.Show("Llene todo los campos antes de registrar");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Llene todo los campos antes de registrar");

            } 
        }
        private void Report(string tipoEdicion)
        {
            objReporte = new Reporte_edicion();
            objReporte.Fecha_Edicion = FechaMaquina.Content.ToString();
            objReporte.Persona_Editada = txtNombre.Text + " " + txtApellidos.Text;
            #region 
            //var ma = BD.PersonaSet.Max(o => o.Id);
            //int a = ma;
            //if (nombrePersona == "Admin")
            //{
            //    foreach (var item in BD.PersonalSet)
            //    {
            //        if (item.Id == a)
            //        {
            //            objReporte.Personal = (Personal)item;
            //        }
            //    }
            //}
            //else
            //{
            //    foreach (var item in BD.PersonalSet)
            //    {
            //        if (item.Id == idUsuarioo)
            //        {
            //            objReporte.Personal = (Personal)item;
            //        }
            //    }
            //}
            #endregion
            objReporte.Usario_Editor = nombrePersona;
            objReporte.Tipo_edicion = tipoEdicion;
            BD.Reporte_edicionSet.Add(objReporte);
            BD.SaveChanges();   
        }
        private void AgregarConyugue_Click(object sender, RoutedEventArgs e)
        {
            if (CiConyugue.Text == "" || ApellidoConyugue.Text == "" || NombreConyugue.Text == "" || dtFechaConyugue.Text == "")
              {
                MessageBox.Show("llenar todos los campos");
            }
            else
	{

                var ma = BD.PersonaSet.Max(o => o.Id);
                int a = ma;
                obj2 = new Conyugue();
                obj2.Ci_Conyugue = CiConyugue.Text;
                obj2.Nombre_Conyugue = NombreConyugue.Text;
                obj2.Apellido_Conyugue = ApellidoConyugue.Text;
                obj2.FechaNacimiento_Conyugue = dtFechaConyugue.SelectedDate.ToString();

                if (RBCF.IsChecked == true)
                {
                    obj2.Genero_Conyugue = "Femenino";
                }
                else
                {
                    obj2.Genero_Conyugue = "Masculino";
                }
                if (idPersona == 0)
                {
                    foreach (var item in BD.PersonaSet)
                    {
                        if (item.Id == a)
                        {
                            obj2.Persona = (Persona)item;
                        }
                    }
                }
                else
                {
                    foreach (var item in BD.PersonaSet)
                    {
                        if (item.Id == idPersona)
                        {
                            obj2.Persona = (Persona)item;
                        }
                    }
                }

                BD.ConyugueSet.Add(obj2);
                BD.SaveChanges();
                Report("Registro Conyugue");
                MessageBox.Show("Conyugue Agregado");
                AgregarConyugue.IsEnabled = false;

            }
                 }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Memorandums_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Memorandum");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Instructivos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Instructivo");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Compensaciones_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Compensaciones");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Comicionesdeviaje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Comisiones de viaje");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Añosdeservicio_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Años de servicio");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }

        private void Sansiones_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\documentos\\" + id + "\\Sanciones");
            }
            catch (Exception)
            {
                MessageBox.Show("Primero crear a la persona luego agregar documentos");
            }
        }
    }
}

//*******************************************************************************************************************
//DESARROLLADO POR:
//JUAN PABLO MERILES - 76812623
//MARLENE CHOQUE - 77870397
//*******************************************************************************************************************