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
using System.Windows.Shapes;

namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para CocineroView.xaml
    /// </summary>
    public partial class CocineroView : Window
    {

        FastFood.Negocio.PedidoCollection pedidos = new FastFood.Negocio.PedidoCollection();
        FastFood.DALC.Usuario usuario = new FastFood.DALC.Usuario();
        FastFood.Negocio.ProductoCollection productosList = new FastFood.Negocio.ProductoCollection();
        public CocineroView(FastFood.DALC.Usuario usuarioCocinero)
        {
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            List<FastFood.DALC.Pedido> pedidosAux = pedidos.GetPedidos();
            pedidosAux.Reverse();
            itemCollectionViewSource.Source = pedidosAux;
       }

       private void button_Copy2_Click(object sender, RoutedEventArgs e)
       {
           Login login = new Login();
           login.Show();
           this.Close();
       }

       private void DgPedidosCurso_LoadingRow(object sender, DataGridRowEventArgs e)
       {
           this.DgPedidosCola.Items.Refresh();
       }

       private void DgPedidosCola_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           FastFood.DALC.Pedido pedidox = (FastFood.DALC.Pedido)DgPedidosCola.SelectedItem;
            if (pedidox!=null)
            {
                CollectionViewSource itemCollectionViewSource;
                itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
                itemCollectionViewSource.Source = productosList.GetProductosPorPedido(pedidox.id_pedido);

            }

        }

        private void DgPedidosCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FastFood.DALC.Pedido pedido = (FastFood.DALC.Pedido)DgPedidosCurso.SelectedItem;
            if (pedido != null)
            {
                CollectionViewSource itemCollectionViewSource;
                itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
                itemCollectionViewSource.Source = productosList.GetProductosPorPedido(pedido.id_pedido);

            }
        }

        private void DgPedidosListos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FastFood.DALC.Pedido pedido = (FastFood.DALC.Pedido)DgPedidosListos.SelectedItem;
            if (pedido != null)
            {
                CollectionViewSource itemCollectionViewSource;
                itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
                itemCollectionViewSource.Source = productosList.GetProductosPorPedido(pedido.id_pedido);

            }
        }

        private void DgPedidosCurso_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            FastFood.DALC.Pedido pedido = (FastFood.DALC.Pedido)DgPedidosCurso.SelectedItem;
            if (pedido != null)
            {
                CollectionViewSource itemCollectionViewSource;
                itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
                itemCollectionViewSource.Source = productosList.GetProductosPorPedido(pedido.id_pedido);

            }
        }
    }

}
