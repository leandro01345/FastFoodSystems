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
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<FastFood.Negocio.Usuario> usu = new List<FastFood.Negocio.Usuario>();
            List<UsuarioCollection> usuario = new List<UsuarioCollection>();
         
            try
            {
                

                foreach (FastFood.Negocio.Usuario usuarios in usu)
                {
                    if (usuarios.usuario1 == txtUserName.Text && usuarios.password == txtPwd.ToString())
                    {
                        
                        this.Close();
                        if (usuarios.tipoUsuario==1)
                        {
                            
                            MainWindow cajero = new MainWindow(usuarios);
                            cajero.Show();
                        }
                        if (usuarios.tipoUsuario == 2)
                        {
                            CocineroView cocinero = new CocineroView(usuarios);
                            cocinero.Show();
                            
                        }
                        if (usuarios.tipoUsuario == 3)
                        {
                            
                            GerenteView gerente = new GerenteView(usuarios);
                            gerente.Show();
                        
                            
                        }

                    }
                }
                
                

               
               

            }
            catch (Exception)
            {

               
            }

        }

      
    }
}
