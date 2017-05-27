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

namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para GerenteView.xaml
    /// </summary>
    public partial class GerenteView : Window
    {
        

        public GerenteView(FastFood.DALC.Usuario usuarioGerente)
        {
            InitializeComponent();
           
            
        }

        private void btnMantenedorProductos_Click(object sender, RoutedEventArgs e)
        {
            this.GerenteFrame.Content = new GerentePaginas.MantenedorProductos();
        }

        private void btnMantenedorPublicidad_Click(object sender, RoutedEventArgs e)
        {
            GerenteFrame.Content = new GerentePaginas.MantenedorPublicidad();
        }

        private void GerenteFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnGestionUsuario_Click(object sender, RoutedEventArgs e)
        {
            this.GerenteFrame.Content = new GerentePaginas.MantenedorUsuario();
        }
    }
}
