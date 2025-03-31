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
            tbActualizarContraseña = new TextBox();
            tbActualizarTelefono = new TextBox();
            tbActualizarNombre = new TextBox();
            tbDocumento = new TextBox();
            lbTituloActualizarProveedores = new Label();
            SuspendLayout();
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(141, 273);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(127, 63);
            btActualizar.TabIndex = 11;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbActualizarContraseña
            // 
            tbActualizarContraseña.Location = new Point(90, 221);
            tbActualizarContraseña.Name = "tbActualizarContraseña";
            tbActualizarContraseña.Size = new Size(241, 23);
            tbActualizarContraseña.TabIndex = 10;
            tbActualizarContraseña.Text = "Actualizar Contraseña";
            tbActualizarContraseña.TextChanged += tbActualizarContraseña_TextChanged;
            // 
            // tbActualizarTelefono
            // 
            tbActualizarTelefono.Location = new Point(90, 172);
            tbActualizarTelefono.Name = "tbActualizarTelefono";
            tbActualizarTelefono.Size = new Size(241, 23);
            tbActualizarTelefono.TabIndex = 9;
            tbActualizarTelefono.Text = "Actualizar Telefono";
            tbActualizarTelefono.TextChanged += tbActualizarTelefono_TextChanged;
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(90, 127);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(241, 23);
            tbActualizarNombre.TabIndex = 8;
            tbActualizarNombre.Text = "Actualizar Nombre";
            tbActualizarNombre.TextChanged += tbActualizarNombre_TextChanged;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(90, 81);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 7;
            tbDocumento.Text = "Ingresar Documento";
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // lbTituloActualizarProveedores
            // 
            lbTituloActualizarProveedores.AutoSize = true;
            lbTituloActualizarProveedores.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarProveedores.Location = new Point(25, 27);
            lbTituloActualizarProveedores.Name = "lbTituloActualizarProveedores";
            lbTituloActualizarProveedores.Size = new Size(388, 32);
            lbTituloActualizarProveedores.TabIndex = 6;
            lbTituloActualizarProveedores.Text = "ACTUALIZAR PROVEEDORES";
            // 
            // ActualizarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 354);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarContraseña);
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
        private TextBox tbActualizarContraseña;
        private TextBox tbActualizarTelefono;
        private TextBox tbActualizarNombre;
        private TextBox tbDocumento;
        private Label lbTituloActualizarProveedores;
    }
}