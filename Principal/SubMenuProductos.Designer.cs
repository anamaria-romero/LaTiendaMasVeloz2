namespace Principal
{
    partial class SubMenuProductos
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
            btSubMenuEliminarProducto = new Button();
            btSubMenuConsultarProducto = new Button();
            btSubMenuActualizarProducto = new Button();
            btSubMenuRegistrarProducto = new Button();
            lbTituloSubMenuProductos = new Label();
            SuspendLayout();
            // 
            // btSubMenuEliminarProducto
            // 
            btSubMenuEliminarProducto.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarProducto.Location = new Point(206, 171);
            btSubMenuEliminarProducto.Name = "btSubMenuEliminarProducto";
            btSubMenuEliminarProducto.Size = new Size(116, 53);
            btSubMenuEliminarProducto.TabIndex = 9;
            btSubMenuEliminarProducto.Text = "Eliminar Producto";
            btSubMenuEliminarProducto.UseVisualStyleBackColor = false;
            btSubMenuEliminarProducto.Click += btSubMenuEliminarProducto_Click;
            // 
            // btSubMenuConsultarProducto
            // 
            btSubMenuConsultarProducto.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarProducto.Location = new Point(64, 171);
            btSubMenuConsultarProducto.Name = "btSubMenuConsultarProducto";
            btSubMenuConsultarProducto.Size = new Size(116, 53);
            btSubMenuConsultarProducto.TabIndex = 8;
            btSubMenuConsultarProducto.Text = "Consultar Producto";
            btSubMenuConsultarProducto.UseVisualStyleBackColor = false;
            btSubMenuConsultarProducto.Click += btSubMenuConsultarProducto_Click;
            // 
            // btSubMenuActualizarProducto
            // 
            btSubMenuActualizarProducto.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarProducto.Location = new Point(206, 86);
            btSubMenuActualizarProducto.Name = "btSubMenuActualizarProducto";
            btSubMenuActualizarProducto.Size = new Size(116, 53);
            btSubMenuActualizarProducto.TabIndex = 7;
            btSubMenuActualizarProducto.Text = "Actualizar Producto";
            btSubMenuActualizarProducto.UseVisualStyleBackColor = false;
            btSubMenuActualizarProducto.Click += btSubMenuActualizarProducto_Click;
            // 
            // btSubMenuRegistrarProducto
            // 
            btSubMenuRegistrarProducto.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarProducto.Location = new Point(64, 86);
            btSubMenuRegistrarProducto.Name = "btSubMenuRegistrarProducto";
            btSubMenuRegistrarProducto.Size = new Size(116, 53);
            btSubMenuRegistrarProducto.TabIndex = 6;
            btSubMenuRegistrarProducto.Text = "Registrar Producto";
            btSubMenuRegistrarProducto.UseVisualStyleBackColor = false;
            btSubMenuRegistrarProducto.Click += btSubMenuRegistrarProducto_Click;
            // 
            // lbTituloSubMenuProductos
            // 
            lbTituloSubMenuProductos.AutoSize = true;
            lbTituloSubMenuProductos.BackColor = Color.Snow;
            lbTituloSubMenuProductos.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuProductos.Location = new Point(39, 29);
            lbTituloSubMenuProductos.Name = "lbTituloSubMenuProductos";
            lbTituloSubMenuProductos.Size = new Size(315, 32);
            lbTituloSubMenuProductos.TabIndex = 5;
            lbTituloSubMenuProductos.Text = "SUBMENU PRODUCTOS";
            // 
            // SubMenuProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 260);
            Controls.Add(btSubMenuEliminarProducto);
            Controls.Add(btSubMenuConsultarProducto);
            Controls.Add(btSubMenuActualizarProducto);
            Controls.Add(btSubMenuRegistrarProducto);
            Controls.Add(lbTituloSubMenuProductos);
            Name = "SubMenuProductos";
            Text = "SubMenuProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSubMenuEliminarProducto;
        private Button btSubMenuConsultarProducto;
        private Button btSubMenuActualizarProducto;
        private Button btSubMenuRegistrarProducto;
        private Label lbTituloSubMenuProductos;
    }
}