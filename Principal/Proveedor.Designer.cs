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
            label1 = new Label();
            SuspendLayout();
            // 
            // lbTituloProveedor
            // 
            lbTituloProveedor.AutoSize = true;
            lbTituloProveedor.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloProveedor.Location = new Point(89, 13);
            lbTituloProveedor.Name = "lbTituloProveedor";
            lbTituloProveedor.Size = new Size(178, 32);
            lbTituloProveedor.TabIndex = 0;
            lbTituloProveedor.Text = "PROVEEDOR";
            // 
            // tbDocumentoProveedor
            // 
            tbDocumentoProveedor.Location = new Point(41, 65);
            tbDocumentoProveedor.Name = "tbDocumentoProveedor";
            tbDocumentoProveedor.Size = new Size(277, 23);
            tbDocumentoProveedor.TabIndex = 1;
            tbDocumentoProveedor.Text = "Ingrese el documento";
            // 
            // tbNombreProveedor
            // 
            tbNombreProveedor.Location = new Point(41, 119);
            tbNombreProveedor.Name = "tbNombreProveedor";
            tbNombreProveedor.Size = new Size(277, 23);
            tbNombreProveedor.TabIndex = 2;
            tbNombreProveedor.Text = "Ingrese el nombre";
            // 
            // tbTelefonoProveedor
            // 
            tbTelefonoProveedor.Location = new Point(41, 174);
            tbTelefonoProveedor.Name = "tbTelefonoProveedor";
            tbTelefonoProveedor.Size = new Size(277, 23);
            tbTelefonoProveedor.TabIndex = 3;
            tbTelefonoProveedor.Text = "Ingrese el telefono";
            // 
            // btIngresarProveedor
            // 
            btIngresarProveedor.BackColor = SystemColors.ActiveCaption;
            btIngresarProveedor.Location = new Point(118, 279);
            btIngresarProveedor.Name = "btIngresarProveedor";
            btIngresarProveedor.Size = new Size(117, 48);
            btIngresarProveedor.TabIndex = 4;
            btIngresarProveedor.Text = "INGRESAR";
            btIngresarProveedor.UseVisualStyleBackColor = false;
            btIngresarProveedor.Click += btIngresarProveedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 226);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Proveedor registrado:";
            label1.Click += label1_Click;
            // 
            // Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 339);
            Controls.Add(label1);
            Controls.Add(btIngresarProveedor);
            Controls.Add(tbTelefonoProveedor);
            Controls.Add(tbNombreProveedor);
            Controls.Add(tbDocumentoProveedor);
            Controls.Add(lbTituloProveedor);
            Name = "Proveedor";
            Text = "Proveedor";
            Load += Proveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloProveedor;
        private TextBox tbDocumentoProveedor;
        private TextBox tbNombreProveedor;
        private TextBox tbTelefonoProveedor;
        private Button btIngresarProveedor;
        private Label label1;
    }
}