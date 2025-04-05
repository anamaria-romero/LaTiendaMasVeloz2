namespace Principal
{
    partial class SubMenuProveedores
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
            btSubMenuEliminarProveedores = new Button();
            btSubMenuConsultarProveedores = new Button();
            btSubMenuActualizarProveedores = new Button();
            btSubMenuRegistrarProveedores = new Button();
            lbTituloSubMenuProveedores = new Label();
            SuspendLayout();
            // 
            // btSubMenuEliminarProveedores
            // 
            btSubMenuEliminarProveedores.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarProveedores.Location = new Point(206, 176);
            btSubMenuEliminarProveedores.Name = "btSubMenuEliminarProveedores";
            btSubMenuEliminarProveedores.Size = new Size(116, 53);
            btSubMenuEliminarProveedores.TabIndex = 14;
            btSubMenuEliminarProveedores.Text = "Eliminar Proveedores";
            btSubMenuEliminarProveedores.UseVisualStyleBackColor = false;
            btSubMenuEliminarProveedores.Click += btSubMenuEliminarProveedores_Click;
            // 
            // btSubMenuConsultarProveedores
            // 
            btSubMenuConsultarProveedores.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarProveedores.Location = new Point(64, 176);
            btSubMenuConsultarProveedores.Name = "btSubMenuConsultarProveedores";
            btSubMenuConsultarProveedores.Size = new Size(116, 53);
            btSubMenuConsultarProveedores.TabIndex = 13;
            btSubMenuConsultarProveedores.Text = "Consultar Proveedores";
            btSubMenuConsultarProveedores.UseVisualStyleBackColor = false;
            btSubMenuConsultarProveedores.Click += btSubMenuConsultarProveedores_Click;
            // 
            // btSubMenuActualizarProveedores
            // 
            btSubMenuActualizarProveedores.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarProveedores.Location = new Point(206, 91);
            btSubMenuActualizarProveedores.Name = "btSubMenuActualizarProveedores";
            btSubMenuActualizarProveedores.Size = new Size(116, 53);
            btSubMenuActualizarProveedores.TabIndex = 12;
            btSubMenuActualizarProveedores.Text = "Actualizar Proveedores";
            btSubMenuActualizarProveedores.UseVisualStyleBackColor = false;
            btSubMenuActualizarProveedores.Click += btSubMenuActualizarProveedores_Click;
            // 
            // btSubMenuRegistrarProveedores
            // 
            btSubMenuRegistrarProveedores.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarProveedores.Location = new Point(64, 91);
            btSubMenuRegistrarProveedores.Name = "btSubMenuRegistrarProveedores";
            btSubMenuRegistrarProveedores.Size = new Size(116, 53);
            btSubMenuRegistrarProveedores.TabIndex = 11;
            btSubMenuRegistrarProveedores.Text = "Registrar Proveedores";
            btSubMenuRegistrarProveedores.UseVisualStyleBackColor = false;
            btSubMenuRegistrarProveedores.Click += btSubMenuRegistrarProveedores_Click;
            // 
            // lbTituloSubMenuProveedores
            // 
            lbTituloSubMenuProveedores.AutoSize = true;
            lbTituloSubMenuProveedores.BackColor = Color.Snow;
            lbTituloSubMenuProveedores.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuProveedores.Location = new Point(23, 31);
            lbTituloSubMenuProveedores.Name = "lbTituloSubMenuProveedores";
            lbTituloSubMenuProveedores.Size = new Size(350, 32);
            lbTituloSubMenuProveedores.TabIndex = 10;
            lbTituloSubMenuProveedores.Text = "SUBMENU PROVEEDORES";
            // 
            // SubMenuProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 264);
            Controls.Add(btSubMenuEliminarProveedores);
            Controls.Add(btSubMenuConsultarProveedores);
            Controls.Add(btSubMenuActualizarProveedores);
            Controls.Add(btSubMenuRegistrarProveedores);
            Controls.Add(lbTituloSubMenuProveedores);
            Name = "SubMenuProveedores";
            Text = "SubMenuProveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSubMenuEliminarProveedores;
        private Button btSubMenuConsultarProveedores;
        private Button btSubMenuActualizarProveedores;
        private Button btSubMenuRegistrarProveedores;
        private Label lbTituloSubMenuProveedores;
    }
}