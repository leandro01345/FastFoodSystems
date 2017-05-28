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
            txtCantidad.Text = string.Empty;
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
                    prod.valor = int.Parse(txtValor.Text);
                    prod.cantidad = int.Parse(txtCantidad.Text);
                   
                    prod.Create();
                    this.limpiarAgregar();

                }
                    
                 
            }
            catch (Exception )
            {

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
            }
            catch (Exception)
            {

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
                }
            }
            catch (Exception)
            {

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
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
