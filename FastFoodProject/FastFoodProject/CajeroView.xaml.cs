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
namespace FastFoodProject
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(FastFood.DALC.Usuario usuarioCajero)
        {
            InitializeComponent();
            this.frame.Content = new Sistema_Productos();
            this.txtUser.Text = "Bienvenido, "+ usuarioCajero.titular;
        }
        public MainWindow()
        {
            InitializeComponent();
            this.frame.Content = new Sistema_Productos();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Content = new Sistema_Ordenes();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Content = new Sistema_Productos();
        }

    }
}
