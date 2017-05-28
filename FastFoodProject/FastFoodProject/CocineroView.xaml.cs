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
using FastFood.Negocio;

namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para CocineroView.xaml
    /// </summary>
    public partial class CocineroView : Window
    {
        PedidoCollection pedidos = new PedidoCollection(); 
        public CocineroView(FastFood.DALC.Usuario usuarioCocinero)
        {
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("pedidoViewSource"));
            itemCollectionViewSource.Source = pedidos.GetPedidos();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
