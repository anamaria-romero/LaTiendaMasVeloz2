namespace Principal
{
    partial class ConsultarProveedores
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
            lbMostrarProveedor = new Label();
            btConsultar = new Button();
            tbDocumento = new TextBox();
            lbTituloConsultarProveedor = new Label();
            SuspendLayout();
            // 
            // lbMostrarProveedor
            // 
            lbMostrarProveedor.AutoSize = true;
            lbMostrarProveedor.Location = new Point(105, 192);
            lbMostrarProveedor.Name = "lbMostrarProveedor";
            lbMostrarProveedor.Size = new Size(64, 15);
            lbMostrarProveedor.TabIndex = 16;
            lbMostrarProveedor.Text = "Proveedor:";
            lbMostrarProveedor.Click += lbMostrarProveedor_Click;
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(158, 235);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 63);
            btConsultar.TabIndex = 15;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(105, 142);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 14;
            tbDocumento.Text = "Ingresar Documento";
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // lbTituloConsultarProveedor
            // 
            lbTituloConsultarProveedor.AutoSize = true;
            lbTituloConsultarProveedor.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarProveedor.Location = new Point(67, 68);
            lbTituloConsultarProveedor.Name = "lbTituloConsultarProveedor";
            lbTituloConsultarProveedor.Size = new Size(345, 32);
            lbTituloConsultarProveedor.TabIndex = 13;
            lbTituloConsultarProveedor.Text = "CONSULTAR PROVEEDOR";
            // 
            // ConsultarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 367);
            Controls.Add(lbMostrarProveedor);
            Controls.Add(btConsultar);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloConsultarProveedor);
            Name = "ConsultarProveedores";
            Text = "ConsultarProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarProveedor;
        private Button btConsultar;
        private TextBox tbDocumento;
        private Label lbTituloConsultarProveedor;
    }
}