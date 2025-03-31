namespace Principal
{
    partial class Factura
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
            lbTituloFactura = new Label();
            FechaFactura = new DateTimePicker();
            tbIdFactura = new TextBox();
            tbNombreEmpleado = new TextBox();
            tbNombreCliente = new TextBox();
            SuspendLayout();
            // 
            // lbTituloFactura
            // 
            lbTituloFactura.AutoSize = true;
            lbTituloFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloFactura.Location = new Point(175, 20);
            lbTituloFactura.Name = "lbTituloFactura";
            lbTituloFactura.Size = new Size(139, 32);
            lbTituloFactura.TabIndex = 0;
            lbTituloFactura.Text = "FACTURA";
            // 
            // FechaFactura
            // 
            FechaFactura.Location = new Point(45, 101);
            FechaFactura.Name = "FechaFactura";
            FechaFactura.Size = new Size(200, 23);
            FechaFactura.TabIndex = 1;
            // 
            // tbIdFactura
            // 
            tbIdFactura.Location = new Point(45, 62);
            tbIdFactura.Name = "tbIdFactura";
            tbIdFactura.Size = new Size(100, 23);
            tbIdFactura.TabIndex = 2;
            tbIdFactura.Text = "Ingrese ID";
            // 
            // tbNombreEmpleado
            // 
            tbNombreEmpleado.Location = new Point(45, 139);
            tbNombreEmpleado.Name = "tbNombreEmpleado";
            tbNombreEmpleado.Size = new Size(200, 23);
            tbNombreEmpleado.TabIndex = 3;
            tbNombreEmpleado.Text = "Nombre Empleado";
            // 
            // tbNombreCliente
            // 
            tbNombreCliente.Location = new Point(45, 182);
            tbNombreCliente.Name = "tbNombreCliente";
            tbNombreCliente.Size = new Size(201, 23);
            tbNombreCliente.TabIndex = 4;
            tbNombreCliente.Text = "Nombre Cliente";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 450);
            Controls.Add(tbNombreCliente);
            Controls.Add(tbNombreEmpleado);
            Controls.Add(tbIdFactura);
            Controls.Add(FechaFactura);
            Controls.Add(lbTituloFactura);
            Name = "Factura";
            Text = "Factura";
            Load += Factura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloFactura;
        private DateTimePicker FechaFactura;
        private TextBox tbIdFactura;
        private TextBox tbNombreEmpleado;
        private TextBox tbNombreCliente;
    }
}