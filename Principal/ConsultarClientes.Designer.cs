namespace Principal
{
    partial class ConsultarClientes
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
            lbTituloConsultarCliente = new Label();
            tbDocumento = new TextBox();
            btConsultar = new Button();
            lbMostrarCliente = new Label();
            SuspendLayout();
            // 
            // lbTituloConsultarCliente
            // 
            lbTituloConsultarCliente.AutoSize = true;
            lbTituloConsultarCliente.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarCliente.Location = new Point(24, 20);
            lbTituloConsultarCliente.Name = "lbTituloConsultarCliente";
            lbTituloConsultarCliente.Size = new Size(311, 32);
            lbTituloConsultarCliente.TabIndex = 6;
            lbTituloConsultarCliente.Text = "CONSULTAR CLIENTES";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(53, 71);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 7;
            tbDocumento.Text = "Ingresar Documento";
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(107, 170);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 49);
            btConsultar.TabIndex = 11;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // lbMostrarCliente
            // 
            lbMostrarCliente.AutoSize = true;
            lbMostrarCliente.Location = new Point(53, 114);
            lbMostrarCliente.Name = "lbMostrarCliente";
            lbMostrarCliente.Size = new Size(47, 15);
            lbMostrarCliente.TabIndex = 12;
            lbMostrarCliente.Text = "Cliente:";
            lbMostrarCliente.Click += lbMostrarCliente_Click;
            // 
            // ConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 241);
            Controls.Add(lbMostrarCliente);
            Controls.Add(btConsultar);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloConsultarCliente);
            Name = "ConsultarClientes";
            Text = "ConsultarClientes";
            Load += ConsultarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloConsultarCliente;
        private TextBox tbDocumento;
        private Button btConsultar;
        private Label lbMostrarCliente;
    }
}