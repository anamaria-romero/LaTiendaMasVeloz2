namespace Principal
{
    partial class RegistrarIngreso
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
            lbTituloProveedor = new Label();
            lbProducto = new Label();
            lbProveedor = new Label();
            lbFechaIngreso = new Label();
            lbPrecio = new Label();
            lbCantidad = new Label();
            tbIdProducto = new TextBox();
            tbIdProveedor = new TextBox();
            tb = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btRegistrar = new Button();
            SuspendLayout();
            // 
            // lbTituloProveedor
            // 
            lbTituloProveedor.AutoSize = true;
            lbTituloProveedor.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloProveedor.Location = new Point(9, 45);
            lbTituloProveedor.Name = "lbTituloProveedor";
            lbTituloProveedor.Size = new Size(440, 29);
            lbTituloProveedor.TabIndex = 1;
            lbTituloProveedor.Text = "REGISTRO PRODUCTO - PROVEEDOR";
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.Location = new Point(9, 129);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(72, 15);
            lbProducto.TabIndex = 2;
            lbProducto.Text = "Id producto:";
            // 
            // lbProveedor
            // 
            lbProveedor.AutoSize = true;
            lbProveedor.Location = new Point(9, 153);
            lbProveedor.Name = "lbProveedor";
            lbProveedor.Size = new Size(77, 15);
            lbProveedor.TabIndex = 3;
            lbProveedor.Text = "Id Proveedor:";
            // 
            // lbFechaIngreso
            // 
            lbFechaIngreso.AutoSize = true;
            lbFechaIngreso.Location = new Point(9, 100);
            lbFechaIngreso.Name = "lbFechaIngreso";
            lbFechaIngreso.Size = new Size(83, 15);
            lbFechaIngreso.TabIndex = 4;
            lbFechaIngreso.Text = "Fecha ingreso:";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(9, 182);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(43, 15);
            lbPrecio.TabIndex = 5;
            lbPrecio.Text = "Precio:";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(9, 211);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(58, 15);
            lbCantidad.TabIndex = 6;
            lbCantidad.Text = "Cantidad:";
            // 
            // tbIdProducto
            // 
            tbIdProducto.Location = new Point(105, 121);
            tbIdProducto.Name = "tbIdProducto";
            tbIdProducto.Size = new Size(174, 23);
            tbIdProducto.TabIndex = 7;
            // 
            // tbIdProveedor
            // 
            tbIdProveedor.Location = new Point(105, 150);
            tbIdProveedor.Name = "tbIdProveedor";
            tbIdProveedor.Size = new Size(174, 23);
            tbIdProveedor.TabIndex = 8;
            // 
            // tb
            // 
            tb.Location = new Point(105, 179);
            tb.Name = "tb";
            tb.Size = new Size(174, 23);
            tb.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(105, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = SystemColors.ActiveCaption;
            btRegistrar.Location = new Point(144, 262);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(155, 44);
            btRegistrar.TabIndex = 12;
            btRegistrar.Text = "REGISTRAR INGRESO";
            btRegistrar.UseVisualStyleBackColor = false;
            // 
            // RegistrarIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 318);
            Controls.Add(btRegistrar);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(tb);
            Controls.Add(tbIdProveedor);
            Controls.Add(tbIdProducto);
            Controls.Add(lbCantidad);
            Controls.Add(lbPrecio);
            Controls.Add(lbFechaIngreso);
            Controls.Add(lbProveedor);
            Controls.Add(lbProducto);
            Controls.Add(lbTituloProveedor);
            Name = "RegistrarIngreso";
            Text = "RegistrarIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloProveedor;
        private Label lbProducto;
        private Label lbProveedor;
        private Label lbFechaIngreso;
        private Label lbPrecio;
        private Label lbCantidad;
        private TextBox tbIdProducto;
        private TextBox tbIdProveedor;
        private TextBox tb;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btRegistrar;
    }
}