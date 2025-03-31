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
            tbActualizarContraseña = new TextBox();
            btActualizar = new Button();
            SuspendLayout();
            // 
            // lbTituloActualizarCliente
            // 
            lbTituloActualizarCliente.AutoSize = true;
            lbTituloActualizarCliente.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarCliente.Location = new Point(75, 41);
            lbTituloActualizarCliente.Name = "lbTituloActualizarCliente";
            lbTituloActualizarCliente.Size = new Size(321, 32);
            lbTituloActualizarCliente.TabIndex = 0;
            lbTituloActualizarCliente.Text = "ACTUALIZAR CLIENTES";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(113, 108);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 1;
            tbDocumento.Text = "Ingresar Documento";
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(113, 149);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(241, 23);
            tbActualizarNombre.TabIndex = 2;
            tbActualizarNombre.Text = "Actualizar Nombre";
            tbActualizarNombre.TextChanged += tbActualizarNombre_TextChanged;
            // 
            // tbActualizarTelefono
            // 
            tbActualizarTelefono.Location = new Point(113, 194);
            tbActualizarTelefono.Name = "tbActualizarTelefono";
            tbActualizarTelefono.Size = new Size(241, 23);
            tbActualizarTelefono.TabIndex = 3;
            tbActualizarTelefono.Text = "Actualizar Telefono";
            tbActualizarTelefono.TextChanged += tbActualizarTelefono_TextChanged;
            // 
            // tbActualizarContraseña
            // 
            tbActualizarContraseña.Location = new Point(113, 243);
            tbActualizarContraseña.Name = "tbActualizarContraseña";
            tbActualizarContraseña.Size = new Size(241, 23);
            tbActualizarContraseña.TabIndex = 4;
            tbActualizarContraseña.Text = "Actualizar Contraseña";
            tbActualizarContraseña.TextChanged += tbActualizarContraseña_TextChanged;
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(164, 295);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(127, 63);
            btActualizar.TabIndex = 5;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // ActualizarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 450);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarContraseña);
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
        private TextBox tbActualizarContraseña;
        private Button btActualizar;
    }
}