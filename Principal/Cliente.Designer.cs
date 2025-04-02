namespace Principal
{
    partial class Cliente
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
            lbTituloCliente = new Label();
            tbNombreCliente = new TextBox();
            tbTelefonoCliente = new TextBox();
            tbDocumentoCliente = new TextBox();
            btIngresarCliente = new Button();
            SuspendLayout();
            // 
            // lbTituloCliente
            // 
            lbTituloCliente.AutoSize = true;
            lbTituloCliente.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloCliente.Location = new Point(174, 65);
            lbTituloCliente.Name = "lbTituloCliente";
            lbTituloCliente.Size = new Size(128, 32);
            lbTituloCliente.TabIndex = 0;
            lbTituloCliente.Text = "CLIENTE";
            // 
            // tbNombreCliente
            // 
            tbNombreCliente.Location = new Point(94, 167);
            tbNombreCliente.Name = "tbNombreCliente";
            tbNombreCliente.Size = new Size(291, 23);
            tbNombreCliente.TabIndex = 1;
            tbNombreCliente.Text = "Ingrese el nombre";
            // 
            // tbTelefonoCliente
            // 
            tbTelefonoCliente.Location = new Point(94, 210);
            tbTelefonoCliente.Name = "tbTelefonoCliente";
            tbTelefonoCliente.Size = new Size(291, 23);
            tbTelefonoCliente.TabIndex = 2;
            tbTelefonoCliente.Text = "Ingrese el telefono";
            // 
            // tbDocumentoCliente
            // 
            tbDocumentoCliente.Location = new Point(94, 123);
            tbDocumentoCliente.Name = "tbDocumentoCliente";
            tbDocumentoCliente.Size = new Size(291, 23);
            tbDocumentoCliente.TabIndex = 3;
            tbDocumentoCliente.Text = "Ingrese el documento";
            // 
            // btIngresarCliente
            // 
            btIngresarCliente.BackColor = SystemColors.ActiveCaption;
            btIngresarCliente.Location = new Point(167, 268);
            btIngresarCliente.Name = "btIngresarCliente";
            btIngresarCliente.RightToLeft = RightToLeft.No;
            btIngresarCliente.Size = new Size(135, 61);
            btIngresarCliente.TabIndex = 4;
            btIngresarCliente.Text = "REGISTRAR";
            btIngresarCliente.UseVisualStyleBackColor = false;
            btIngresarCliente.Click += btIngresarCliente_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(btIngresarCliente);
            Controls.Add(tbDocumentoCliente);
            Controls.Add(tbTelefonoCliente);
            Controls.Add(tbNombreCliente);
            Controls.Add(lbTituloCliente);
            Name = "Cliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloCliente;
        private TextBox tbNombreCliente;
        private TextBox tbTelefonoCliente;
        private TextBox tbDocumentoCliente;
        private Button btIngresarCliente;
    }
}