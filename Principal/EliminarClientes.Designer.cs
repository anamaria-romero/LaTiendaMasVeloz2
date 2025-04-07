namespace Principal
{
    partial class EliminarClientes
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
            label1 = new Label();
            tbDocumento = new TextBox();
            lbMostrarCliente = new Label();
            btEliminarCliente = new Button();
            btVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 0;
            label1.Text = "Eliminar Clientes";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(39, 96);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(287, 23);
            tbDocumento.TabIndex = 1;
            tbDocumento.Text = "Ingresa el documento";
            // 
            // lbMostrarCliente
            // 
            lbMostrarCliente.AutoSize = true;
            lbMostrarCliente.Location = new Point(39, 146);
            lbMostrarCliente.Name = "lbMostrarCliente";
            lbMostrarCliente.Size = new Size(47, 15);
            lbMostrarCliente.TabIndex = 2;
            lbMostrarCliente.Text = "Cliente:";
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.BackColor = SystemColors.ActiveCaption;
            btEliminarCliente.Location = new Point(111, 198);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(136, 51);
            btEliminarCliente.TabIndex = 3;
            btEliminarCliente.Text = "ELIMINAR";
            btEliminarCliente.UseVisualStyleBackColor = false;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // btVolver
            // 
            btVolver.BackColor = SystemColors.GradientInactiveCaption;
            btVolver.Location = new Point(12, 12);
            btVolver.Name = "btVolver";
            btVolver.Size = new Size(56, 24);
            btVolver.TabIndex = 38;
            btVolver.Text = "Volver";
            btVolver.UseVisualStyleBackColor = false;
            btVolver.Click += btVolver_Click;
            // 
            // EliminarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 260);
            Controls.Add(btVolver);
            Controls.Add(btEliminarCliente);
            Controls.Add(lbMostrarCliente);
            Controls.Add(tbDocumento);
            Controls.Add(label1);
            Name = "EliminarClientes";
            Text = "EliminarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDocumento;
        private Label lbMostrarCliente;
        private Button btEliminarCliente;
        private Button btVolver;
    }
}