﻿namespace Principal
{
    partial class SubMenuVentas
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
            btSubMenuConsultarVenta = new Button();
            btSubMenuRegistrarVenta = new Button();
            lbTituloSubMenuVentas = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // btSubMenuConsultarVenta
            // 
            btSubMenuConsultarVenta.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarVenta.Location = new Point(203, 119);
            btSubMenuConsultarVenta.Name = "btSubMenuConsultarVenta";
            btSubMenuConsultarVenta.Size = new Size(116, 53);
            btSubMenuConsultarVenta.TabIndex = 15;
            btSubMenuConsultarVenta.Text = "Consultar Venta";
            btSubMenuConsultarVenta.UseVisualStyleBackColor = false;
            btSubMenuConsultarVenta.Click += btSubMenuConsultarVenta_Click;
            // 
            // btSubMenuRegistrarVenta
            // 
            btSubMenuRegistrarVenta.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarVenta.Location = new Point(61, 119);
            btSubMenuRegistrarVenta.Name = "btSubMenuRegistrarVenta";
            btSubMenuRegistrarVenta.Size = new Size(116, 53);
            btSubMenuRegistrarVenta.TabIndex = 14;
            btSubMenuRegistrarVenta.Text = "Registrar Venta";
            btSubMenuRegistrarVenta.UseVisualStyleBackColor = false;
            btSubMenuRegistrarVenta.Click += btSubMenuRegistrarVenta_Click;
            // 
            // lbTituloSubMenuVentas
            // 
            lbTituloSubMenuVentas.AutoSize = true;
            lbTituloSubMenuVentas.BackColor = Color.Snow;
            lbTituloSubMenuVentas.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuVentas.Location = new Point(62, 51);
            lbTituloSubMenuVentas.Name = "lbTituloSubMenuVentas";
            lbTituloSubMenuVentas.Size = new Size(257, 32);
            lbTituloSubMenuVentas.TabIndex = 13;
            lbTituloSubMenuVentas.Text = "SUBMENU VENTAS";
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 16;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // SubMenuVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 203);
            Controls.Add(btVolver);
            Controls.Add(btSubMenuConsultarVenta);
            Controls.Add(btSubMenuRegistrarVenta);
            Controls.Add(lbTituloSubMenuVentas);
            Name = "SubMenuVentas";
            Text = "SubMenuVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSubMenuConsultarVenta;
        private Button btSubMenuRegistrarVenta;
        private Label lbTituloSubMenuVentas;
        private Button btVolver;
    }
}