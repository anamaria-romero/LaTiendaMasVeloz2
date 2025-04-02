namespace Principal
{
    partial class ActualizarProducto
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
            btActualizarProducto = new Button();
            tbActualizaPrecioProducto = new TextBox();
            tbActualizaCantidadProducto = new TextBox();
            tbActualizaMarcaProducto = new TextBox();
            tbActualizarNombreProducto = new TextBox();
            tbActualizarReferenciaProducto = new TextBox();
            lbTituloActualizarProducto = new Label();
            tbActualizarProveedor = new TextBox();
            tbIdentificadorProducto = new TextBox();
            btBuscar = new Button();
            SuspendLayout();
            // 
            // btActualizarProducto
            // 
            btActualizarProducto.BackColor = SystemColors.ActiveCaption;
            btActualizarProducto.Location = new Point(355, 352);
            btActualizarProducto.Name = "btActualizarProducto";
            btActualizarProducto.Size = new Size(140, 50);
            btActualizarProducto.TabIndex = 14;
            btActualizarProducto.Text = "ACTUALIZAR";
            btActualizarProducto.UseVisualStyleBackColor = false;
            btActualizarProducto.Click += btActualizarProducto_Click;
            // 
            // tbActualizaPrecioProducto
            // 
            tbActualizaPrecioProducto.Location = new Point(276, 310);
            tbActualizaPrecioProducto.Name = "tbActualizaPrecioProducto";
            tbActualizaPrecioProducto.Size = new Size(302, 23);
            tbActualizaPrecioProducto.TabIndex = 13;
            tbActualizaPrecioProducto.Text = "Actualiza el precio";
            // 
            // tbActualizaCantidadProducto
            // 
            tbActualizaCantidadProducto.Location = new Point(276, 261);
            tbActualizaCantidadProducto.Name = "tbActualizaCantidadProducto";
            tbActualizaCantidadProducto.Size = new Size(302, 23);
            tbActualizaCantidadProducto.TabIndex = 12;
            tbActualizaCantidadProducto.Text = "Actualiza la cantidad";
            // 
            // tbActualizaMarcaProducto
            // 
            tbActualizaMarcaProducto.Location = new Point(276, 212);
            tbActualizaMarcaProducto.Name = "tbActualizaMarcaProducto";
            tbActualizaMarcaProducto.Size = new Size(302, 23);
            tbActualizaMarcaProducto.TabIndex = 11;
            tbActualizaMarcaProducto.Text = "Actualiza la marca";
            // 
            // tbActualizarNombreProducto
            // 
            tbActualizarNombreProducto.Location = new Point(276, 162);
            tbActualizarNombreProducto.Name = "tbActualizarNombreProducto";
            tbActualizarNombreProducto.Size = new Size(302, 23);
            tbActualizarNombreProducto.TabIndex = 10;
            tbActualizarNombreProducto.Text = "Actualiza el nombre";
            // 
            // tbActualizarReferenciaProducto
            // 
            tbActualizarReferenciaProducto.Location = new Point(276, 64);
            tbActualizarReferenciaProducto.Name = "tbActualizarReferenciaProducto";
            tbActualizarReferenciaProducto.Size = new Size(302, 23);
            tbActualizarReferenciaProducto.TabIndex = 9;
            tbActualizarReferenciaProducto.Text = "Actualiza la referencia";
            // 
            // lbTituloActualizarProducto
            // 
            lbTituloActualizarProducto.AutoSize = true;
            lbTituloActualizarProducto.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProducto.Location = new Point(132, 9);
            lbTituloActualizarProducto.Name = "lbTituloActualizarProducto";
            lbTituloActualizarProducto.Size = new Size(337, 32);
            lbTituloActualizarProducto.TabIndex = 8;
            lbTituloActualizarProducto.Text = "ACTUALIZAR PRODUCTO";
            // 
            // tbActualizarProveedor
            // 
            tbActualizarProveedor.Location = new Point(276, 114);
            tbActualizarProveedor.Name = "tbActualizarProveedor";
            tbActualizarProveedor.Size = new Size(302, 23);
            tbActualizarProveedor.TabIndex = 16;
            tbActualizarProveedor.Text = "Actualiza el proveedor";
            // 
            // tbIdentificadorProducto
            // 
            tbIdentificadorProducto.Location = new Point(56, 64);
            tbIdentificadorProducto.Name = "tbIdentificadorProducto";
            tbIdentificadorProducto.Size = new Size(184, 23);
            tbIdentificadorProducto.TabIndex = 15;
            tbIdentificadorProducto.Text = "Ingrese el identificador";
            // 
            // btBuscar
            // 
            btBuscar.BackColor = SystemColors.ActiveCaption;
            btBuscar.Location = new Point(70, 130);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(142, 55);
            btBuscar.TabIndex = 17;
            btBuscar.Text = "BUSCAR";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // ActualizarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 498);
            Controls.Add(btBuscar);
            Controls.Add(tbActualizarProveedor);
            Controls.Add(tbIdentificadorProducto);
            Controls.Add(btActualizarProducto);
            Controls.Add(tbActualizaPrecioProducto);
            Controls.Add(tbActualizaCantidadProducto);
            Controls.Add(tbActualizaMarcaProducto);
            Controls.Add(tbActualizarNombreProducto);
            Controls.Add(tbActualizarReferenciaProducto);
            Controls.Add(lbTituloActualizarProducto);
            Name = "ActualizarProducto";
            Text = "ActualizarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btActualizarProducto;
        private TextBox tbActualizaPrecioProducto;
        private TextBox tbActualizaCantidadProducto;
        private TextBox tbActualizaMarcaProducto;
        private TextBox tbActualizarNombreProducto;
        private TextBox tbActualizarReferenciaProducto;
        private Label lbTituloActualizarProducto;
        private TextBox tbActualizarProveedor;
        private TextBox tbIdentificadorProducto;
        private Button btBuscar;
    }
}