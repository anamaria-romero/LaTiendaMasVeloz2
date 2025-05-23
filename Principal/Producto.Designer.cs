﻿namespace Principal
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTituloProducto = new Label();
            tbReferenciaProducto = new TextBox();
            tbNombreProducto = new TextBox();
            tbMarcaProducto = new TextBox();
            tbPrecioProducto = new TextBox();
            btRegistrarProducto = new Button();
            tbCantidadProducto = new TextBox();
            tbIngreseProveedor = new TextBox();
            lbProductoRegistrado = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // lbTituloProducto
            // 
            lbTituloProducto.AutoSize = true;
            lbTituloProducto.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloProducto.Location = new Point(201, 9);
            lbTituloProducto.Name = "lbTituloProducto";
            lbTituloProducto.Size = new Size(160, 32);
            lbTituloProducto.TabIndex = 0;
            lbTituloProducto.Text = "PRODUCTO";
            // 
            // tbReferenciaProducto
            // 
            tbReferenciaProducto.Location = new Point(25, 63);
            tbReferenciaProducto.Name = "tbReferenciaProducto";
            tbReferenciaProducto.Size = new Size(239, 23);
            tbReferenciaProducto.TabIndex = 1;
            tbReferenciaProducto.Text = "Ingrese la referencia";
            tbReferenciaProducto.TextChanged += tbReferenciaProducto_TextChanged;
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.Location = new Point(25, 161);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(239, 23);
            tbNombreProducto.TabIndex = 2;
            tbNombreProducto.Text = "Ingrese el nombre";
            // 
            // tbMarcaProducto
            // 
            tbMarcaProducto.Location = new Point(290, 63);
            tbMarcaProducto.Name = "tbMarcaProducto";
            tbMarcaProducto.Size = new Size(239, 23);
            tbMarcaProducto.TabIndex = 3;
            tbMarcaProducto.Text = "Ingrese la marca";
            // 
            // tbPrecioProducto
            // 
            tbPrecioProducto.Location = new Point(290, 161);
            tbPrecioProducto.Name = "tbPrecioProducto";
            tbPrecioProducto.Size = new Size(239, 23);
            tbPrecioProducto.TabIndex = 5;
            tbPrecioProducto.Text = "Ingrese el precio";
            // 
            // btRegistrarProducto
            // 
            btRegistrarProducto.BackColor = SystemColors.ActiveCaption;
            btRegistrarProducto.Location = new Point(211, 264);
            btRegistrarProducto.Name = "btRegistrarProducto";
            btRegistrarProducto.Size = new Size(140, 50);
            btRegistrarProducto.TabIndex = 6;
            btRegistrarProducto.Text = "REGISTRAR";
            btRegistrarProducto.UseVisualStyleBackColor = false;
            btRegistrarProducto.Click += btRegistrarProducto_Click;
            // 
            // tbCantidadProducto
            // 
            tbCantidadProducto.Location = new Point(290, 113);
            tbCantidadProducto.Name = "tbCantidadProducto";
            tbCantidadProducto.Size = new Size(239, 23);
            tbCantidadProducto.TabIndex = 4;
            tbCantidadProducto.Text = "Ingrese la cantidad";
            // 
            // tbIngreseProveedor
            // 
            tbIngreseProveedor.Location = new Point(25, 113);
            tbIngreseProveedor.Name = "tbIngreseProveedor";
            tbIngreseProveedor.Size = new Size(239, 23);
            tbIngreseProveedor.TabIndex = 8;
            tbIngreseProveedor.Text = "Ingrese el proveedor";
            // 
            // lbProductoRegistrado
            // 
            lbProductoRegistrado.AutoSize = true;
            lbProductoRegistrado.Location = new Point(25, 219);
            lbProductoRegistrado.Name = "lbProductoRegistrado";
            lbProductoRegistrado.Size = new Size(118, 15);
            lbProductoRegistrado.TabIndex = 9;
            lbProductoRegistrado.Text = "Producto registrado: ";
            lbProductoRegistrado.Click += lbProductoRegistrado_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 31;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 326);
            Controls.Add(btVolver);
            Controls.Add(lbProductoRegistrado);
            Controls.Add(tbIngreseProveedor);
            Controls.Add(btRegistrarProducto);
            Controls.Add(tbPrecioProducto);
            Controls.Add(tbCantidadProducto);
            Controls.Add(tbMarcaProducto);
            Controls.Add(tbNombreProducto);
            Controls.Add(tbReferenciaProducto);
            Controls.Add(lbTituloProducto);
            Name = "Producto";
            Text = "Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloProducto;
        private TextBox tbReferenciaProducto;
        private TextBox tbNombreProducto;
        private TextBox tbMarcaProducto;
        private TextBox tbPrecioProducto;
        private Button btRegistrarProducto;
        private TextBox tbCantidadProducto;
        private TextBox tbIngreseProveedor;
        private Label lbProductoRegistrado;
        private Button btVolver;
    }
}