namespace Principal
{
    partial class ActualizarProductoProveedor
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
            btVolver = new Button();
            lbProductoProveedorActualizado = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            btBuscarProductoProveedor = new Button();
            tbIdentificadorProductoProveedor = new TextBox();
            tbActualizaCantidadProductoProveedor = new TextBox();
            tbActualizarIdProductoProveedor = new TextBox();
            lbTituloActualizarProducto = new Label();
            tbActualizarPrecioProductoProveedor = new TextBox();
            btActualizarProductoProveedor = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 52;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // lbProductoProveedorActualizado
            // 
            lbProductoProveedorActualizado.AutoSize = true;
            lbProductoProveedorActualizado.Location = new Point(314, 214);
            lbProductoProveedorActualizado.Name = "lbProductoProveedorActualizado";
            lbProductoProveedorActualizado.Size = new Size(124, 15);
            lbProductoProveedorActualizado.TabIndex = 51;
            lbProductoProveedorActualizado.Text = "Producto Actualizado:";
            lbProductoProveedorActualizado.Click += lbProductoProveedorActualizado_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 138);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 50;
            label6.Text = "Actualiza el precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 236);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 49;
            label5.Text = "Actualiza la cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 159);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 45;
            label1.Text = "Actualiza id del proveedor:";
            // 
            // btBuscarProductoProveedor
            // 
            btBuscarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btBuscarProductoProveedor.Location = new Point(96, 106);
            btBuscarProductoProveedor.Name = "btBuscarProductoProveedor";
            btBuscarProductoProveedor.Size = new Size(121, 34);
            btBuscarProductoProveedor.TabIndex = 44;
            btBuscarProductoProveedor.Text = "BUSCAR";
            btBuscarProductoProveedor.UseVisualStyleBackColor = false;
            btBuscarProductoProveedor.Click += btBuscarProductoProveedor_Click;
            // 
            // tbIdentificadorProductoProveedor
            // 
            tbIdentificadorProductoProveedor.Location = new Point(43, 66);
            tbIdentificadorProductoProveedor.Name = "tbIdentificadorProductoProveedor";
            tbIdentificadorProductoProveedor.Size = new Size(236, 23);
            tbIdentificadorProductoProveedor.TabIndex = 42;
            tbIdentificadorProductoProveedor.Text = "Ingrese el identificador";
            tbIdentificadorProductoProveedor.TextChanged += tbIdentificadorProductoProveedor_TextChanged;
            // 
            // tbActualizaCantidadProductoProveedor
            // 
            tbActualizaCantidadProductoProveedor.Location = new Point(43, 263);
            tbActualizaCantidadProductoProveedor.Name = "tbActualizaCantidadProductoProveedor";
            tbActualizaCantidadProductoProveedor.Size = new Size(236, 23);
            tbActualizaCantidadProductoProveedor.TabIndex = 39;
            tbActualizaCantidadProductoProveedor.TextChanged += tbActualizaCantidadProductoProveedor_TextChanged;
            // 
            // tbActualizarIdProductoProveedor
            // 
            tbActualizarIdProductoProveedor.Location = new Point(43, 187);
            tbActualizarIdProductoProveedor.Name = "tbActualizarIdProductoProveedor";
            tbActualizarIdProductoProveedor.Size = new Size(236, 23);
            tbActualizarIdProductoProveedor.TabIndex = 36;
            tbActualizarIdProductoProveedor.TextChanged += tbActualizarIdProductoProveedor_TextChanged;
            // 
            // lbTituloActualizarProducto
            // 
            lbTituloActualizarProducto.AutoSize = true;
            lbTituloActualizarProducto.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProducto.Location = new Point(80, 20);
            lbTituloActualizarProducto.Name = "lbTituloActualizarProducto";
            lbTituloActualizarProducto.Size = new Size(469, 29);
            lbTituloActualizarProducto.TabIndex = 35;
            lbTituloActualizarProducto.Text = "ACTUALIZAR PRODUCTO - PROVEEDOR";
            // 
            // tbActualizarPrecioProductoProveedor
            // 
            tbActualizarPrecioProductoProveedor.Location = new Point(313, 165);
            tbActualizarPrecioProductoProveedor.Name = "tbActualizarPrecioProductoProveedor";
            tbActualizarPrecioProductoProveedor.Size = new Size(236, 23);
            tbActualizarPrecioProductoProveedor.TabIndex = 53;
            tbActualizarPrecioProductoProveedor.TextChanged += tbActualizarPrecioProductoProveedor_TextChanged;
            // 
            // btActualizarProductoProveedor
            // 
            btActualizarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btActualizarProductoProveedor.Location = new Point(215, 309);
            btActualizarProductoProveedor.Name = "btActualizarProductoProveedor";
            btActualizarProductoProveedor.Size = new Size(159, 54);
            btActualizarProductoProveedor.TabIndex = 54;
            btActualizarProductoProveedor.Text = "ACTUALIZAR";
            btActualizarProductoProveedor.UseVisualStyleBackColor = false;
            btActualizarProductoProveedor.Click += btActualizarProductoProveedor_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(314, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 23);
            dateTimePicker1.TabIndex = 55;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 69);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 56;
            label3.Text = "Actualizar Fecha:";
            // 
            // ActualizarProductoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 372);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(btActualizarProductoProveedor);
            Controls.Add(tbActualizarPrecioProductoProveedor);
            Controls.Add(btVolver);
            Controls.Add(lbProductoProveedorActualizado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btBuscarProductoProveedor);
            Controls.Add(tbIdentificadorProductoProveedor);
            Controls.Add(tbActualizaCantidadProductoProveedor);
            Controls.Add(tbActualizarIdProductoProveedor);
            Controls.Add(lbTituloActualizarProducto);
            Name = "ActualizarProductoProveedor";
            Text = "ActualizarProductoProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Label lbProductoProveedorActualizado;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btBuscarProductoProveedor;
        private TextBox tbActualizarProveedor;
        private TextBox tbIdentificadorProductoProveedor;
        private Button btActualizarProducto;
        private TextBox tbActualizaPrecioProducto;
        private TextBox tbActualizaCantidadProductoProveedor;
        private TextBox tbActualizaMarcaProducto;
        private TextBox tbActualizarIdProductoProveedor;
        private Label lbTituloActualizarProducto;
        private TextBox tbActualizarPrecioProductoProveedor;
        private Button btActualizarProductoProveedor;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}