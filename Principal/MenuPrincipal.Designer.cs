﻿namespace Principal
{
    partial class MenuPrincipal
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
            btVentas = new Button();
            btProveedores = new Button();
            btInventario = new Button();
            btEmpleados = new Button();
            btClientes = new Button();
            lbTituloPagina = new Label();
            lbTituloMenu = new Label();
            SuspendLayout();
            // 
            // btVentas
            // 
            btVentas.BackColor = SystemColors.ActiveCaption;
            btVentas.Location = new Point(201, 338);
            btVentas.Name = "btVentas";
            btVentas.Size = new Size(115, 56);
            btVentas.TabIndex = 13;
            btVentas.Text = "VENTAS";
            btVentas.UseVisualStyleBackColor = false;
            btVentas.Click += btVentas_Click;
            // 
            // btProveedores
            // 
            btProveedores.BackColor = SystemColors.ActiveCaption;
            btProveedores.Location = new Point(269, 254);
            btProveedores.Name = "btProveedores";
            btProveedores.Size = new Size(115, 56);
            btProveedores.TabIndex = 12;
            btProveedores.Text = "PROVEEDORES";
            btProveedores.UseVisualStyleBackColor = false;
            btProveedores.Click += btProveedores_Click;
            // 
            // btInventario
            // 
            btInventario.BackColor = SystemColors.ActiveCaption;
            btInventario.Location = new Point(126, 254);
            btInventario.Name = "btInventario";
            btInventario.Size = new Size(115, 56);
            btInventario.TabIndex = 11;
            btInventario.Text = "INVENTARIO";
            btInventario.UseVisualStyleBackColor = false;
            btInventario.Click += btInventario_Click;
            // 
            // btEmpleados
            // 
            btEmpleados.BackColor = SystemColors.ActiveCaption;
            btEmpleados.Location = new Point(269, 169);
            btEmpleados.Name = "btEmpleados";
            btEmpleados.Size = new Size(115, 56);
            btEmpleados.TabIndex = 10;
            btEmpleados.Text = "EMPLEADOS";
            btEmpleados.UseVisualStyleBackColor = false;
            btEmpleados.Click += btEmpleados_Click;
            // 
            // btClientes
            // 
            btClientes.BackColor = SystemColors.ActiveCaption;
            btClientes.Location = new Point(126, 169);
            btClientes.Name = "btClientes";
            btClientes.Size = new Size(115, 56);
            btClientes.TabIndex = 9;
            btClientes.Text = "CLIENTES";
            btClientes.UseVisualStyleBackColor = false;
            btClientes.Click += btClientes_Click;
            // 
            // lbTituloPagina
            // 
            lbTituloPagina.AutoSize = true;
            lbTituloPagina.Font = new Font("Snap ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloPagina.Location = new Point(40, 40);
            lbTituloPagina.Name = "lbTituloPagina";
            lbTituloPagina.Size = new Size(434, 37);
            lbTituloPagina.TabIndex = 8;
            lbTituloPagina.Text = "LA TIENDA MAS VELOZ";
            // 
            // lbTituloMenu
            // 
            lbTituloMenu.AutoSize = true;
            lbTituloMenu.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloMenu.Location = new Point(146, 97);
            lbTituloMenu.Name = "lbTituloMenu";
            lbTituloMenu.Size = new Size(223, 29);
            lbTituloMenu.TabIndex = 7;
            lbTituloMenu.Text = "MENU PRINCIPAL";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(btVentas);
            Controls.Add(btProveedores);
            Controls.Add(btInventario);
            Controls.Add(btEmpleados);
            Controls.Add(btClientes);
            Controls.Add(lbTituloPagina);
            Controls.Add(lbTituloMenu);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVentas;
        private Button btProveedores;
        private Button btInventario;
        private Button btEmpleados;
        private Button btClientes;
        private Label lbTituloPagina;
        private Label lbTituloMenu;
    }
}