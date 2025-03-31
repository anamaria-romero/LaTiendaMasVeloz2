namespace Principal
{
    partial class Inventario
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
            lbTituloInventario = new Label();
            btListaProductos = new Button();
            SuspendLayout();
            // 
            // lbTituloInventario
            // 
            lbTituloInventario.AutoSize = true;
            lbTituloInventario.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloInventario.Location = new Point(114, 101);
            lbTituloInventario.Name = "lbTituloInventario";
            lbTituloInventario.Size = new Size(183, 32);
            lbTituloInventario.TabIndex = 0;
            lbTituloInventario.Text = "INVENTARIO";
            // 
            // btListaProductos
            // 
            btListaProductos.BackColor = SystemColors.ActiveCaption;
            btListaProductos.Location = new Point(114, 167);
            btListaProductos.Name = "btListaProductos";
            btListaProductos.Size = new Size(183, 62);
            btListaProductos.TabIndex = 1;
            btListaProductos.Text = "Lista Productos";
            btListaProductos.UseVisualStyleBackColor = false;
            btListaProductos.Click += btListaProductos_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(416, 430);
            Controls.Add(btListaProductos);
            Controls.Add(lbTituloInventario);
            Name = "Inventario";
            Text = "Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloInventario;
        private Button btListaProductos;
    }
}