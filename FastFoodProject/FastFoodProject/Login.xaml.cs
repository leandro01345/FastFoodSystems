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
using FastFood.DALC;
using FastFood.Negocio;

namespace FastFoodProject
{
  
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        
        public Login()
        {
            InitializeComponent();
        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsuarioCollection listaUsuarios = new UsuarioCollection();
   
            try
            {


                foreach (FastFood.DALC.Usuario usuario in listaUsuarios.GetUsuarios())
                {
                    if (usuario.usuario1.Trim() == txtUserName.Text && usuario.password.Trim() == txtPwd.Password)
                    {

                        
                        if (usuario.tipoUsuario == 1)
                        {

                            MainWindow cajero = new MainWindow(usuario);
                            cajero.Show();
                        }
                        if (usuario.tipoUsuario == 2)
                        {
                            CocineroView cocinero = new CocineroView(usuario);
                            cocinero.Show();    
                        }
                        if (usuario.tipoUsuario == 3)
                        {

                            GerenteView gerente = new GerenteView(usuario);
                            gerente.Show();
                        }
                        this.Close();
                    }
                }
                this.lblMessage.Content = "Error - Usuario no encontrado.";
            }
            catch (Exception)
            {
            }
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UsuarioCollection listaUsuarios = new UsuarioCollection();

                try
                {


                    foreach (FastFood.DALC.Usuario usuario in listaUsuarios.GetUsuarios())
                    {
                        if (usuario.usuario1.Trim() == txtUserName.Text && usuario.password.Trim() == txtPwd.Password)
                        {


                            if (usuario.tipoUsuario == 1)
                            {

                                MainWindow cajero = new MainWindow(usuario);
                                cajero.Show();
                            }
                            if (usuario.tipoUsuario == 2)
                            {
                                CocineroView cocinero = new CocineroView(usuario);
                                cocinero.Show();
                            }
                            if (usuario.tipoUsuario == 3)
                            {

                                GerenteView gerente = new GerenteView(usuario);
                                gerente.Show();
                            }
                            this.Close();
                        }
                    }
                    this.lblMessage.Content = "Error - Usuario no encontrado.";
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
