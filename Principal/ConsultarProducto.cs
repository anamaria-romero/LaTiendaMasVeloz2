﻿using System;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class ConsultarProducto : Form
    {
        private ProductoController productoController;

        public ConsultarProducto()
        {
            InitializeComponent();
            productoController = new ProductoController();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(tbIdentificador.Text.Trim(), out int idVal) ? idVal : 0;

            if (id <= 0)
            {
                MessageBox.Show("Por favor, ingrese un identificador de producto válido.");
                return;
            }

            var productos = productoController.ObtenerProductos();
            var producto = productos.Find(p => p.id == id);

            if (producto != null)
            {
                lbMostrarProducto.Text = $"Nombre: {producto.nombre}\nMarca: {producto.marca}\nCantidad: {producto.cantidad}\nPrecio: {producto.precio:C}\nReferencia: {producto.referencia}";
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }
    }
}
