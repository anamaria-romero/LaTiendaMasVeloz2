﻿namespace Principal
{
    partial class EliminarProducto
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
            btEliminarProducto = new Button();
            lbMostrarProducto = new Label();
            tbIdentificador = new TextBox();
            lbEliminarProductos = new Label();
            SuspendLayout();
            // 
            // btEliminarProducto
            // 
            btEliminarProducto.BackColor = SystemColors.ActiveCaption;
            btEliminarProducto.Location = new Point(125, 216);
            btEliminarProducto.Name = "btEliminarProducto";
            btEliminarProducto.Size = new Size(153, 60);
            btEliminarProducto.TabIndex = 7;
            btEliminarProducto.Text = "ELIMINAR";
            btEliminarProducto.UseVisualStyleBackColor = false;
            btEliminarProducto.Click += btEliminarProducto_Click;
            // 
            // lbMostrarProducto
            // 
            lbMostrarProducto.AutoSize = true;
            lbMostrarProducto.Location = new Point(65, 159);
            lbMostrarProducto.Name = "lbMostrarProducto";
            lbMostrarProducto.Size = new Size(59, 15);
            lbMostrarProducto.TabIndex = 6;
            lbMostrarProducto.Text = "Producto:";
            // 
            // tbIdentificador
            // 
            tbIdentificador.Location = new Point(65, 107);
            tbIdentificador.Name = "tbIdentificador";
            tbIdentificador.Size = new Size(287, 23);
            tbIdentificador.TabIndex = 5;
            tbIdentificador.Text = "Ingresa el identificador";
            // 
            // lbEliminarProductos
            // 
            lbEliminarProductos.AutoSize = true;
            lbEliminarProductos.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarProductos.Location = new Point(65, 38);
            lbEliminarProductos.Name = "lbEliminarProductos";
            lbEliminarProductos.Size = new Size(319, 32);
            lbEliminarProductos.TabIndex = 4;
            lbEliminarProductos.Text = "Eliminar Productos";
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 340);
            Controls.Add(btEliminarProducto);
            Controls.Add(lbMostrarProducto);
            Controls.Add(tbIdentificador);
            Controls.Add(lbEliminarProductos);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEliminarProducto;
        private Label lbMostrarProducto;
        private TextBox tbIdentificador;
        private Label lbEliminarProductos;
    }
}