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
        //variables a utilizar para la generacion de las cosas.
        ProductoCollection productos = new ProductoCollection();
        List<FastFood.DALC.Producto> carritoProductos = new List<FastFood.DALC.Producto>();
        int totalPagar;

        public ConfirmarCompra()
        {
            InitializeComponent();
            
        }
        public ConfirmarCompra(int _totalPagar)
        {
            InitializeComponent();
            totalPagar = _totalPagar;
            this.lblTotalPagar.Content = "$"+totalPagar.ToString();
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
                    int vuelto = int.Parse(this.txtMontoIngresado.Text) - totalPagar;
                    this.txtVuelto.Text = "$" + vuelto;
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
            this.Close();
            
        }
    }
}
