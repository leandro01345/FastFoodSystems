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

namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para Sistema_Ordenes.xaml
    /// </summary>
    public partial class Sistema_Ordenes : Page
    {
        FastFood.Negocio.PedidoCollection pedidos = new FastFood.Negocio.PedidoCollection();

        public Sistema_Ordenes()
        {
            InitializeComponent();
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            itemCollectionViewSource.Source = pedidos.GetPedidos();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
