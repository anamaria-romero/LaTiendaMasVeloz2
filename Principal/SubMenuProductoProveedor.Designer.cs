namespace Principal
{
    partial class SubMenuProductoProveedor
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
            btSubMenuEliminarProductoProveedor = new Button();
            btSubMenuConsultarProductoProveedor = new Button();
            btSubMenuActualizarProductoProveedor = new Button();
            btSubMenuRegistrarProductoProveedor = new Button();
            lbTituloSubMenuProductoProveedor = new Label();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 16;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // btSubMenuEliminarProductoProveedor
            // 
            btSubMenuEliminarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarProductoProveedor.Location = new Point(209, 185);
            btSubMenuEliminarProductoProveedor.Name = "btSubMenuEliminarProductoProveedor";
            btSubMenuEliminarProductoProveedor.Size = new Size(116, 53);
            btSubMenuEliminarProductoProveedor.TabIndex = 15;
            btSubMenuEliminarProductoProveedor.Text = "Eliminar Producto";
            btSubMenuEliminarProductoProveedor.UseVisualStyleBackColor = false;
            btSubMenuEliminarProductoProveedor.Click += btSubMenuEliminarProductoProveedor_Click;
            // 
            // btSubMenuConsultarProductoProveedor
            // 
            btSubMenuConsultarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarProductoProveedor.Location = new Point(67, 185);
            btSubMenuConsultarProductoProveedor.Name = "btSubMenuConsultarProductoProveedor";
            btSubMenuConsultarProductoProveedor.Size = new Size(116, 53);
            btSubMenuConsultarProductoProveedor.TabIndex = 14;
            btSubMenuConsultarProductoProveedor.Text = "Consultar Producto";
            btSubMenuConsultarProductoProveedor.UseVisualStyleBackColor = false;
            btSubMenuConsultarProductoProveedor.Click += btSubMenuConsultarProductoProveedor_Click;
            // 
            // btSubMenuActualizarProductoProveedor
            // 
            btSubMenuActualizarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarProductoProveedor.Location = new Point(209, 100);
            btSubMenuActualizarProductoProveedor.Name = "btSubMenuActualizarProductoProveedor";
            btSubMenuActualizarProductoProveedor.Size = new Size(116, 53);
            btSubMenuActualizarProductoProveedor.TabIndex = 13;
            btSubMenuActualizarProductoProveedor.Text = "Actualizar Producto";
            btSubMenuActualizarProductoProveedor.UseVisualStyleBackColor = false;
            btSubMenuActualizarProductoProveedor.Click += btSubMenuActualizarProductoProveedor_Click;
            // 
            // btSubMenuRegistrarProductoProveedor
            // 
            btSubMenuRegistrarProductoProveedor.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarProductoProveedor.Location = new Point(67, 100);
            btSubMenuRegistrarProductoProveedor.Name = "btSubMenuRegistrarProductoProveedor";
            btSubMenuRegistrarProductoProveedor.Size = new Size(116, 53);
            btSubMenuRegistrarProductoProveedor.TabIndex = 12;
            btSubMenuRegistrarProductoProveedor.Text = "Registrar Producto";
            btSubMenuRegistrarProductoProveedor.UseVisualStyleBackColor = false;
            btSubMenuRegistrarProductoProveedor.Click += btSubMenuRegistrarProductoProveedor_Click;
            // 
            // lbTituloSubMenuProductoProveedor
            // 
            lbTituloSubMenuProductoProveedor.AutoSize = true;
            lbTituloSubMenuProductoProveedor.BackColor = Color.Snow;
            lbTituloSubMenuProductoProveedor.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuProductoProveedor.Location = new Point(12, 55);
            lbTituloSubMenuProductoProveedor.Name = "lbTituloSubMenuProductoProveedor";
            lbTituloSubMenuProductoProveedor.Size = new Size(382, 25);
            lbTituloSubMenuProductoProveedor.TabIndex = 11;
            lbTituloSubMenuProductoProveedor.Text = "SUBMENU PRODUCTO - PROVEEDOR";
            // 
            // SubMenuProductoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 265);
            Controls.Add(btVolver);
            Controls.Add(btSubMenuEliminarProductoProveedor);
            Controls.Add(btSubMenuConsultarProductoProveedor);
            Controls.Add(btSubMenuActualizarProductoProveedor);
            Controls.Add(btSubMenuRegistrarProductoProveedor);
            Controls.Add(lbTituloSubMenuProductoProveedor);
            Name = "SubMenuProductoProveedor";
            Text = "SubMenuProductoProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Button btSubMenuEliminarProductoProveedor;
        private Button btSubMenuConsultarProductoProveedor;
        private Button btSubMenuActualizarProductoProveedor;
        private Button btSubMenuRegistrarProductoProveedor;
        private Label lbTituloSubMenuProductoProveedor;
    }
}