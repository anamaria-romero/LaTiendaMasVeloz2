namespace Principal
{
    partial class EliminarProveedor
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
            btEliminarProveedor = new Button();
            lbMostrarProveedor = new Label();
            tbDocumento = new TextBox();
            label1 = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // btEliminarProveedor
            // 
            btEliminarProveedor.BackColor = SystemColors.ActiveCaption;
            btEliminarProveedor.Location = new Point(103, 196);
            btEliminarProveedor.Name = "btEliminarProveedor";
            btEliminarProveedor.Size = new Size(153, 60);
            btEliminarProveedor.TabIndex = 7;
            btEliminarProveedor.Text = "ELIMINAR";
            btEliminarProveedor.UseVisualStyleBackColor = false;
            btEliminarProveedor.Click += btEliminarProveedor_Click;
            // 
            // lbMostrarProveedor
            // 
            lbMostrarProveedor.AutoSize = true;
            lbMostrarProveedor.Location = new Point(41, 141);
            lbMostrarProveedor.Name = "lbMostrarProveedor";
            lbMostrarProveedor.Size = new Size(64, 15);
            lbMostrarProveedor.TabIndex = 6;
            lbMostrarProveedor.Text = "Proveedor:";
            lbMostrarProveedor.Click += lbMostrarProveedor_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(41, 93);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(287, 23);
            tbDocumento.TabIndex = 5;
            tbDocumento.Text = "Ingresa el documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(321, 32);
            label1.TabIndex = 4;
            label1.Text = "Eliminar Proveedor";
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 28;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // EliminarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 268);
            Controls.Add(btVolver);
            Controls.Add(btEliminarProveedor);
            Controls.Add(lbMostrarProveedor);
            Controls.Add(tbDocumento);
            Controls.Add(label1);
            Name = "EliminarProveedor";
            Text = "EliminarProveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEliminarProveedor;
        private Label lbMostrarProveedor;
        private TextBox tbDocumento;
        private Label label1;
        private Button btVolver;
    }
}