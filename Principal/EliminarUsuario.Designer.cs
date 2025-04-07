namespace Principal
{
    partial class EliminarUsuario
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
            btEliminarCliente = new Button();
            tbDocumento = new TextBox();
            lbEliminarUsuario = new Label();
            lbUsuarioEliminado = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.BackColor = SystemColors.ActiveCaption;
            btEliminarCliente.Location = new Point(121, 210);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(114, 47);
            btEliminarCliente.TabIndex = 7;
            btEliminarCliente.Text = "ELIMINAR";
            btEliminarCliente.UseVisualStyleBackColor = false;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(45, 104);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(279, 23);
            tbDocumento.TabIndex = 5;
            tbDocumento.Text = "Ingresa el documento";
            // 
            // lbEliminarUsuario
            // 
            lbEliminarUsuario.AutoSize = true;
            lbEliminarUsuario.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarUsuario.Location = new Point(45, 49);
            lbEliminarUsuario.Name = "lbEliminarUsuario";
            lbEliminarUsuario.Size = new Size(279, 32);
            lbEliminarUsuario.TabIndex = 4;
            lbEliminarUsuario.Text = "Eliminar Usuario";
            // 
            // lbUsuarioEliminado
            // 
            lbUsuarioEliminado.AutoSize = true;
            lbUsuarioEliminado.Location = new Point(45, 138);
            lbUsuarioEliminado.Name = "lbUsuarioEliminado";
            lbUsuarioEliminado.Size = new Size(106, 15);
            lbUsuarioEliminado.TabIndex = 8;
            lbUsuarioEliminado.Text = "Usuario eliminado:";
            lbUsuarioEliminado.Click += lbUsuarioEliminado_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 18;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // EliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 269);
            Controls.Add(btVolver);
            Controls.Add(lbUsuarioEliminado);
            Controls.Add(btEliminarCliente);
            Controls.Add(tbDocumento);
            Controls.Add(lbEliminarUsuario);
            Name = "EliminarUsuario";
            Text = "EliminarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEliminarCliente;
        private TextBox tbDocumento;
        private Label lbEliminarUsuario;
        private Label lbUsuarioEliminado;
        private Button btVolver;
    }
}