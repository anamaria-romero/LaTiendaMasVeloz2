﻿namespace Principal
{
    partial class Usuario
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
            btIngresarUsuario = new Button();
            tbContraseñaUsuario = new TextBox();
            tbNombreUsuario = new TextBox();
            tbDocumentoUsuario = new TextBox();
            lbTituloUsuario = new Label();
            cbCargo = new ComboBox();
            lbUsuarioRegistrado = new Label();
            SuspendLayout();
            // 
            // btIngresarUsuario
            // 
            btIngresarUsuario.BackColor = SystemColors.ActiveCaption;
            btIngresarUsuario.Location = new Point(140, 281);
            btIngresarUsuario.Name = "btIngresarUsuario";
            btIngresarUsuario.Size = new Size(110, 46);
            btIngresarUsuario.TabIndex = 9;
            btIngresarUsuario.Text = "INGRESAR";
            btIngresarUsuario.UseVisualStyleBackColor = false;
            btIngresarUsuario.Click += btIngresarUsuario_Click;
            // 
            // tbContraseñaUsuario
            // 
            tbContraseñaUsuario.Location = new Point(67, 195);
            tbContraseñaUsuario.Name = "tbContraseñaUsuario";
            tbContraseñaUsuario.Size = new Size(277, 23);
            tbContraseñaUsuario.TabIndex = 8;
            tbContraseñaUsuario.Text = "Ingrese la contraseña";
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Location = new Point(67, 105);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(277, 23);
            tbNombreUsuario.TabIndex = 7;
            tbNombreUsuario.Text = "Ingrese el nombre";
            // 
            // tbDocumentoUsuario
            // 
            tbDocumentoUsuario.Location = new Point(67, 61);
            tbDocumentoUsuario.Name = "tbDocumentoUsuario";
            tbDocumentoUsuario.Size = new Size(277, 23);
            tbDocumentoUsuario.TabIndex = 6;
            tbDocumentoUsuario.Text = "Ingrese el documento";
            // 
            // lbTituloUsuario
            // 
            lbTituloUsuario.AutoSize = true;
            lbTituloUsuario.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloUsuario.Location = new Point(140, 9);
            lbTituloUsuario.Name = "lbTituloUsuario";
            lbTituloUsuario.Size = new Size(136, 32);
            lbTituloUsuario.TabIndex = 5;
            lbTituloUsuario.Text = "USUARIO";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(67, 151);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(277, 23);
            cbCargo.TabIndex = 10;
            cbCargo.Text = "Elije el cargo";
            // 
            // lbUsuarioRegistrado
            // 
            lbUsuarioRegistrado.AutoSize = true;
            lbUsuarioRegistrado.Location = new Point(67, 247);
            lbUsuarioRegistrado.Name = "lbUsuarioRegistrado";
            lbUsuarioRegistrado.Size = new Size(50, 15);
            lbUsuarioRegistrado.TabIndex = 11;
            lbUsuarioRegistrado.Text = "Usuario:";
            lbUsuarioRegistrado.Click += lbUsuarioRegistrado_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 339);
            Controls.Add(lbUsuarioRegistrado);
            Controls.Add(cbCargo);
            Controls.Add(btIngresarUsuario);
            Controls.Add(tbContraseñaUsuario);
            Controls.Add(tbNombreUsuario);
            Controls.Add(tbDocumentoUsuario);
            Controls.Add(lbTituloUsuario);
            Name = "Usuario";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btIngresarUsuario;
        private TextBox tbContraseñaUsuario;
        private TextBox tbNombreUsuario;
        private TextBox tbDocumentoUsuario;
        private Label lbTituloUsuario;
        private ComboBox cbCargo;
        private Label lbUsuarioRegistrado;
    }
}