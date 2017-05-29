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
using System.Text.RegularExpressions;

namespace FastFoodProject.GerentePaginas
{
    /// <summary>
    /// Lógica de interacción para Mantenedor_Productos.xaml
    /// </summary>
    public partial class MantenedorProductos : Page
    {
        ProductoCollection productos = new ProductoCollection();
        public MantenedorProductos()
        {
            InitializeComponent();
            List<FastFood.DALC.Producto> productosGerente = productos.GetProductos();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
            itemCollectionViewSource.Source = productosGerente;
        }

        public void limpiarAgregar() {
            txtNombre.Text = string.Empty;
            txtValor.Text = string.Empty;
        }
        public void limpiarUpdate() {
            txtNombreUpdate.Text = string.Empty;
            txtValorUpdate.Text = string.Empty;
            txtCantidadUpdate.Text = string.Empty;

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
           

            try
            {
                Producto prod = new Producto();

                if (!prod.Read())
                {
                   
                    prod.nombre = txtNombre.Text;
                    if (!txtValor.Text.Equals("") && txtValor.Text.Length>0)
                    {
                        prod.valor = int.Parse(txtValor.Text);
                        prod.pedido_id_pedido = null;
                        prod.cantidad = 1;
                        if(prod.Create())
                        {
                            MessageBox.Show("¡Inserción exitosa!", "Aviso");
                        }
                        else
                        {
                            MessageBox.Show("¡Inserción fallida!", "Error");
                        }
                        this.limpiarAgregar();
                    }
                    else
                    {
                        MessageBox.Show("¡Inserción fallida!", "Error");
                    }
                    
                    

                }
                    
                 
            }
            catch (Exception )
            {
                MessageBox.Show("¡Inserción fallida!", "Error");
                throw;
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.id_producto = int.Parse(txtId.Text);
                    if (prod.Read())
                    {
                    txtNombreUpdate.Text = prod.nombre;
                    txtValorUpdate.Text = prod.valor.ToString();
                    txtCantidadUpdate.Text = prod.cantidad.ToString();
                     }
                    else
                    {
                        MessageBox.Show("¡Búsqueda fallida! Busque por ID.", "Error");
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Búsqueda fallida! Busque por ID.", "Error");
                throw;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.id_producto = int.Parse(txtId.Text);
                if (prod.Read())
                {
                    prod.nombre = txtNombreUpdate.Text;
                    prod.valor = int.Parse(txtValorUpdate.Text);
                    prod.cantidad = int.Parse(txtCantidadUpdate.Text);
                    prod.Update();
                    this.limpiarUpdate();
                    MessageBox.Show("¡Actualizado con exito!", "Aviso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Actualización fallida! recuerde buscar por el ID.", "Error");
                throw;
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.id_producto = int.Parse(txtId.Text);
                if (prod.Read())
                {
                    prod.Delete();
                    this.limpiarUpdate();
                    MessageBox.Show("¡Eliminado con exito!", "Aviso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡No se puedo eliminar correctamente!", "Error");
                throw;
            }
        }

        private void txtValor_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
        }

        private void txtId_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
        }

        private void txtCantidadUpdate_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
        }

        private void txtValorUpdate_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
        }
    }
}
