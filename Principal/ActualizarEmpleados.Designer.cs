namespace Principal
{
    partial class ActualizarEmpleados
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
            tbActualizarCargo = new TextBox();
            tbActualizarNombre = new TextBox();
            tbDocumento = new TextBox();
            lbTituloActualizarEmpleado = new Label();
            SuspendLayout();
            // 
            // btActualizar
            // 
            btActualizar.BackColor = SystemColors.ActiveCaption;
            btActualizar.Location = new Point(156, 273);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(127, 63);
            btActualizar.TabIndex = 11;
            btActualizar.Text = "ACTUALIZAR";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // tbActualizarContraseña
            // 
            tbActualizarContraseña.Location = new Point(105, 215);
            tbActualizarContraseña.Name = "tbActualizarContraseña";
            tbActualizarContraseña.Size = new Size(241, 23);
            tbActualizarContraseña.TabIndex = 10;
            tbActualizarContraseña.Text = "Actualizar Contraseña";
            tbActualizarContraseña.TextChanged += tbActualizarContraseña_TextChanged;
            // 
            // tbActualizarCargo
            // 
            tbActualizarCargo.Location = new Point(105, 172);
            tbActualizarCargo.Name = "tbActualizarCargo";
            tbActualizarCargo.Size = new Size(241, 23);
            tbActualizarCargo.TabIndex = 9;
            tbActualizarCargo.Text = "Actualizar Cargo";
            tbActualizarCargo.TextChanged += tbActualizarCargo_TextChanged;
            // 
            // tbActualizarNombre
            // 
            tbActualizarNombre.Location = new Point(105, 127);
            tbActualizarNombre.Name = "tbActualizarNombre";
            tbActualizarNombre.Size = new Size(241, 23);
            tbActualizarNombre.TabIndex = 8;
            tbActualizarNombre.Text = "Actualizar Nombre";
            tbActualizarNombre.TextChanged += tbActualizarNombre_TextChanged;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(105, 86);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 7;
            tbDocumento.Text = "Ingresar Documento";
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // lbTituloActualizarEmpleado
            // 
            lbTituloActualizarEmpleado.AutoSize = true;
            lbTituloActualizarEmpleado.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloActualizarEmpleado.Location = new Point(67, 19);
            lbTituloActualizarEmpleado.Name = "lbTituloActualizarEmpleado";
            lbTituloActualizarEmpleado.Size = new Size(351, 32);
            lbTituloActualizarEmpleado.TabIndex = 6;
            lbTituloActualizarEmpleado.Text = "ACTUALIZAR EMPLEADOS";
            // 
            // ActualizarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 355);
            Controls.Add(btActualizar);
            Controls.Add(tbActualizarContraseña);
            Controls.Add(tbActualizarCargo);
            Controls.Add(tbActualizarNombre);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloActualizarEmpleado);
            Name = "ActualizarEmpleados";
            Text = "ActualizarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btActualizar;
        private TextBox tbActualizarContraseña;
        private TextBox tbActualizarCargo;
        private TextBox tbActualizarNombre;
        private TextBox tbDocumento;
        private Label lbTituloActualizarEmpleado;
    }
}