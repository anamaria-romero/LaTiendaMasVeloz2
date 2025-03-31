namespace Principal
{
    partial class Producto
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
            lbTituloProducto = new Label();
            tbReferenciaProducto = new TextBox();
            tbNombreProducto = new TextBox();
            tbMarcaProducto = new TextBox();
            tbPrecioProducto = new TextBox();
            btRegistrarProducto = new Button();
            tbCantidadProducto = new TextBox();
            tbIdentificadorProducto = new TextBox();
            SuspendLayout();
            // 
            // lbTituloProducto
            // 
            lbTituloProducto.AutoSize = true;
            lbTituloProducto.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloProducto.Location = new Point(167, 9);
            lbTituloProducto.Name = "lbTituloProducto";
            lbTituloProducto.Size = new Size(160, 32);
            lbTituloProducto.TabIndex = 0;
            lbTituloProducto.Text = "PRODUCTO";
            // 
            // tbReferenciaProducto
            // 
            tbReferenciaProducto.Location = new Point(108, 103);
            tbReferenciaProducto.Name = "tbReferenciaProducto";
            tbReferenciaProducto.Size = new Size(302, 23);
            tbReferenciaProducto.TabIndex = 1;
            tbReferenciaProducto.Text = "Ingrese la referencia";
            tbReferenciaProducto.TextChanged += tbReferenciaProducto_TextChanged;
            // 
            // tbNombreProducto
            // 
            tbNombreProducto.Location = new Point(108, 154);
            tbNombreProducto.Name = "tbNombreProducto";
            tbNombreProducto.Size = new Size(302, 23);
            tbNombreProducto.TabIndex = 2;
            tbNombreProducto.Text = "Ingrese el nombre";
            tbNombreProducto.TextChanged += tbNombreProducto_TextChanged;
            // 
            // tbMarcaProducto
            // 
            tbMarcaProducto.Location = new Point(108, 204);
            tbMarcaProducto.Name = "tbMarcaProducto";
            tbMarcaProducto.Size = new Size(302, 23);
            tbMarcaProducto.TabIndex = 3;
            tbMarcaProducto.Text = "Ingrese la marca";
            tbMarcaProducto.TextChanged += tbMarcaProducto_TextChanged;
            // 
            // tbPrecioProducto
            // 
            tbPrecioProducto.Location = new Point(108, 302);
            tbPrecioProducto.Name = "tbPrecioProducto";
            tbPrecioProducto.Size = new Size(302, 23);
            tbPrecioProducto.TabIndex = 5;
            tbPrecioProducto.Text = "Ingrese el precio";
            tbPrecioProducto.TextChanged += tbPrecioProducto_TextChanged;
            // 
            // btRegistrarProducto
            // 
            btRegistrarProducto.BackColor = SystemColors.ActiveCaption;
            btRegistrarProducto.Location = new Point(187, 349);
            btRegistrarProducto.Name = "btRegistrarProducto";
            btRegistrarProducto.Size = new Size(140, 50);
            btRegistrarProducto.TabIndex = 6;
            btRegistrarProducto.Text = "REGISTRAR";
            btRegistrarProducto.UseVisualStyleBackColor = false;
            btRegistrarProducto.Click += btRegistrarProducto_Click;
            // 
            // tbCantidadProducto
            // 
            tbCantidadProducto.Location = new Point(108, 253);
            tbCantidadProducto.Name = "tbCantidadProducto";
            tbCantidadProducto.Size = new Size(302, 23);
            tbCantidadProducto.TabIndex = 4;
            tbCantidadProducto.Text = "Ingrese la cantidad";
            tbCantidadProducto.TextChanged += tbCantidadProducto_TextChanged;
            // 
            // tbIdentificadorProducto
            // 
            tbIdentificadorProducto.Location = new Point(108, 55);
            tbIdentificadorProducto.Name = "tbIdentificadorProducto";
            tbIdentificadorProducto.Size = new Size(302, 23);
            tbIdentificadorProducto.TabIndex = 7;
            tbIdentificadorProducto.Text = "Ingrese el identificador";
            tbIdentificadorProducto.TextChanged += tbIdentificadorProducto_TextChanged;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 450);
            Controls.Add(tbIdentificadorProducto);
            Controls.Add(btRegistrarProducto);
            Controls.Add(tbPrecioProducto);
            Controls.Add(tbCantidadProducto);
            Controls.Add(tbMarcaProducto);
            Controls.Add(tbNombreProducto);
            Controls.Add(tbReferenciaProducto);
            Controls.Add(lbTituloProducto);
            Name = "Producto";
            Text = "Producto";
            Load += Producto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloProducto;
        private TextBox tbReferenciaProducto;
        private TextBox tbNombreProducto;
        private TextBox tbMarcaProducto;
        private TextBox tbPrecioProducto;
        private Button btRegistrarProducto;
        private TextBox tbCantidadProducto;
        private TextBox tbIdentificadorProducto;
    }
}