using FastFood.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para ConfirmarCompra.xaml
    /// </summary>
    public partial class ConfirmarCompra : Window
    {
        FastFood.DALC.Usuario usuario;
        //variables a utilizar para la generacion de las cosas.
        ProductoCollection productos = new ProductoCollection();
        PedidoCollection pedidos = new PedidoCollection();
        List<FastFood.DALC.Producto> carritoProductos;
        int totalPagar;
        private  int vuelto;
        private int montoIngresado;
        String descripcion;

        public ConfirmarCompra()
        {
            InitializeComponent();
            
        }
        public ConfirmarCompra(int _totalPagar, List<FastFood.DALC.Producto> _carritoProductos, FastFood.DALC.Usuario _usuario, String _descripcion)
        {
            InitializeComponent();
            totalPagar = _totalPagar;
            this.lblTotalPagar.Content = "$"+totalPagar.ToString();
            this.carritoProductos = _carritoProductos;
            this.usuario = _usuario;
            this.descripcion = _descripcion;
            
        }

        private void txtMontoIngresado_GotFocus(object sender, RoutedEventArgs e)
        {
            this.txtMontoIngresado.Text = "";
        }

        private void txtMontoIngresado_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!txtMontoIngresado.Equals("") && txtMontoIngresado.Text.Length <9 && txtMontoIngresado.Text != string.Empty)
                {
                     vuelto = int.Parse(this.txtMontoIngresado.Text) - totalPagar;
                    if (vuelto>0)
                    {
                        this.txtVuelto.Text = "$" + vuelto;
                    }
                    
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtMontoIngresado_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!txtMontoIngresado.Equals("") && txtMontoIngresado.Text.Length < 9 && txtMontoIngresado.Text != string.Empty)
            {
                montoIngresado = int.Parse(txtMontoIngresado.Text);
            }
            if (montoIngresado>=totalPagar)
            {
                FastFood.Negocio.Pedido p = new FastFood.Negocio.Pedido();
                if (descripcion == "Ingresa los detalles adicionales del cliente aquí.")
                {
                    descripcion = "Sin descripción";
                }
                p.descripcion = descripcion;
                p.estado = "en cola";
                p.usuario_id_usuario = usuario.id_usuario;
                p.valor = totalPagar;
                p.fecha = DateTime.Today;
                p.Create();
                List<Producto> listAux = new List<Producto>();

                foreach (FastFood.DALC.Producto productoItem in carritoProductos)
                {
                    Producto prod = new Producto();
                    prod.id_producto = 0;
                    prod.cantidad = productoItem.cantidad;
                    prod.nombre = productoItem.nombre;
                    prod.valor = productoItem.valor;
                    prod.pedido_id_pedido = pedidos.GetPedidos().Last().id_pedido;
                    listAux.Add(prod);
                    productoItem.cantidad = 1;
                }


                foreach (FastFood.Negocio.Producto productoItem in listAux)
                {
                    productoItem.Create();
                }
                this.Close();

                imprimirBoleta();
                Sistema_Productos.triggerLimpiar = true;
            }
           
        }

        private void imprimirBoleta()
        {
            Console.WriteLine("FastFood Systems");
            Console.WriteLine("Pedido N°: " + pedidos.GetPedidos().Last().id_pedido);
            Console.WriteLine("---------------------------");
            foreach (FastFood.DALC.Producto productoItem in carritoProductos)
            {

                Console.Write(productoItem.nombre.Trim() + " X" + productoItem.cantidad);
                Console.WriteLine("   - " + productoItem.valor);
                
            }
            Console.WriteLine("---------------------------");
            Console.Write("TOTAL: " + this.totalPagar);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Sistema_Productos.confirmarCompra = null;
            
        }
    }
}
