namespace Principal
{
    partial class SubMenuEmpleados
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
            btSubMenuEliminarEmpleado = new Button();
            btSubMenuConsultarEmpleado = new Button();
            btSubMenuActualizarEmpleado = new Button();
            btSubMenuRegistrarEmpleado = new Button();
            lbTituloSubMenuEmpleados = new Label();
            SuspendLayout();
            // 
            // btSubMenuEliminarEmpleado
            // 
            btSubMenuEliminarEmpleado.BackColor = SystemColors.ActiveCaption;
            btSubMenuEliminarEmpleado.Location = new Point(268, 210);
            btSubMenuEliminarEmpleado.Name = "btSubMenuEliminarEmpleado";
            btSubMenuEliminarEmpleado.Size = new Size(116, 53);
            btSubMenuEliminarEmpleado.TabIndex = 9;
            btSubMenuEliminarEmpleado.Text = "Eliminar Empleado";
            btSubMenuEliminarEmpleado.UseVisualStyleBackColor = false;
            btSubMenuEliminarEmpleado.Click += btSubMenuEliminarEmpleado_Click;
            // 
            // btSubMenuConsultarEmpleado
            // 
            btSubMenuConsultarEmpleado.BackColor = SystemColors.ActiveCaption;
            btSubMenuConsultarEmpleado.Location = new Point(126, 210);
            btSubMenuConsultarEmpleado.Name = "btSubMenuConsultarEmpleado";
            btSubMenuConsultarEmpleado.Size = new Size(116, 53);
            btSubMenuConsultarEmpleado.TabIndex = 8;
            btSubMenuConsultarEmpleado.Text = "Consultar Empleado";
            btSubMenuConsultarEmpleado.UseVisualStyleBackColor = false;
            btSubMenuConsultarEmpleado.Click += btSubMenuConsultarEmpleado_Click;
            // 
            // btSubMenuActualizarEmpleado
            // 
            btSubMenuActualizarEmpleado.BackColor = SystemColors.ActiveCaption;
            btSubMenuActualizarEmpleado.Location = new Point(268, 125);
            btSubMenuActualizarEmpleado.Name = "btSubMenuActualizarEmpleado";
            btSubMenuActualizarEmpleado.Size = new Size(116, 53);
            btSubMenuActualizarEmpleado.TabIndex = 7;
            btSubMenuActualizarEmpleado.Text = "Actualizar Empleado";
            btSubMenuActualizarEmpleado.UseVisualStyleBackColor = false;
            btSubMenuActualizarEmpleado.Click += btSubMenuActualizarEmpleado_Click;
            // 
            // btSubMenuRegistrarEmpleado
            // 
            btSubMenuRegistrarEmpleado.BackColor = SystemColors.ActiveCaption;
            btSubMenuRegistrarEmpleado.Location = new Point(126, 125);
            btSubMenuRegistrarEmpleado.Name = "btSubMenuRegistrarEmpleado";
            btSubMenuRegistrarEmpleado.Size = new Size(116, 53);
            btSubMenuRegistrarEmpleado.TabIndex = 6;
            btSubMenuRegistrarEmpleado.Text = "Registrar Empleado";
            btSubMenuRegistrarEmpleado.UseVisualStyleBackColor = false;
            btSubMenuRegistrarEmpleado.Click += btSubMenuRegistrarEmpleado_Click;
            // 
            // lbTituloSubMenuEmpleados
            // 
            lbTituloSubMenuEmpleados.AutoSize = true;
            lbTituloSubMenuEmpleados.BackColor = Color.Snow;
            lbTituloSubMenuEmpleados.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloSubMenuEmpleados.Location = new Point(113, 58);
            lbTituloSubMenuEmpleados.Name = "lbTituloSubMenuEmpleados";
            lbTituloSubMenuEmpleados.Size = new Size(313, 32);
            lbTituloSubMenuEmpleados.TabIndex = 5;
            lbTituloSubMenuEmpleados.Text = "SUBMENU EMPLEADOS";
            // 
            // SubMenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 351);
            Controls.Add(btSubMenuEliminarEmpleado);
            Controls.Add(btSubMenuConsultarEmpleado);
            Controls.Add(btSubMenuActualizarEmpleado);
            Controls.Add(btSubMenuRegistrarEmpleado);
            Controls.Add(lbTituloSubMenuEmpleados);
            Name = "SubMenuEmpleados";
            Text = "SubMenuEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSubMenuEliminarEmpleado;
        private Button btSubMenuConsultarEmpleado;
        private Button btSubMenuActualizarEmpleado;
        private Button btSubMenuRegistrarEmpleado;
        private Label lbTituloSubMenuEmpleados;
    }
}