﻿namespace Principal
{
    partial class ConsultarProducto
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
            lbMostrarProducto = new Label();
            btConsultar = new Button();
            tbIdentificador = new TextBox();
            lbTituloConsultarProductos = new Label();
            btVolver = new Button();
            SuspendLayout();
            // 
            // lbMostrarProducto
            // 
            lbMostrarProducto.AutoSize = true;
            lbMostrarProducto.Location = new Point(62, 139);
            lbMostrarProducto.Name = "lbMostrarProducto";
            lbMostrarProducto.Size = new Size(59, 15);
            lbMostrarProducto.TabIndex = 16;
            lbMostrarProducto.Text = "Producto:";
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(119, 219);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 46);
            btConsultar.TabIndex = 15;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbIdentificador
            // 
            tbIdentificador.Location = new Point(62, 94);
            tbIdentificador.Name = "tbIdentificador";
            tbIdentificador.Size = new Size(241, 23);
            tbIdentificador.TabIndex = 14;
            tbIdentificador.Text = "Ingresar Identificador";
            // 
            // lbTituloConsultarProductos
            // 
            lbTituloConsultarProductos.AutoSize = true;
            lbTituloConsultarProductos.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarProductos.Location = new Point(14, 43);
            lbTituloConsultarProductos.Name = "lbTituloConsultarProductos";
            lbTituloConsultarProductos.Size = new Size(343, 32);
            lbTituloConsultarProductos.TabIndex = 13;
            lbTituloConsultarProductos.Text = "CONSULTAR PRODUCTOS";
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 33;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // ConsultarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 271);
            Controls.Add(btVolver);
            Controls.Add(lbMostrarProducto);
            Controls.Add(btConsultar);
            Controls.Add(tbIdentificador);
            Controls.Add(lbTituloConsultarProductos);
            Name = "ConsultarProducto";
            Text = "ConsultarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarProducto;
        private Button btConsultar;
        private TextBox tbIdentificador;
        private Label lbTituloConsultarProductos;
        private Button btVolver;
    }
}