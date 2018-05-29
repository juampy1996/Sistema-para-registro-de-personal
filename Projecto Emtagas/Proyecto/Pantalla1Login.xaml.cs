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
    /// Lógica de interacción para PantallaLogin.xaml
    /// </summary>
    public partial class PantallaLogin : Window
    {
        string DatoLogin;
        Model1Container BD = new Model1Container();
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtLoguin.Text=="admin" && txtPassw.Password == "admin")
            {
                DatoLogin = "Admin";
                Pantalla2Inicio pantallaInicio = new Pantalla2Inicio( DatoLogin , 0);
                pantallaInicio.Show();
                this.Close();
               
            }
            else
            {
                int aux = 0;
                if (txtLoguin.Text=="Null" && txtPassw.Password == "Null")
                {
                    MessageBox.Show("Usted no tiene permiso para entrar al sistema de administracion de personal");   
                }
                else
                {

                foreach (var item in BD.UsuarioSet)
                {
                    if (txtLoguin.Text == item.Login && txtPassw.Password == item.Passsword)
                    {
                        DatoLogin = item.Personal.Persona.Nombre + " " + item.Personal.Persona.Apellido;
                        Pantalla2Inicio pantallaInicio = new Pantalla2Inicio(DatoLogin, item.Id);
                        pantallaInicio.Show();
                        aux++;
                        this.Close();
                    }
                 
                }
                }
                if (aux==0)
                {
                        MessageBox.Show("Usted no tiene permiso para entrar al sistema de administracion de personal");   
                }
            }
                   
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
