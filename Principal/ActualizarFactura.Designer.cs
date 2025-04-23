namespace Principal
{
    partial class ActualizarFactura
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
            tbCantidadProductoActualizar = new TextBox();
            lbCantidadProductoFacturaActualizar = new Label();
            btVenderFacturaActualizar = new Button();
            tbEfectivoFacturaActualizar = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            lbTotalpagarFacturaActualizar = new Label();
            dateTimePicker1 = new DateTimePicker();
            tbIdClienteActualizar = new TextBox();
            tbIdEmpleadoActualizar = new TextBox();
            tbTotalActualizar = new TextBox();
            tbIdArticuloActualizar = new TextBox();
            dataGridView1 = new DataGridView();
            btCargaralalistaFacturaActualizar = new Button();
            lbActualizarFechaFactura = new Label();
            lbTotalFacturaActualizar = new Label();
            lbIdEmpleadoActualizar = new Label();
            lbIdClienteActualizar = new Label();
            lbIdArticuloActualizar = new Label();
            lbTituloActualizarFactura = new Label();
            lbIdFacturaActualizar = new Label();
            tbIdFacturaActualizar = new TextBox();
            btBuscarIdFactura = new Button();
            NombreDelArticulo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 56;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // tbCantidadProductoActualizar
            // 
            tbCantidadProductoActualizar.Location = new Point(106, 268);
            tbCantidadProductoActualizar.Name = "tbCantidadProductoActualizar";
            tbCantidadProductoActualizar.Size = new Size(163, 23);
            tbCantidadProductoActualizar.TabIndex = 55;
            // 
            // lbCantidadProductoFacturaActualizar
            // 
            lbCantidadProductoFacturaActualizar.AutoSize = true;
            lbCantidadProductoFacturaActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCantidadProductoFacturaActualizar.Location = new Point(24, 269);
            lbCantidadProductoFacturaActualizar.Name = "lbCantidadProductoFacturaActualizar";
            lbCantidadProductoFacturaActualizar.Size = new Size(63, 17);
            lbCantidadProductoFacturaActualizar.TabIndex = 54;
            lbCantidadProductoFacturaActualizar.Text = "Cantidad:";
            // 
            // btVenderFacturaActualizar
            // 
            btVenderFacturaActualizar.BackColor = SystemColors.ActiveCaption;
            btVenderFacturaActualizar.Location = new Point(446, 292);
            btVenderFacturaActualizar.Name = "btVenderFacturaActualizar";
            btVenderFacturaActualizar.Size = new Size(124, 40);
            btVenderFacturaActualizar.TabIndex = 53;
            btVenderFacturaActualizar.Text = "ACTUALIZAR";
            btVenderFacturaActualizar.UseVisualStyleBackColor = false;
            btVenderFacturaActualizar.Click += btVenderFacturaActualizar_Click;
            // 
            // tbEfectivoFacturaActualizar
            // 
            tbEfectivoFacturaActualizar.Location = new Point(446, 260);
            tbEfectivoFacturaActualizar.Name = "tbEfectivoFacturaActualizar";
            tbEfectivoFacturaActualizar.Size = new Size(124, 23);
            tbEfectivoFacturaActualizar.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(482, 229);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 51;
            label4.Text = "Efectivo:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbTotalpagarFacturaActualizar);
            panel1.Location = new Point(446, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 41);
            panel1.TabIndex = 50;
            // 
            // lbTotalpagarFacturaActualizar
            // 
            lbTotalpagarFacturaActualizar.AutoSize = true;
            lbTotalpagarFacturaActualizar.Font = new Font("Segoe UI", 10F);
            lbTotalpagarFacturaActualizar.Location = new Point(18, 12);
            lbTotalpagarFacturaActualizar.Name = "lbTotalpagarFacturaActualizar";
            lbTotalpagarFacturaActualizar.Size = new Size(88, 19);
            lbTotalpagarFacturaActualizar.TabIndex = 15;
            lbTotalpagarFacturaActualizar.Text = "Total a pagar";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(106, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 49;
            // 
            // tbIdClienteActualizar
            // 
            tbIdClienteActualizar.Location = new Point(106, 153);
            tbIdClienteActualizar.Name = "tbIdClienteActualizar";
            tbIdClienteActualizar.Size = new Size(163, 23);
            tbIdClienteActualizar.TabIndex = 48;
            // 
            // tbIdEmpleadoActualizar
            // 
            tbIdEmpleadoActualizar.Location = new Point(106, 189);
            tbIdEmpleadoActualizar.Name = "tbIdEmpleadoActualizar";
            tbIdEmpleadoActualizar.Size = new Size(163, 23);
            tbIdEmpleadoActualizar.TabIndex = 47;
            // 
            // tbTotalActualizar
            // 
            tbTotalActualizar.Location = new Point(106, 306);
            tbTotalActualizar.Name = "tbTotalActualizar";
            tbTotalActualizar.Size = new Size(163, 23);
            tbTotalActualizar.TabIndex = 46;
            // 
            // tbIdArticuloActualizar
            // 
            tbIdArticuloActualizar.Location = new Point(106, 228);
            tbIdArticuloActualizar.Name = "tbIdArticuloActualizar";
            tbIdArticuloActualizar.Size = new Size(163, 23);
            tbIdArticuloActualizar.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombreDelArticulo, Cantidad, Column3, SubTotal });
            dataGridView1.Location = new Point(42, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 77);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // btCargaralalistaFacturaActualizar
            // 
            btCargaralalistaFacturaActualizar.BackColor = SystemColors.ActiveCaption;
            btCargaralalistaFacturaActualizar.Location = new Point(126, 335);
            btCargaralalistaFacturaActualizar.Name = "btCargaralalistaFacturaActualizar";
            btCargaralalistaFacturaActualizar.Size = new Size(110, 43);
            btCargaralalistaFacturaActualizar.TabIndex = 43;
            btCargaralalistaFacturaActualizar.Text = "Cargar a la lista";
            btCargaralalistaFacturaActualizar.UseVisualStyleBackColor = false;
            btCargaralalistaFacturaActualizar.Click += btCargaralalistaFacturaActualizar_Click;
            // 
            // lbActualizarFechaFactura
            // 
            lbActualizarFechaFactura.AutoSize = true;
            lbActualizarFechaFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbActualizarFechaFactura.Location = new Point(43, 119);
            lbActualizarFechaFactura.Name = "lbActualizarFechaFactura";
            lbActualizarFechaFactura.Size = new Size(44, 17);
            lbActualizarFechaFactura.TabIndex = 41;
            lbActualizarFechaFactura.Text = "Fecha:";
            // 
            // lbTotalFacturaActualizar
            // 
            lbTotalFacturaActualizar.AutoSize = true;
            lbTotalFacturaActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalFacturaActualizar.Location = new Point(48, 311);
            lbTotalFacturaActualizar.Name = "lbTotalFacturaActualizar";
            lbTotalFacturaActualizar.Size = new Size(39, 17);
            lbTotalFacturaActualizar.TabIndex = 40;
            lbTotalFacturaActualizar.Text = "Total:";
            // 
            // lbIdEmpleadoActualizar
            // 
            lbIdEmpleadoActualizar.AutoSize = true;
            lbIdEmpleadoActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdEmpleadoActualizar.Location = new Point(2, 189);
            lbIdEmpleadoActualizar.Name = "lbIdEmpleadoActualizar";
            lbIdEmpleadoActualizar.Size = new Size(85, 17);
            lbIdEmpleadoActualizar.TabIndex = 39;
            lbIdEmpleadoActualizar.Text = "Id Empleado:";
            // 
            // lbIdClienteActualizar
            // 
            lbIdClienteActualizar.AutoSize = true;
            lbIdClienteActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdClienteActualizar.Location = new Point(22, 159);
            lbIdClienteActualizar.Name = "lbIdClienteActualizar";
            lbIdClienteActualizar.Size = new Size(65, 17);
            lbIdClienteActualizar.TabIndex = 38;
            lbIdClienteActualizar.Text = "Id Cliente:";
            // 
            // lbIdArticuloActualizar
            // 
            lbIdArticuloActualizar.AutoSize = true;
            lbIdArticuloActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdArticuloActualizar.Location = new Point(17, 229);
            lbIdArticuloActualizar.Name = "lbIdArticuloActualizar";
            lbIdArticuloActualizar.Size = new Size(70, 17);
            lbIdArticuloActualizar.TabIndex = 37;
            lbIdArticuloActualizar.Text = "Id Articulo:";
            // 
            // lbTituloActualizarFactura
            // 
            lbTituloActualizarFactura.AutoSize = true;
            lbTituloActualizarFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarFactura.Location = new Point(135, 24);
            lbTituloActualizarFactura.Name = "lbTituloActualizarFactura";
            lbTituloActualizarFactura.Size = new Size(316, 32);
            lbTituloActualizarFactura.TabIndex = 36;
            lbTituloActualizarFactura.Text = "ACTUALIZAR FACTURA";
            // 
            // lbIdFacturaActualizar
            // 
            lbIdFacturaActualizar.AutoSize = true;
            lbIdFacturaActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdFacturaActualizar.Location = new Point(19, 82);
            lbIdFacturaActualizar.Name = "lbIdFacturaActualizar";
            lbIdFacturaActualizar.Size = new Size(68, 17);
            lbIdFacturaActualizar.TabIndex = 57;
            lbIdFacturaActualizar.Text = "Id Factura:";
            // 
            // tbIdFacturaActualizar
            // 
            tbIdFacturaActualizar.Location = new Point(106, 81);
            tbIdFacturaActualizar.Name = "tbIdFacturaActualizar";
            tbIdFacturaActualizar.Size = new Size(163, 23);
            tbIdFacturaActualizar.TabIndex = 58;
            // 
            // btBuscarIdFactura
            // 
            btBuscarIdFactura.BackColor = SystemColors.ActiveCaption;
            btBuscarIdFactura.Location = new Point(292, 83);
            btBuscarIdFactura.Name = "btBuscarIdFactura";
            btBuscarIdFactura.Size = new Size(91, 21);
            btBuscarIdFactura.TabIndex = 59;
            btBuscarIdFactura.Text = "Buscar";
            btBuscarIdFactura.UseVisualStyleBackColor = false;
            btBuscarIdFactura.Click += btBuscarIdFactura_Click;
            // 
            // NombreDelArticulo
            // 
            NombreDelArticulo.HeaderText = "Nombre del articulo";
            NombreDelArticulo.Name = "NombreDelArticulo";
            NombreDelArticulo.Width = 150;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Unitario";
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            // 
            // ActualizarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 493);
            Controls.Add(btBuscarIdFactura);
            Controls.Add(tbIdFacturaActualizar);
            Controls.Add(lbIdFacturaActualizar);
            Controls.Add(btVolver);
            Controls.Add(tbCantidadProductoActualizar);
            Controls.Add(lbCantidadProductoFacturaActualizar);
            Controls.Add(btVenderFacturaActualizar);
            Controls.Add(tbEfectivoFacturaActualizar);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbIdClienteActualizar);
            Controls.Add(tbIdEmpleadoActualizar);
            Controls.Add(tbTotalActualizar);
            Controls.Add(tbIdArticuloActualizar);
            Controls.Add(dataGridView1);
            Controls.Add(btCargaralalistaFacturaActualizar);
            Controls.Add(lbActualizarFechaFactura);
            Controls.Add(lbTotalFacturaActualizar);
            Controls.Add(lbIdEmpleadoActualizar);
            Controls.Add(lbIdClienteActualizar);
            Controls.Add(lbIdArticuloActualizar);
            Controls.Add(lbTituloActualizarFactura);
            Name = "ActualizarFactura";
            Text = "ActualizarFactura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private TextBox tbCantidadProductoActualizar;
        private Label lbCantidadProductoFacturaActualizar;
        private Button btVenderFacturaActualizar;
        private TextBox tbEfectivoFacturaActualizar;
        private Label label4;
        private Panel panel1;
        private Label lbTotalpagarFacturaActualizar;
        private DateTimePicker dateTimePicker1;
        private TextBox tbIdClienteActualizar;
        private TextBox tbIdEmpleadoActualizar;
        private TextBox tbTotalActualizar;
        private TextBox tbIdArticuloActualizar;
        private DataGridView dataGridView1;
        private Button btCargaralalistaFacturaActualizar;
        private Label lbActualizarFechaFactura;
        private Label lbTotalFacturaActualizar;
        private Label lbIdEmpleadoActualizar;
        private Label lbIdClienteActualizar;
        private Label lbIdArticuloActualizar;
        private Label lbTituloActualizarFactura;
        private Label lbIdFacturaActualizar;
        private TextBox tbIdFacturaActualizar;
        private Button btBuscarIdFactura;
        private DataGridViewTextBoxColumn NombreDelArticulo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn SubTotal;
    }
}