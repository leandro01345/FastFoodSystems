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
using FastFood.DALC;
namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para Sistema_Productos.xaml
    /// </summary>
    public partial class Sistema_Productos : Page
    {
        //Variables para gestionar la aplicacion de los productos
        ProductoCollection productos = new ProductoCollection();
        List<FastFood.DALC.Producto> carritoProductos;
        int totalPagar;
        
        //Constructores
        public Sistema_Productos()
        {
            InitializeComponent();
            ActualizarProductos();
            totalPagar = 0;
            carritoProductos = productos.GetProductos();
        }
        private void ActualizarProductos()
        {
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
            itemCollectionViewSource.Source = productos.GetProductos();
        }

        private void dg_carrito_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            carritoProductos = this.dg_carrito.Items.OfType<FastFood.DALC.Producto>().ToList();
            totalPagar = 0;
            foreach (var item in carritoProductos)
            {
                totalPagar += item.valor;
            }
            this.lblPrecioTotal.Content = "$"+ totalPagar.ToString();
            ActualizarProductos();
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            ConfirmarCompra cf = new ConfirmarCompra(totalPagar);
            cf.Show();
            //una ventana abierta cuando cierro otra, por lo que no puede ser a través del
            //constructor.

            //this.dg_carrito.Items.Clear();
            //this.lblPrecioTotal.Content = "$0"; tengo que averiguar una forma de modificar 

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.dg_carrito.Items.Clear();
            this.lblPrecioTotal.Content = "$0";
        }
    }
}
