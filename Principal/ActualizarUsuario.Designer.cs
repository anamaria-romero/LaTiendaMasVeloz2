namespace Principal
{
    partial class ActualizarUsuario
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
            btBuscarUsuario = new Button();
            btActualizar = new Button();
            tbActualizarContraseña = new TextBox();
            tbActualizarNombre = new TextBox();
            tbDocumento = new TextBox();
            lbTituloActualizarProveedores = new Label();
            SuspendLayout();
            // 
            // btBuscarUsuario
            // 
            btBuscarUsuario.BackColor = SystemColors.ActiveCaption;
            btBuscarUsuario.Location = new Point(75, 152);
            btBuscarUsuario.Name = "btBuscarUsuario";
            btBuscarUsuario.Size = new Size(133, 55);
            btBuscarUsuario.TabIndex = 22;
            btBuscarUsuario.Text = "BUSCAR";
            btBuscarUsuario.UseVisualStyleBackColor = false;
            btBuscarUsuario.Click += btBuscarUsuario_Click;
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(328, 196);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(127, 63);
            btActualizar.TabIndex = 19;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbActualizarContraseña
            // 
            tbActualizarContraseña.Location = new Point(290, 143);
            tbActualizarContraseña.Name = "tbActualizarContraseña";
            tbActualizarContraseña.Size = new Size(241, 23);
            tbActualizarContraseña.TabIndex = 18;
            tbActualizarContraseña.Text = "Actualizar Contraseña";
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(290, 98);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(241, 23);
            tbActualizarNombre.TabIndex = 17;
            tbActualizarNombre.Text = "Actualizar Nombre";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(26, 99);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 16;
            tbDocumento.Text = "Ingresar Documento";
            // 
            // lbTituloActualizarProveedores
            // 
            lbTituloActualizarProveedores.AutoSize = true;
            lbTituloActualizarProveedores.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProveedores.Location = new Point(116, 32);
            lbTituloActualizarProveedores.Name = "lbTituloActualizarProveedores";
            lbTituloActualizarProveedores.Size = new Size(329, 32);
            lbTituloActualizarProveedores.TabIndex = 15;
            lbTituloActualizarProveedores.Text = "ACTUALIZAR USUARIOS";
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 280);
            Controls.Add(btBuscarUsuario);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarContraseña);
            Controls.Add(tbActualizarNombre);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloActualizarProveedores);
            Name = "ActualizarUsuario";
            Text = "ActualizarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btBuscarUsuario;
        private Button btActualizar;
        private TextBox tbActualizarContraseña;
        private TextBox tbActualizarNombre;
        private TextBox tbDocumento;
        private Label lbTituloActualizarProveedores;
    }
}