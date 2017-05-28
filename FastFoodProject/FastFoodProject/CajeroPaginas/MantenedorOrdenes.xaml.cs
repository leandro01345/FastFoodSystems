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
        FastFood.DALC.Usuario usuario = new FastFood.DALC.Usuario();
        FastFood.Negocio.ProductoCollection productosList = new FastFood.Negocio.ProductoCollection();
        public Sistema_Ordenes( FastFood.DALC.Usuario _usuario)
        {
            InitializeComponent();

            usuario = _usuario;

            List <FastFood.DALC.Pedido> pedidosUsuario = pedidos.GetPedidos();

            foreach (FastFood.DALC.Pedido pedido in pedidosUsuario)
            {
                if (usuario.id_usuario != pedido.usuario_id_usuario)
                {
                    pedidosUsuario.Remove(pedido);
                }
            }

            pedidosUsuario.Reverse();

            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            itemCollectionViewSource.Source = pedidosUsuario;

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pedidoDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FastFood.DALC.Pedido pedido = (FastFood.DALC.Pedido)pedidoDataGrid.SelectedItem;
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("productoViewSource"));
            itemCollectionViewSource.Source = productosList.GetProductosPorPedido(pedido.id_pedido);
            
        }
    }
}
