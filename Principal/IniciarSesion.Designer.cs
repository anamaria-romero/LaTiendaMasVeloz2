namespace Principal
{
    partial class IniciarSesion
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
            lbIniciar = new Label();
            tbIngresarNombre = new TextBox();
            tbContraseñaIniciarSesion = new TextBox();
            tbIngresarRol = new TextBox();
            btIngresar = new Button();
            SuspendLayout();
            // 
            // lbIniciar
            // 
            lbIniciar.AutoSize = true;
            lbIniciar.BackColor = SystemColors.ButtonFace;
            lbIniciar.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIniciar.Location = new Point(104, 67);
            lbIniciar.Name = "lbIniciar";
            lbIniciar.Size = new Size(230, 32);
            lbIniciar.TabIndex = 0;
            lbIniciar.Text = "Iniciar Sesion";
            // 
            // tbIngresarNombre
            // 
            tbIngresarNombre.Location = new Point(49, 118);
            tbIngresarNombre.Name = "tbIngresarNombre";
            tbIngresarNombre.Size = new Size(349, 23);
            tbIngresarNombre.TabIndex = 2;
            tbIngresarNombre.Text = "Ingresar Nombre";
            tbIngresarNombre.TextChanged += tbIngresarNombre_TextChanged;
            // 
            // tbContraseñaIniciarSesion
            // 
            tbContraseñaIniciarSesion.Location = new Point(49, 200);
            tbContraseñaIniciarSesion.Name = "tbContraseñaIniciarSesion";
            tbContraseñaIniciarSesion.Size = new Size(349, 23);
            tbContraseñaIniciarSesion.TabIndex = 3;
            tbContraseñaIniciarSesion.Text = "Ingresar Contraseña";
            tbContraseñaIniciarSesion.TextChanged += tbContraseñaIniciarSesion_TextChanged;
            // 
            // tbIngresarRol
            // 
            tbIngresarRol.AllowDrop = true;
            tbIngresarRol.Location = new Point(49, 159);
            tbIngresarRol.Name = "tbIngresarRol";
            tbIngresarRol.Size = new Size(349, 23);
            tbIngresarRol.TabIndex = 4;
            tbIngresarRol.Text = "Ingresar Rol";
            tbIngresarRol.TextChanged += tbIngresarRol_TextChanged;
            // 
            // btIngresar
            // 
            btIngresar.BackColor = SystemColors.ActiveCaption;
            btIngresar.Location = new Point(126, 257);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(191, 63);
            btIngresar.TabIndex = 5;
            btIngresar.Text = "INGRESAR";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 377);
            Controls.Add(btIngresar);
            Controls.Add(tbIngresarRol);
            Controls.Add(tbContraseñaIniciarSesion);
            Controls.Add(tbIngresarNombre);
            Controls.Add(lbIniciar);
            Name = "IniciarSesion";
            Text = "IniciarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIniciar;
        private TextBox tbIngresarNombre;
        private TextBox tbContraseñaIniciarSesion;
        private TextBox tbIngresarRol;
        private Button btIngresar;
    }
}