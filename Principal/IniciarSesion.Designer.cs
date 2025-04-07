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
            btIngresar = new Button();
            cbCargo = new ComboBox();
            lbTituloPagina = new Label();
            SuspendLayout();
            // 
            // lbIniciar
            // 
            lbIniciar.AutoSize = true;
            lbIniciar.BackColor = SystemColors.ButtonFace;
            lbIniciar.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIniciar.Location = new Point(112, 67);
            lbIniciar.Name = "lbIniciar";
            lbIniciar.Size = new Size(230, 32);
            lbIniciar.TabIndex = 0;
            lbIniciar.Text = "Iniciar Sesion";
            // 
            // tbIngresarNombre
            // 
            tbIngresarNombre.Location = new Point(57, 118);
            tbIngresarNombre.Name = "tbIngresarNombre";
            tbIngresarNombre.Size = new Size(349, 23);
            tbIngresarNombre.TabIndex = 2;
            tbIngresarNombre.Text = "Ingresar Documento";
            tbIngresarNombre.TextChanged += tbIngresarNombre_TextChanged;
            // 
            // tbContraseñaIniciarSesion
            // 
            tbContraseñaIniciarSesion.Location = new Point(57, 200);
            tbContraseñaIniciarSesion.Name = "tbContraseñaIniciarSesion";
            tbContraseñaIniciarSesion.Size = new Size(349, 23);
            tbContraseñaIniciarSesion.TabIndex = 3;
            tbContraseñaIniciarSesion.Text = "Ingresar Contraseña";
            tbContraseñaIniciarSesion.TextChanged += tbContraseñaIniciarSesion_TextChanged;
            // 
            // btIngresar
            // 
            btIngresar.BackColor = SystemColors.ActiveCaption;
            btIngresar.Location = new Point(153, 242);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(147, 53);
            btIngresar.TabIndex = 5;
            btIngresar.Text = "INGRESAR";
            btIngresar.UseVisualStyleBackColor = false;
            btIngresar.Click += btIngresar_Click;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(57, 159);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(349, 23);
            cbCargo.TabIndex = 6;
            cbCargo.Text = "Elige el cargo";
            // 
            // lbTituloPagina
            // 
            lbTituloPagina.AutoSize = true;
            lbTituloPagina.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloPagina.Location = new Point(5, 9);
            lbTituloPagina.Name = "lbTituloPagina";
            lbTituloPagina.Size = new Size(434, 37);
            lbTituloPagina.TabIndex = 9;
            lbTituloPagina.Text = "LA TIENDA MAS VELOZ";
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 307);
            Controls.Add(lbTituloPagina);
            Controls.Add(cbCargo);
            Controls.Add(btIngresar);
            Controls.Add(tbContraseñaIniciarSesion);
            Controls.Add(tbIngresarNombre);
            Controls.Add(lbIniciar);
            Name = "IniciarSesion";
            Text = "IniciarSesion";
            Load += IniciarSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIniciar;
        private TextBox tbIngresarNombre;
        private TextBox tbContraseñaIniciarSesion;
        private Button btIngresar;
        private ComboBox cbCargo;
        private Label lbTituloPagina;
    }
}