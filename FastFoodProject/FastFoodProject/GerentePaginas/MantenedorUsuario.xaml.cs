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
    /// Lógica de interacción para MantenedorUsuario.xaml
    /// </summary>
    public partial class MantenedorUsuario : Page
    {
        UsuarioCollection usuarios = new UsuarioCollection();
        public MantenedorUsuario()
        {
            InitializeComponent();
            CollectionViewSource itemCollectionViewSource;
            itemCollectionViewSource = (CollectionViewSource)(FindResource("usuarioViewSource"));
            itemCollectionViewSource.Source = usuarios.GetUsuarios();
        }

        public void limpiarAgregar() {

            txtNombre.Text=string.Empty;
            txtPwd.Text = string.Empty;
            txtTitular.Text = string.Empty;
            txtRut.Text = string.Empty;
            cboTipoUsuario.SelectedIndex = 0;
        }

        public void limpiarUpdate() {
            txtIdUsuario.Text = string.Empty;
            txtNombreUpdate.Text = string.Empty;
            txtRutUpdate.Text = string.Empty;
            txtTitularUpdate.Text = string.Empty;
            cboTipoUsuarioUp.SelectedIndex = 0;

        }
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Usuario usu = new Usuario();
                usu.usuario1 = txtNombre.Text;
                usu.password = txtPwd.Text;
                usu.titular = txtTitular.Text;
                usu.rut = txtRut.Text;
                if (itemCajero.IsSelected)
                {
                    usu.tipoUsuario = 1;
                }
                if (itemCocinero.IsSelected)
                {
                    usu.tipoUsuario = 2;
                }
                if (itemGerente.IsSelected)
                {
                    usu.tipoUsuario = 3;
                }

                if(usu.Create())
                {
                    MessageBox.Show("¡Inserción exitosa!", "Aviso");
                }
                else
                {
                    MessageBox.Show("¡Inserción fallida!", "Error");
                }
                this.limpiarAgregar();
                

            }
            catch (Exception)
            {
                MessageBox.Show("¡Inserción fallida!", "Error");
                throw;
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario usu = new Usuario();
                usu.id_usuario = int.Parse(txtIdUsuario.Text);
                if (usu.Read())
                {
                    txtNombreUpdate.Text = usu.usuario1;
                    txtTitularUpdate.Text = usu.titular;
                    txtRutUpdate.Text = usu.rut;
                    
                    if (usu.tipoUsuario == 1)
                    {
                        cboTipoUsuarioUp.SelectedIndex = 2;
                    }
                    if (usu.tipoUsuario == 2)
                    {
                        cboTipoUsuarioUp.SelectedIndex = 3;
                    }
                    if (usu.tipoUsuario == 3)
                    {
                        cboTipoUsuarioUp.SelectedIndex = 4;
                    }
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("¡Búsqueda fallida!", "Error");
                throw;
            }
         
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            
            try
            {
                Usuario usu = new Usuario();
                usu.id_usuario = int.Parse(txtIdUsuario.Text);
                if (usu.Read())
                {
                    usu.usuario1 = txtNombreUpdate.Text;
                    usu.rut = txtRutUpdate.Text;
                    usu.titular = txtTitularUpdate.Text;
                    if (cboCajeroUp.IsSelected)
                    {
                        usu.tipoUsuario = 1;
                    }
                    if (cboCocineroUp.IsSelected)
                    {
                        usu.tipoUsuario = 2;
                    }
                    if (cboGerenteUp.IsSelected)
                    {
                        usu.tipoUsuario = 3;
                    }

                    usu.Update();
                    this.limpiarUpdate();
                    MessageBox.Show("¡Actualización exitosa!", "Error");
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
                Usuario usu = new Usuario();
                usu.id_usuario = int.Parse(txtIdUsuario.Text);
                if (usu.Read())
                {
                    usu.Delete();
                    this.limpiarUpdate();
                }
                MessageBox.Show("¡Eliminación exitosa!", "Aviso");
            }
            catch (Exception)
            {
                MessageBox.Show("¡Eliminación fallida!", "Error");
                throw;
            }
        }

        private void txtIdUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = Regex.Replace(((TextBox)sender).Text, @"[^\d]", "");
            ((TextBox)sender).Text = s;
        }
    }
}
