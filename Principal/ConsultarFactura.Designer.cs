namespace Principal
{
    partial class ConsultarFactura
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
            lbMostrarFactura = new Label();
            btConsultar = new Button();
            tbIdentificadorFactura = new TextBox();
            lbTituloConsultarFactura = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // lbMostrarFactura
            // 
            lbMostrarFactura.AutoSize = true;
            lbMostrarFactura.Location = new Point(53, 143);
            lbMostrarFactura.Name = "lbMostrarFactura";
            lbMostrarFactura.Size = new Size(49, 15);
            lbMostrarFactura.TabIndex = 16;
            lbMostrarFactura.Text = "Factura:";
            lbMostrarFactura.Click += lbMostrarFactura_Click;
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(99, 294);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 49);
            btConsultar.TabIndex = 15;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbIdentificadorFactura
            // 
            tbIdentificadorFactura.Location = new Point(53, 100);
            tbIdentificadorFactura.Name = "tbIdentificadorFactura";
            tbIdentificadorFactura.Size = new Size(241, 23);
            tbIdentificadorFactura.TabIndex = 14;
            tbIdentificadorFactura.Text = "Ingresar Identificador";
            tbIdentificadorFactura.TextChanged += tbIdentificadorFactura_TextChanged;
            // 
            // lbTituloConsultarFactura
            // 
            lbTituloConsultarFactura.AutoSize = true;
            lbTituloConsultarFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarFactura.Location = new Point(43, 44);
            lbTituloConsultarFactura.Name = "lbTituloConsultarFactura";
            lbTituloConsultarFactura.Size = new Size(269, 32);
            lbTituloConsultarFactura.TabIndex = 13;
            lbTituloConsultarFactura.Text = "CONSULTAR VENTA";
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 36;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // ConsultarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 355);
            Controls.Add(btVolver);
            Controls.Add(lbMostrarFactura);
            Controls.Add(btConsultar);
            Controls.Add(tbIdentificadorFactura);
            Controls.Add(lbTituloConsultarFactura);
            Name = "ConsultarFactura";
            Text = "ConsultarFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarFactura;
        private Button btConsultar;
        private TextBox tbIdentificadorFactura;
        private Label lbTituloConsultarFactura;
        private Button btVolver;
    }
}