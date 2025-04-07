namespace Principal
{
    partial class ActualizarProveedores
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
            btActualizar = new Button();
            tbActualizarTelefono = new TextBox();
            tbActualizarNombre = new TextBox();
            tbDocumento = new TextBox();
            lbTituloActualizarProveedores = new Label();
            lbProveedorActualizado = new Label();
            btBuscarProveedor = new Button();
            btVolver = new Button();
            SuspendLayout();
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(293, 246);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(127, 48);
            btActualizar.TabIndex = 11;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbActualizarTelefono
            // 
            tbActualizarTelefono.Location = new Point(251, 148);
            tbActualizarTelefono.Name = "tbActualizarTelefono";
            tbActualizarTelefono.Size = new Size(212, 23);
            tbActualizarTelefono.TabIndex = 9;
            tbActualizarTelefono.Text = "Actualizar Telefono";
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(251, 104);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(212, 23);
            tbActualizarNombre.TabIndex = 8;
            tbActualizarNombre.Text = "Actualizar Nombre";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(17, 104);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(212, 23);
            tbDocumento.TabIndex = 7;
            tbDocumento.Text = "Ingresar Documento";
            // 
            // lbTituloActualizarProveedores
            // 
            lbTituloActualizarProveedores.AutoSize = true;
            lbTituloActualizarProveedores.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProveedores.Location = new Point(51, 39);
            lbTituloActualizarProveedores.Name = "lbTituloActualizarProveedores";
            lbTituloActualizarProveedores.Size = new Size(388, 32);
            lbTituloActualizarProveedores.TabIndex = 6;
            lbTituloActualizarProveedores.Text = "ACTUALIZAR PROVEEDORES";
            // 
            // lbProveedorActualizado
            // 
            lbProveedorActualizado.AutoSize = true;
            lbProveedorActualizado.Location = new Point(251, 197);
            lbProveedorActualizado.Name = "lbProveedorActualizado";
            lbProveedorActualizado.Size = new Size(129, 15);
            lbProveedorActualizado.TabIndex = 13;
            lbProveedorActualizado.Text = "Proveedor Actualizado:";
            lbProveedorActualizado.Click += lbProveedorActualizado_Click;
            // 
            // btBuscarProveedor
            // 
            btBuscarProveedor.BackColor = SystemColors.ActiveCaption;
            btBuscarProveedor.Location = new Point(51, 148);
            btBuscarProveedor.Name = "btBuscarProveedor";
            btBuscarProveedor.Size = new Size(117, 42);
            btBuscarProveedor.TabIndex = 14;
            btBuscarProveedor.Text = "BUSCAR";
            btBuscarProveedor.UseVisualStyleBackColor = false;
            btBuscarProveedor.Click += btBuscarProveedor_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 30;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // ActualizarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 305);
            Controls.Add(btVolver);
            Controls.Add(btBuscarProveedor);
            Controls.Add(lbProveedorActualizado);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarTelefono);
            Controls.Add(tbActualizarNombre);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloActualizarProveedores);
            Name = "ActualizarProveedores";
            Text = "ActualizarProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btActualizar;
        private TextBox tbActualizarTelefono;
        private TextBox tbActualizarNombre;
        private TextBox tbDocumento;
        private Label lbTituloActualizarProveedores;
        private Label lbProveedorActualizado;
        private Button btBuscarProveedor;
        private Button btVolver;
    }
}