namespace Principal
{
    partial class ConsultarProductoProveedor
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
            lbMostrarProductoProveedor = new Label();
            btConsultarProductoProveedor = new Button();
            tbIdentificadorProductoProveedor = new TextBox();
            lbTituloConsultarProductos = new Label();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 38;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // lbMostrarProductoProveedor
            // 
            lbMostrarProductoProveedor.AutoSize = true;
            lbMostrarProductoProveedor.Location = new Point(60, 144);
            lbMostrarProductoProveedor.Name = "lbMostrarProductoProveedor";
            lbMostrarProductoProveedor.Size = new Size(59, 15);
            lbMostrarProductoProveedor.TabIndex = 37;
            lbMostrarProductoProveedor.Text = "Producto:";
            lbMostrarProductoProveedor.Click += lbMostrarProductoProveedor_Click;
            // 
            // btConsultarProductoProveedor
            // 
            btConsultarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btConsultarProductoProveedor.Location = new Point(118, 251);
            btConsultarProductoProveedor.Name = "btConsultarProductoProveedor";
            btConsultarProductoProveedor.Size = new Size(127, 46);
            btConsultarProductoProveedor.TabIndex = 36;
            btConsultarProductoProveedor.Text = "CONSULTAR";
            btConsultarProductoProveedor.UseVisualStyleBackColor = false;
            btConsultarProductoProveedor.Click += btConsultarProductoProveedor_Click;
            // 
            // tbIdentificadorProductoProveedor
            // 
            tbIdentificadorProductoProveedor.Location = new Point(60, 99);
            tbIdentificadorProductoProveedor.Name = "tbIdentificadorProductoProveedor";
            tbIdentificadorProductoProveedor.Size = new Size(241, 23);
            tbIdentificadorProductoProveedor.TabIndex = 35;
            tbIdentificadorProductoProveedor.Text = "Ingresar Identificador";
            tbIdentificadorProductoProveedor.TextChanged += tbIdentificadorProductoProveedor_TextChanged;
            // 
            // lbTituloConsultarProductos
            // 
            lbTituloConsultarProductos.AutoSize = true;
            lbTituloConsultarProductos.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarProductos.Location = new Point(26, 39);
            lbTituloConsultarProductos.Name = "lbTituloConsultarProductos";
            lbTituloConsultarProductos.Size = new Size(327, 32);
            lbTituloConsultarProductos.TabIndex = 34;
            lbTituloConsultarProductos.Text = "CONSULTAR PRODUCTO";
            // 
            // ConsultarProductoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 309);
            Controls.Add(btVolver);
            Controls.Add(lbMostrarProductoProveedor);
            Controls.Add(btConsultarProductoProveedor);
            Controls.Add(tbIdentificadorProductoProveedor);
            Controls.Add(lbTituloConsultarProductos);
            Name = "ConsultarProductoProveedor";
            Text = "ConsultarProductoProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Label lbMostrarProductoProveedor;
        private Button btConsultarProductoProveedor;
        private TextBox tbIdentificadorProductoProveedor;
        private Label lbTituloConsultarProductos;
    }
}