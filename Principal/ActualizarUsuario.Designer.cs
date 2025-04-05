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
            btActualizarUsuario = new Button();
            tbActualizarContraseña = new TextBox();
            tbActualizarNombre = new TextBox();
            tbDocumento = new TextBox();
            lbTituloActualizarProveedores = new Label();
            lbUsuarioActualizar = new Label();
            comboBox1 = new ComboBox();
            lbUsuarioActuzalido = new Label();
            SuspendLayout();
            // 
            // btBuscarUsuario
            // 
            btBuscarUsuario.BackColor = SystemColors.ActiveCaption;
            btBuscarUsuario.Location = new Point(67, 164);
            btBuscarUsuario.Name = "btBuscarUsuario";
            btBuscarUsuario.Size = new Size(118, 40);
            btBuscarUsuario.TabIndex = 22;
            btBuscarUsuario.Text = "BUSCAR";
            btBuscarUsuario.UseVisualStyleBackColor = false;
            btBuscarUsuario.Click += btBuscarUsuario_Click;
            // 
            // btActualizarUsuario
            // 
            btActualizarUsuario.BackColor = SystemColors.ActiveCaption;
            btActualizarUsuario.Location = new Point(311, 266);
            btActualizarUsuario.Name = "btActualizarUsuario";
            btActualizarUsuario.Size = new Size(119, 42);
            btActualizarUsuario.TabIndex = 19;
            btActualizarUsuario.Text = "ACTUALIZAR";
            btActualizarUsuario.UseVisualStyleBackColor = false;
            btActualizarUsuario.Click += btActualizarUsuario_Click;
            // 
            // tbActualizarContraseña
            // 
            tbActualizarContraseña.Location = new Point(269, 120);
            tbActualizarContraseña.Name = "tbActualizarContraseña";
            tbActualizarContraseña.Size = new Size(206, 23);
            tbActualizarContraseña.TabIndex = 18;
            tbActualizarContraseña.Text = "Actualizar Contraseña";
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(269, 76);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(206, 23);
            tbActualizarNombre.TabIndex = 17;
            tbActualizarNombre.Text = "Actualizar Nombre";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(23, 76);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(206, 23);
            tbDocumento.TabIndex = 16;
            tbDocumento.Text = "Ingresar Documento";
            // 
            // lbTituloActualizarProveedores
            // 
            lbTituloActualizarProveedores.AutoSize = true;
            lbTituloActualizarProveedores.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProveedores.Location = new Point(101, 19);
            lbTituloActualizarProveedores.Name = "lbTituloActualizarProveedores";
            lbTituloActualizarProveedores.Size = new Size(329, 32);
            lbTituloActualizarProveedores.TabIndex = 15;
            lbTituloActualizarProveedores.Text = "ACTUALIZAR USUARIOS";
            // 
            // lbUsuarioActualizar
            // 
            lbUsuarioActualizar.AutoSize = true;
            lbUsuarioActualizar.Location = new Point(23, 128);
            lbUsuarioActualizar.Name = "lbUsuarioActualizar";
            lbUsuarioActualizar.Size = new Size(50, 15);
            lbUsuarioActualizar.TabIndex = 23;
            lbUsuarioActualizar.Text = "Usuario:";
            lbUsuarioActualizar.Click += lbUsuarioActualizar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(269, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbUsuarioActuzalido
            // 
            lbUsuarioActuzalido.AutoSize = true;
            lbUsuarioActuzalido.Location = new Point(269, 210);
            lbUsuarioActuzalido.Name = "lbUsuarioActuzalido";
            lbUsuarioActuzalido.Size = new Size(115, 15);
            lbUsuarioActuzalido.TabIndex = 25;
            lbUsuarioActuzalido.Text = "Usuario Actualizado:";
            lbUsuarioActuzalido.Click += lbUsuarioActuzalido_Click;
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 320);
            Controls.Add(lbUsuarioActuzalido);
            Controls.Add(comboBox1);
            Controls.Add(lbUsuarioActualizar);
            Controls.Add(btBuscarUsuario);
            Controls.Add(btActualizarUsuario);
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
        private Button btActualizarUsuario;
        private TextBox tbActualizarContraseña;
        private TextBox tbActualizarNombre;
        private TextBox tbDocumento;
        private Label lbTituloActualizarProveedores;
        private Label lbUsuarioActualizar;
        private ComboBox comboBox1;
        private Label lbUsuarioActuzalido;
    }
}