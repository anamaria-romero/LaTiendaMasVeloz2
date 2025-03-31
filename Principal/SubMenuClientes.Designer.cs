namespace Principal
{
    partial class SubMenuClientes
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
            lbTituloSubMenuClientes = new Label();
            btSubMenuRegistrarCliente = new Button();
            btSubMenuActualizarCliente = new Button();
            btSubMenuConsultarCliente = new Button();
            btSubMenuEliminarCliente = new Button();
            SuspendLayout();
            // 
            // lbTituloSubMenuClientes
            // 
            lbTituloSubMenuClientes.AutoSize = true;
            lbTituloSubMenuClientes.BackColor = Color.Snow;
            lbTituloSubMenuClientes.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuClientes.Location = new Point(80, 64);
            lbTituloSubMenuClientes.Name = "lbTituloSubMenuClientes";
            lbTituloSubMenuClientes.Size = new Size(283, 32);
            lbTituloSubMenuClientes.TabIndex = 0;
            lbTituloSubMenuClientes.Text = "SUBMENU CLIENTES";
            // 
            // btSubMenuRegistrarCliente
            // 
            btSubMenuRegistrarCliente.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarCliente.Location = new Point(93, 131);
            btSubMenuRegistrarCliente.Name = "btSubMenuRegistrarCliente";
            btSubMenuRegistrarCliente.Size = new Size(116, 53);
            btSubMenuRegistrarCliente.TabIndex = 1;
            btSubMenuRegistrarCliente.Text = "Registrar Cliente";
            btSubMenuRegistrarCliente.UseVisualStyleBackColor = false;
            btSubMenuRegistrarCliente.Click += btSubMenuRegistrarCliente_Click;
            // 
            // btSubMenuActualizarCliente
            // 
            btSubMenuActualizarCliente.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarCliente.Location = new Point(235, 131);
            btSubMenuActualizarCliente.Name = "btSubMenuActualizarCliente";
            btSubMenuActualizarCliente.Size = new Size(116, 53);
            btSubMenuActualizarCliente.TabIndex = 2;
            btSubMenuActualizarCliente.Text = "Actualizar Cliente";
            btSubMenuActualizarCliente.UseVisualStyleBackColor = false;
            btSubMenuActualizarCliente.Click += btSubMenuActualizarCliente_Click;
            // 
            // btSubMenuConsultarCliente
            // 
            btSubMenuConsultarCliente.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarCliente.Location = new Point(93, 216);
            btSubMenuConsultarCliente.Name = "btSubMenuConsultarCliente";
            btSubMenuConsultarCliente.Size = new Size(116, 53);
            btSubMenuConsultarCliente.TabIndex = 3;
            btSubMenuConsultarCliente.Text = "Consultar Cliente";
            btSubMenuConsultarCliente.UseVisualStyleBackColor = false;
            btSubMenuConsultarCliente.Click += btSubMenuConsultarCliente_Click;
            // 
            // btSubMenuEliminarCliente
            // 
            btSubMenuEliminarCliente.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarCliente.Location = new Point(235, 216);
            btSubMenuEliminarCliente.Name = "btSubMenuEliminarCliente";
            btSubMenuEliminarCliente.Size = new Size(116, 53);
            btSubMenuEliminarCliente.TabIndex = 4;
            btSubMenuEliminarCliente.Text = "Eliminar Cliente";
            btSubMenuEliminarCliente.UseVisualStyleBackColor = false;
            btSubMenuEliminarCliente.Click += btSubMenuEliminarCliente_Click;
            // 
            // SubMenuClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 450);
            Controls.Add(btSubMenuEliminarCliente);
            Controls.Add(btSubMenuConsultarCliente);
            Controls.Add(btSubMenuActualizarCliente);
            Controls.Add(btSubMenuRegistrarCliente);
            Controls.Add(lbTituloSubMenuClientes);
            Name = "SubMenuClientes";
            Text = "SubMenuClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloSubMenuClientes;
        private Button btSubMenuRegistrarCliente;
        private Button btSubMenuActualizarCliente;
        private Button btSubMenuConsultarCliente;
        private Button btSubMenuEliminarCliente;
    }
}