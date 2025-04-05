namespace Principal
{
    partial class ActualizarClientes
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
            lbTituloActualizarCliente = new Label();
            tbDocumento = new TextBox();
            tbActualizarNombre = new TextBox();
            tbActualizarTelefono = new TextBox();
            btActualizar = new Button();
            label1 = new Label();
            lbClienteActualizado = new Label();
            btBuscarCliente = new Button();
            SuspendLayout();
            // 
            // lbTituloActualizarCliente
            // 
            lbTituloActualizarCliente.AutoSize = true;
            lbTituloActualizarCliente.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarCliente.Location = new Point(117, 23);
            lbTituloActualizarCliente.Name = "lbTituloActualizarCliente";
            lbTituloActualizarCliente.Size = new Size(321, 32);
            lbTituloActualizarCliente.TabIndex = 0;
            lbTituloActualizarCliente.Text = "ACTUALIZAR CLIENTES";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(17, 73);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 1;
            tbDocumento.Text = "Ingresar Documento";
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(295, 73);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(241, 23);
            tbActualizarNombre.TabIndex = 2;
            tbActualizarNombre.Text = "Actualizar Nombre";
            tbActualizarNombre.TextChanged += tbActualizarNombre_TextChanged;
            // 
            // tbActualizarTelefono
            // 
            tbActualizarTelefono.Location = new Point(295, 118);
            tbActualizarTelefono.Name = "tbActualizarTelefono";
            tbActualizarTelefono.Size = new Size(241, 23);
            tbActualizarTelefono.TabIndex = 3;
            tbActualizarTelefono.Text = "Actualizar Telefono";
            tbActualizarTelefono.TextChanged += tbActualizarTelefono_TextChanged;
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(356, 211);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(124, 40);
            btActualizar.TabIndex = 5;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 121);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 6;
            label1.Text = "Cliente que se va actualizar:";
            label1.Click += label1_Click;
            // 
            // lbClienteActualizado
            // 
            lbClienteActualizado.AutoSize = true;
            lbClienteActualizado.Location = new Point(295, 167);
            lbClienteActualizado.Name = "lbClienteActualizado";
            lbClienteActualizado.Size = new Size(110, 15);
            lbClienteActualizado.TabIndex = 7;
            lbClienteActualizado.Text = "Cliente actualizado:";
            lbClienteActualizado.Click += lbClienteActualizado_Click;
            // 
            // btBuscarCliente
            // 
            btBuscarCliente.BackColor = SystemColors.ActiveCaption;
            btBuscarCliente.Location = new Point(67, 167);
            btBuscarCliente.Name = "btBuscarCliente";
            btBuscarCliente.Size = new Size(115, 41);
            btBuscarCliente.TabIndex = 8;
            btBuscarCliente.Text = "BUSCAR";
            btBuscarCliente.UseVisualStyleBackColor = false;
            btBuscarCliente.Click += btBuscarCliente_Click;
            // 
            // ActualizarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 263);
            Controls.Add(btBuscarCliente);
            Controls.Add(lbClienteActualizado);
            Controls.Add(label1);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarTelefono);
            Controls.Add(tbActualizarNombre);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloActualizarCliente);
            Name = "ActualizarClientes";
            Text = "ActualizarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloActualizarCliente;
        private TextBox tbDocumento;
        private TextBox tbActualizarNombre;
        private TextBox tbActualizarTelefono;
        private Button btActualizar;
        private Label label1;
        private Label lbClienteActualizado;
        private Button btBuscarCliente;
    }
}