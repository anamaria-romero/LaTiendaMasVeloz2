namespace Principal
{
    partial class SubMenuUsuarios
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
            btSubMenuEliminarUsuario = new Button();
            btSubMenuConsultarUsuario = new Button();
            btSubMenuActualizarUsuario = new Button();
            btSubMenuRegistrarUsuario = new Button();
            lbTituloSubMenuUsuarios = new Label();
            SuspendLayout();
            // 
            // btSubMenuEliminarUsuario
            // 
            btSubMenuEliminarUsuario.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarUsuario.Location = new Point(221, 199);
            btSubMenuEliminarUsuario.Name = "btSubMenuEliminarUsuario";
            btSubMenuEliminarUsuario.Size = new Size(116, 53);
            btSubMenuEliminarUsuario.TabIndex = 9;
            btSubMenuEliminarUsuario.Text = "Eliminar Usuario";
            btSubMenuEliminarUsuario.UseVisualStyleBackColor = false;
            btSubMenuEliminarUsuario.Click += btSubMenuEliminarUsuario_Click;
            // 
            // btSubMenuConsultarUsuario
            // 
            btSubMenuConsultarUsuario.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarUsuario.Location = new Point(79, 199);
            btSubMenuConsultarUsuario.Name = "btSubMenuConsultarUsuario";
            btSubMenuConsultarUsuario.Size = new Size(116, 53);
            btSubMenuConsultarUsuario.TabIndex = 8;
            btSubMenuConsultarUsuario.Text = "Consultar Usuario";
            btSubMenuConsultarUsuario.UseVisualStyleBackColor = false;
            btSubMenuConsultarUsuario.Click += btSubMenuConsultarUsuario_Click;
            // 
            // btSubMenuActualizarUsuario
            // 
            btSubMenuActualizarUsuario.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarUsuario.Location = new Point(221, 114);
            btSubMenuActualizarUsuario.Name = "btSubMenuActualizarUsuario";
            btSubMenuActualizarUsuario.Size = new Size(116, 53);
            btSubMenuActualizarUsuario.TabIndex = 7;
            btSubMenuActualizarUsuario.Text = "Actualizar Usuario";
            btSubMenuActualizarUsuario.UseVisualStyleBackColor = false;
            btSubMenuActualizarUsuario.Click += btSubMenuActualizarUsuario_Click;
            // 
            // btSubMenuRegistrarUsuario
            // 
            btSubMenuRegistrarUsuario.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarUsuario.Location = new Point(79, 114);
            btSubMenuRegistrarUsuario.Name = "btSubMenuRegistrarUsuario";
            btSubMenuRegistrarUsuario.Size = new Size(116, 53);
            btSubMenuRegistrarUsuario.TabIndex = 6;
            btSubMenuRegistrarUsuario.Text = "Registrar Usuario";
            btSubMenuRegistrarUsuario.UseVisualStyleBackColor = false;
            btSubMenuRegistrarUsuario.Click += btSubMenuRegistrarUsuario_Click;
            // 
            // lbTituloSubMenuUsuarios
            // 
            lbTituloSubMenuUsuarios.AutoSize = true;
            lbTituloSubMenuUsuarios.BackColor = Color.Snow;
            lbTituloSubMenuUsuarios.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuUsuarios.Location = new Point(66, 47);
            lbTituloSubMenuUsuarios.Name = "lbTituloSubMenuUsuarios";
            lbTituloSubMenuUsuarios.Size = new Size(291, 32);
            lbTituloSubMenuUsuarios.TabIndex = 5;
            lbTituloSubMenuUsuarios.Text = "SUBMENU USUARIOS";
            // 
            // SubMenuUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 320);
            Controls.Add(btSubMenuEliminarUsuario);
            Controls.Add(btSubMenuConsultarUsuario);
            Controls.Add(btSubMenuActualizarUsuario);
            Controls.Add(btSubMenuRegistrarUsuario);
            Controls.Add(lbTituloSubMenuUsuarios);
            Name = "SubMenuUsuarios";
            Text = "SubMenuUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSubMenuEliminarUsuario;
        private Button btSubMenuConsultarUsuario;
        private Button btSubMenuActualizarUsuario;
        private Button btSubMenuRegistrarUsuario;
        private Label lbTituloSubMenuUsuarios;
    }
}