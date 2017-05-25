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
    /// Lógica de interacción para Sistema_Productos.xaml
    /// </summary>
    public partial class Sistema_Productos : Page
    {
        FastFood.Negocio.ProductoCollection productos = new FastFood.Negocio.ProductoCollection();
        public Sistema_Productos()
        {
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
            itemCollectionViewSource.Source = productos.GetProductos();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void productoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(productoDataGrid.SelectedItem);
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(productoDataGrid.SelectedItem);
        }

    }
}
