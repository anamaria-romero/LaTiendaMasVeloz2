namespace Principal
{
    partial class EliminarFactura
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
            btVolver = new Button();
            btEliminarFactura = new Button();
            lbMostrarFactura = new Label();
            tbIdentificador = new TextBox();
            lbEliminarFactura = new Label();
            SuspendLayout();
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 37;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // btEliminarFactura
            // 
            btEliminarFactura.BackColor = SystemColors.ActiveCaption;
            btEliminarFactura.Location = new Point(107, 243);
            btEliminarFactura.Name = "btEliminarFactura";
            btEliminarFactura.Size = new Size(141, 50);
            btEliminarFactura.TabIndex = 36;
            btEliminarFactura.Text = "ELIMINAR";
            btEliminarFactura.UseVisualStyleBackColor = false;
            btEliminarFactura.Click += btEliminarFactura_Click;
            // 
            // lbMostrarFactura
            // 
            lbMostrarFactura.AutoSize = true;
            lbMostrarFactura.Location = new Point(40, 136);
            lbMostrarFactura.Name = "lbMostrarFactura";
            lbMostrarFactura.Size = new Size(49, 15);
            lbMostrarFactura.TabIndex = 35;
            lbMostrarFactura.Text = "Factura:";
            lbMostrarFactura.Click += lbMostrarFactura_Click;
            // 
            // tbIdentificador
            // 
            tbIdentificador.Location = new Point(40, 94);
            tbIdentificador.Name = "tbIdentificador";
            tbIdentificador.Size = new Size(286, 23);
            tbIdentificador.TabIndex = 34;
            tbIdentificador.Text = "Ingresa el identificador";
            tbIdentificador.TextChanged += tbIdentificador_TextChanged;
            // 
            // lbEliminarFactura
            // 
            lbEliminarFactura.AutoSize = true;
            lbEliminarFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarFactura.Location = new Point(40, 39);
            lbEliminarFactura.Name = "lbEliminarFactura";
            lbEliminarFactura.Size = new Size(282, 32);
            lbEliminarFactura.TabIndex = 33;
            lbEliminarFactura.Text = "Eliminar Factura";
            // 
            // EliminarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 305);
            Controls.Add(btVolver);
            Controls.Add(btEliminarFactura);
            Controls.Add(lbMostrarFactura);
            Controls.Add(tbIdentificador);
            Controls.Add(lbEliminarFactura);
            Name = "EliminarFactura";
            Text = "EliminarFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVolver;
        private Button btEliminarFactura;
        private Label lbMostrarFactura;
        private TextBox tbIdentificador;
        private Label lbEliminarFactura;
    }
}