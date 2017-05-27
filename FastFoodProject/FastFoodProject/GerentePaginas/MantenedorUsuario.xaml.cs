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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FastFood.Negocio;
namespace FastFoodProject.GerentePaginas
{
    /// <summary>
    /// Lógica de interacción para MantenedorUsuario.xaml
    /// </summary>
    public partial class MantenedorUsuario : Page
    {
        UsuarioCollection usuarios = new UsuarioCollection();
        public MantenedorUsuario()
        {
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("usuarioViewSource"));
            itemCollectionViewSource.Source = usuarios.GetUsuarios();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (true)
                {
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
