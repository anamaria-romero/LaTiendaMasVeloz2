namespace Principal
{
    partial class Proveedor
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
            lbTituloProveedor = new Label();
            tbDocumentoProveedor = new TextBox();
            tbNombreProveedor = new TextBox();
            tbTelefonoProveedor = new TextBox();
            btIngresarProveedor = new Button();
            SuspendLayout();
            // 
            // lbTituloProveedor
            // 
            lbTituloProveedor.AutoSize = true;
            lbTituloProveedor.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloProveedor.Location = new Point(147, 54);
            lbTituloProveedor.Name = "lbTituloProveedor";
            lbTituloProveedor.Size = new Size(178, 32);
            lbTituloProveedor.TabIndex = 0;
            lbTituloProveedor.Text = "PROVEEDOR";
            // 
            // tbDocumentoProveedor
            // 
            tbDocumentoProveedor.Location = new Point(104, 121);
            tbDocumentoProveedor.Name = "tbDocumentoProveedor";
            tbDocumentoProveedor.Size = new Size(277, 23);
            tbDocumentoProveedor.TabIndex = 1;
            tbDocumentoProveedor.Text = "Ingrese el documento";
            tbDocumentoProveedor.TextChanged += tbDocumentoProveedor_TextChanged;
            // 
            // tbNombreProveedor
            // 
            tbNombreProveedor.Location = new Point(104, 178);
            tbNombreProveedor.Name = "tbNombreProveedor";
            tbNombreProveedor.Size = new Size(277, 23);
            tbNombreProveedor.TabIndex = 2;
            tbNombreProveedor.Text = "Ingrese el nombre";
            tbNombreProveedor.TextChanged += tbNombreProveedor_TextChanged;
            // 
            // tbTelefonoProveedor
            // 
            tbTelefonoProveedor.Location = new Point(104, 234);
            tbTelefonoProveedor.Name = "tbTelefonoProveedor";
            tbTelefonoProveedor.Size = new Size(277, 23);
            tbTelefonoProveedor.TabIndex = 3;
            tbTelefonoProveedor.Text = "Ingrese el telefono";
            tbTelefonoProveedor.TextChanged += tbTelefonoProveedor_TextChanged;
            // 
            // btIngresarProveedor
            // 
            btIngresarProveedor.BackColor = SystemColors.ActiveCaption;
            btIngresarProveedor.Location = new Point(177, 291);
            btIngresarProveedor.Name = "btIngresarProveedor";
            btIngresarProveedor.Size = new Size(110, 46);
            btIngresarProveedor.TabIndex = 4;
            btIngresarProveedor.Text = "INGRESAR";
            btIngresarProveedor.UseVisualStyleBackColor = false;
            btIngresarProveedor.Click += btIngresarProveedor_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(btIngresarProveedor);
            Controls.Add(tbTelefonoProveedor);
            Controls.Add(tbNombreProveedor);
            Controls.Add(tbDocumentoProveedor);
            Controls.Add(lbTituloProveedor);
            Name = "Proveedor";
            Text = "Proveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloProveedor;
        private TextBox tbDocumentoProveedor;
        private TextBox tbNombreProveedor;
        private TextBox tbTelefonoProveedor;
        private Button btIngresarProveedor;
    }
}