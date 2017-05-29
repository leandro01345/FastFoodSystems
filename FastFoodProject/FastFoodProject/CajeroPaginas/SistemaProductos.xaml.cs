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
        List<FastFood.DALC.Producto> productosBD;
        int totalPagar;
        FastFood.DALC.Usuario usuario;
        public static ConfirmarCompra confirmarCompra;
        public static bool triggerLimpiar = false;

        //Constructores
        public Sistema_Productos(FastFood.DALC.Usuario _usuario)
        {
            InitializeComponent();
            
            totalPagar = 0;
            carritoProductos = productos.GetProductos();
            usuario = _usuario;
            productosBD = productos.GetProductos();
            ActualizarProductos();
            limpiar();
        }

        //Constructores
        public Sistema_Productos()
        {
            InitializeComponent();
            
            totalPagar = 0;
            carritoProductos = productos.GetProductos();
            productosBD = productos.GetProductos();
            ActualizarProductos();
        }

        private void ActualizarProductos()
        {
            productosBD = productos.GetProductos();
            List<FastFood.DALC.Producto> productosAux = new List<FastFood.DALC.Producto>();
            foreach (var p in productosBD)
            {
                if (p.pedido_id_pedido==null)
                {
                    productosAux.Add(p);
                }
            }
            productosBD = productosAux;

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
            itemCollectionViewSource.Source = productosBD;
            this.productoListBox.Items.Refresh();

        }

        private void dg_carrito_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            
            carritoProductos = this.dg_carrito.Items.OfType<FastFood.DALC.Producto>().ToList();
            DataGridRow row1 = e.Row;
            int row_index = ((DataGrid)sender).ItemContainerGenerator.IndexFromContainer(row1);

            dg_carrito.Items.MoveCurrentToPrevious();

            int i = 0;
            int objetoIndex = 0;
            int indexCont = 0;
            foreach (FastFood.DALC.Producto p in carritoProductos)
            {
                if (p.Equals(carritoProductos.ElementAt(row_index)))
                {
                    i++;
                    if (i == 1)
                    {
                      objetoIndex = indexCont;
                    }
                    
                }
                indexCont++;
            } 

            if (i > 1)
            {
                carritoProductos.ElementAt(objetoIndex).cantidad++;
                //carritoProductos.Remove(carritoProductos.ElementAt(row_index));
                this.dg_carrito.Items.RemoveAt(row_index);
                this.dg_carrito.Items.Refresh();
                
            }

            totalPagar = 0;
            foreach (var item in carritoProductos)
            {
                totalPagar += item.valor * item.cantidad;
            }
            this.lblPrecioTotal.Content = "$" + totalPagar.ToString();

            ActualizarProductos();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (totalPagar > 0)
            {
                if (confirmarCompra == null)
                {
                    this.carritoProductos = this.dg_carrito.Items.OfType<FastFood.DALC.Producto>().ToList();
                    confirmarCompra = new ConfirmarCompra(totalPagar, this.carritoProductos, this.usuario, this.textBox.Text);
                    confirmarCompra.Show();
                }
                else
                {
                    MessageBox.Show("Debe limpiar la orden previa ya realizada.");
                }
               
                //una ventana abierta cuando cierro otra, por lo que no puede ser a través del
                //constructor.

                //this.dg_carrito.Items.Clear();
                //this.lblPrecioTotal.Content = "$0"; tengo que averiguar una forma de modificar 
            }


        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {

            ActualizarProductos();
            this.dg_carrito.Items.Clear();
            this.lblPrecioTotal.Content = "$0";
            int i = 0;
            this.totalPagar = 0;
            this.carritoProductos = productosBD;
            foreach (FastFood.DALC.Producto p in carritoProductos)
            {

                carritoProductos.ElementAt(i).cantidad = 1;
                i++;
            }
            productoListBox.Items.Refresh();
            this.textBox.Text = "Ingresa los detalles adicionales del cliente aquí.";
            confirmarCompra = null;
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (this.textBox.Text == "Ingresa los detalles adicionales del cliente aquí.") textBox.Text = "";
            
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.textBox.Text == "") textBox.Text = "Ingresa los detalles adicionales del cliente aquí.";
        }

        void limpiar()
        {
            ActualizarProductos();
            this.dg_carrito.Items.Clear();
            this.lblPrecioTotal.Content = "$0";
            int i = 0;
            this.totalPagar = 0;
            this.carritoProductos = productosBD;
            foreach (FastFood.DALC.Producto p in carritoProductos)
            {

                carritoProductos.ElementAt(i).cantidad = 1;
                i++;
            }
            productoListBox.Items.Refresh();
            this.textBox.Text = "Ingresa los detalles adicionales del cliente aquí.";
            confirmarCompra = null;
        }

        private void Page_GotFocus(object sender, RoutedEventArgs e)
        {
            if (triggerLimpiar)
            {
                triggerLimpiar = false;
                limpiar();
            }
        }
    }
}
