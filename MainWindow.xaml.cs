using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        private List<Producto> inventario = new List<Producto>();

        public MainWindow()
        {
            InitializeComponent();
            CargarInventarioInicial(); // Carga algunos productos de ejemplo al iniciar la aplicación
        }

        private void CargarInventarioInicial()
        {
            // Carga de ejemplo, puedes agregar productos reales aquí
            inventario.Add(new Producto { Id = 1, Nombre = "Producto 1", Precio = 10, Cantidad = 50 });
            inventario.Add(new Producto { Id = 2, Nombre = "Producto 2", Precio = 15, Cantidad = 30 });

            ActualizarListaProductos();
        }

        private void ActualizarListaProductos()
        {
            lvProductos.ItemsSource = null;
            lvProductos.ItemsSource = inventario;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            // Agregar producto al inventario
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            Producto nuevoProducto = new Producto { Id = id, Nombre = nombre, Precio = precio, Cantidad = cantidad };
            inventario.Add(nuevoProducto);

            ActualizarListaProductos();

            // Limpiar campos después de agregar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }
    }
}
