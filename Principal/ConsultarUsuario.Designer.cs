namespace Principal
{
    partial class ConsultarUsuario
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
            lbMostrarUsuario = new Label();
            btConsultar = new Button();
            tbDocumentoUsuario = new TextBox();
            lbTituloConsultarUsuario = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // lbMostrarUsuario
            // 
            lbMostrarUsuario.AutoSize = true;
            lbMostrarUsuario.Location = new Point(63, 135);
            lbMostrarUsuario.Name = "lbMostrarUsuario";
            lbMostrarUsuario.Size = new Size(50, 15);
            lbMostrarUsuario.TabIndex = 20;
            lbMostrarUsuario.Text = "Usuario:";
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(116, 201);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 51);
            btConsultar.TabIndex = 19;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbDocumentoUsuario
            // 
            tbDocumentoUsuario.Location = new Point(63, 100);
            tbDocumentoUsuario.Name = "tbDocumentoUsuario";
            tbDocumentoUsuario.Size = new Size(241, 23);
            tbDocumentoUsuario.TabIndex = 18;
            tbDocumentoUsuario.Text = "Ingresar el documento";
            // 
            // lbTituloConsultarUsuario
            // 
            lbTituloConsultarUsuario.AutoSize = true;
            lbTituloConsultarUsuario.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarUsuario.Location = new Point(27, 48);
            lbTituloConsultarUsuario.Name = "lbTituloConsultarUsuario";
            lbTituloConsultarUsuario.Size = new Size(303, 32);
            lbTituloConsultarUsuario.TabIndex = 17;
            lbTituloConsultarUsuario.Text = "CONSULTAR USUARIO";
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 21;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // ConsultarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 264);
            Controls.Add(btVolver);
            Controls.Add(lbMostrarUsuario);
            Controls.Add(btConsultar);
            Controls.Add(tbDocumentoUsuario);
            Controls.Add(lbTituloConsultarUsuario);
            Name = "ConsultarUsuario";
            Text = "ConsultarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarUsuario;
        private Button btConsultar;
        private TextBox tbDocumentoUsuario;
        private Label lbTituloConsultarUsuario;
        private Button btVolver;
    }
}