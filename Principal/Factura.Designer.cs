namespace Principal
{
    partial class Fecha
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
            lbTituloFactura = new Label();
            lbIdArticulo = new Label();
            lbIdCliente = new Label();
            lbIdEmpleado = new Label();
            lbTotalFactura = new Label();
            lbFechaFactura = new Label();
            btBuscarFactura = new Button();
            btCargaralalistaFactura = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tbIdArticulo = new TextBox();
            tbTotal = new TextBox();
            tbIdEmpleado = new TextBox();
            tbIdCliente = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbTotalpagarFactura = new Label();
            panel1 = new Panel();
            tbEfectivoFactura = new TextBox();
            label4 = new Label();
            btVenderFactura = new Button();
            lbCantidadProductoFactura = new Label();
            tbCantidad = new TextBox();
            btVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloFactura
            // 
            lbTituloFactura.AutoSize = true;
            lbTituloFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloFactura.Location = new Point(259, 9);
            lbTituloFactura.Name = "lbTituloFactura";
            lbTituloFactura.Size = new Size(139, 32);
            lbTituloFactura.TabIndex = 0;
            lbTituloFactura.Text = "FACTURA";
            // 
            // lbIdArticulo
            // 
            lbIdArticulo.AutoSize = true;
            lbIdArticulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdArticulo.Location = new Point(22, 169);
            lbIdArticulo.Name = "lbIdArticulo";
            lbIdArticulo.Size = new Size(74, 17);
            lbIdArticulo.TabIndex = 1;
            lbIdArticulo.Text = "Id Articulo: ";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdCliente.Location = new Point(31, 100);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(65, 17);
            lbIdCliente.TabIndex = 2;
            lbIdCliente.Text = "Id Cliente:";
            // 
            // lbIdEmpleado
            // 
            lbIdEmpleado.AutoSize = true;
            lbIdEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdEmpleado.Location = new Point(11, 130);
            lbIdEmpleado.Name = "lbIdEmpleado";
            lbIdEmpleado.Size = new Size(85, 17);
            lbIdEmpleado.TabIndex = 3;
            lbIdEmpleado.Text = "Id Empleado:";
            // 
            // lbTotalFactura
            // 
            lbTotalFactura.AutoSize = true;
            lbTotalFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalFactura.Location = new Point(55, 252);
            lbTotalFactura.Name = "lbTotalFactura";
            lbTotalFactura.Size = new Size(39, 17);
            lbTotalFactura.TabIndex = 4;
            lbTotalFactura.Text = "Total:";
            // 
            // lbFechaFactura
            // 
            lbFechaFactura.AutoSize = true;
            lbFechaFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFechaFactura.Location = new Point(55, 64);
            lbFechaFactura.Name = "lbFechaFactura";
            lbFechaFactura.Size = new Size(41, 17);
            lbFechaFactura.TabIndex = 5;
            lbFechaFactura.Text = "Fecha";
            // 
            // btBuscarFactura
            // 
            btBuscarFactura.BackColor = SystemColors.ActiveCaption;
            btBuscarFactura.Location = new Point(299, 170);
            btBuscarFactura.Name = "btBuscarFactura";
            btBuscarFactura.Size = new Size(91, 22);
            btBuscarFactura.TabIndex = 6;
            btBuscarFactura.Text = "Buscar";
            btBuscarFactura.UseVisualStyleBackColor = false;
            btBuscarFactura.Click += btBuscarFactura_Click;
            // 
            // btCargaralalistaFactura
            // 
            btCargaralalistaFactura.BackColor = SystemColors.ActiveCaption;
            btCargaralalistaFactura.Location = new Point(133, 276);
            btCargaralalistaFactura.Name = "btCargaralalistaFactura";
            btCargaralalistaFactura.Size = new Size(110, 43);
            btCargaralalistaFactura.TabIndex = 7;
            btCargaralalistaFactura.Text = "Cargar a la lista";
            btCargaralalistaFactura.UseVisualStyleBackColor = false;
            btCargaralalistaFactura.Click += btCargaralalistaFactura_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(40, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 132);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del articulo";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio Unitario";
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "SubTotal";
            Column4.Name = "Column4";
            // 
            // tbIdArticulo
            // 
            tbIdArticulo.Location = new Point(113, 169);
            tbIdArticulo.Name = "tbIdArticulo";
            tbIdArticulo.Size = new Size(163, 23);
            tbIdArticulo.TabIndex = 10;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(113, 247);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(163, 23);
            tbTotal.TabIndex = 11;
            // 
            // tbIdEmpleado
            // 
            tbIdEmpleado.Location = new Point(113, 130);
            tbIdEmpleado.Name = "tbIdEmpleado";
            tbIdEmpleado.Size = new Size(163, 23);
            tbIdEmpleado.TabIndex = 12;
            // 
            // tbIdCliente
            // 
            tbIdCliente.Location = new Point(113, 94);
            tbIdCliente.Name = "tbIdCliente";
            tbIdCliente.Size = new Size(163, 23);
            tbIdCliente.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(113, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // lbTotalpagarFactura
            // 
            lbTotalpagarFactura.AutoSize = true;
            lbTotalpagarFactura.Font = new Font("Segoe UI", 10F);
            lbTotalpagarFactura.Location = new Point(18, 12);
            lbTotalpagarFactura.Name = "lbTotalpagarFactura";
            lbTotalpagarFactura.Size = new Size(88, 19);
            lbTotalpagarFactura.TabIndex = 15;
            lbTotalpagarFactura.Text = "Total a pagar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbTotalpagarFactura);
            panel1.Location = new Point(453, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 41);
            panel1.TabIndex = 20;
            // 
            // tbEfectivoFactura
            // 
            tbEfectivoFactura.Location = new Point(453, 201);
            tbEfectivoFactura.Name = "tbEfectivoFactura";
            tbEfectivoFactura.Size = new Size(124, 23);
            tbEfectivoFactura.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(489, 170);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 21;
            label4.Text = "Efectivo:";
            // 
            // btVenderFactura
            // 
            btVenderFactura.BackColor = SystemColors.ActiveCaption;
            btVenderFactura.Location = new Point(453, 233);
            btVenderFactura.Name = "btVenderFactura";
            btVenderFactura.Size = new Size(124, 40);
            btVenderFactura.TabIndex = 23;
            btVenderFactura.Text = "Vender";
            btVenderFactura.UseVisualStyleBackColor = false;
            btVenderFactura.Click += btVenderFactura_Click;
            // 
            // lbCantidadProductoFactura
            // 
            lbCantidadProductoFactura.AutoSize = true;
            lbCantidadProductoFactura.Location = new Point(38, 209);
            lbCantidadProductoFactura.Name = "lbCantidadProductoFactura";
            lbCantidadProductoFactura.Size = new Size(58, 15);
            lbCantidadProductoFactura.TabIndex = 24;
            lbCantidadProductoFactura.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(113, 209);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(163, 23);
            tbCantidad.TabIndex = 25;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 35;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // Fecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 483);
            Controls.Add(btVolver);
            Controls.Add(tbCantidad);
            Controls.Add(lbCantidadProductoFactura);
            Controls.Add(btVenderFactura);
            Controls.Add(tbEfectivoFactura);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbIdCliente);
            Controls.Add(tbIdEmpleado);
            Controls.Add(tbTotal);
            Controls.Add(tbIdArticulo);
            Controls.Add(dataGridView1);
            Controls.Add(btCargaralalistaFactura);
            Controls.Add(btBuscarFactura);
            Controls.Add(lbFechaFactura);
            Controls.Add(lbTotalFactura);
            Controls.Add(lbIdEmpleado);
            Controls.Add(lbIdCliente);
            Controls.Add(lbIdArticulo);
            Controls.Add(lbTituloFactura);
            Name = "Fecha";
            Text = "Fecha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloFactura;
        private Label lbIdArticulo;
        private Label lbIdCliente;
        private Label lbIdEmpleado;
        private Label lbTotalFactura;
        private Label lbFechaFactura;
        private Button btBuscarFactura;
        private Button btCargaralalistaFactura;
        private DataGridView dataGridView1;
        private TextBox tbIdArticulo;
        private TextBox tbTotal;
        private TextBox tbIdEmpleado;
        private TextBox tbIdCliente;
        private DateTimePicker dateTimePicker1;
        private Label lbTotalpagarFactura;
        private Panel panel1;
        private TextBox tbEfectivoFactura;
        private Label label4;
        private Button btVenderFactura;
        private Label lbCantidadProductoFactura;
        private TextBox tbCantidad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btVolver;
    }
}