namespace Principal
{
    partial class EliminarProductoProveedor
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
            btEliminarProductoProveedor = new Button();
            lbMostrarProductoProveedor = new Label();
            tbIdentificadorProductoProveedor = new TextBox();
            lbEliminarProductos = new Label();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 37;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // btEliminarProductoProveedor
            // 
            btEliminarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btEliminarProductoProveedor.Location = new Point(109, 214);
            btEliminarProductoProveedor.Name = "btEliminarProductoProveedor";
            btEliminarProductoProveedor.Size = new Size(141, 50);
            btEliminarProductoProveedor.TabIndex = 36;
            btEliminarProductoProveedor.Text = "ELIMINAR";
            btEliminarProductoProveedor.UseVisualStyleBackColor = false;
            btEliminarProductoProveedor.Click += btEliminarProductoProveedor_Click;
            // 
            // lbMostrarProductoProveedor
            // 
            lbMostrarProductoProveedor.AutoSize = true;
            lbMostrarProductoProveedor.Location = new Point(43, 136);
            lbMostrarProductoProveedor.Name = "lbMostrarProductoProveedor";
            lbMostrarProductoProveedor.Size = new Size(59, 15);
            lbMostrarProductoProveedor.TabIndex = 35;
            lbMostrarProductoProveedor.Text = "Producto:";
            lbMostrarProductoProveedor.Click += lbMostrarProductoProveedor_Click;
            // 
            // tbIdentificadorProductoProveedor
            // 
            tbIdentificadorProductoProveedor.Location = new Point(43, 94);
            tbIdentificadorProductoProveedor.Name = "tbIdentificadorProductoProveedor";
            tbIdentificadorProductoProveedor.Size = new Size(286, 23);
            tbIdentificadorProductoProveedor.TabIndex = 34;
            tbIdentificadorProductoProveedor.Text = "Ingresa el identificador";
            tbIdentificadorProductoProveedor.TextChanged += tbIdentificadorProductoProveedor_TextChanged;
            // 
            // lbEliminarProductos
            // 
            lbEliminarProductos.AutoSize = true;
            lbEliminarProductos.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarProductos.Location = new Point(43, 50);
            lbEliminarProductos.Name = "lbEliminarProductos";
            lbEliminarProductos.Size = new Size(303, 32);
            lbEliminarProductos.TabIndex = 33;
            lbEliminarProductos.Text = "Eliminar Producto";
            // 
            // EliminarProductoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 276);
            Controls.Add(btVolver);
            Controls.Add(btEliminarProductoProveedor);
            Controls.Add(lbMostrarProductoProveedor);
            Controls.Add(tbIdentificadorProductoProveedor);
            Controls.Add(lbEliminarProductos);
            Name = "EliminarProductoProveedor";
            Text = "EliminarProductoProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Button btEliminarProductoProveedor;
        private Label lbMostrarProductoProveedor;
        private TextBox tbIdentificadorProductoProveedor;
        private Label lbEliminarProductos;
    }
}