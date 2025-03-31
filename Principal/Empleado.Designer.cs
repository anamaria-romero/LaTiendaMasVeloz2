namespace Principal
{
    partial class Empleado
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
            lbTitulo = new Label();
            tbNombreEmpleado = new TextBox();
            tbCargo = new TextBox();
            btIngresarEmpleado = new Button();
            tbDocumentoEmpleado = new TextBox();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(197, 63);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(158, 32);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "EMPLEADO";
            // 
            // tbNombreEmpleado
            // 
            tbNombreEmpleado.Location = new Point(131, 167);
            tbNombreEmpleado.Name = "tbNombreEmpleado";
            tbNombreEmpleado.Size = new Size(280, 23);
            tbNombreEmpleado.TabIndex = 1;
            tbNombreEmpleado.Text = "Ingrese el nombre";
            tbNombreEmpleado.TextChanged += tbNombreEmpleado_TextChanged;
            // 
            // tbCargo
            // 
            tbCargo.Location = new Point(131, 221);
            tbCargo.Name = "tbCargo";
            tbCargo.Size = new Size(280, 23);
            tbCargo.TabIndex = 2;
            tbCargo.Text = "Ingrese el cargo";
            tbCargo.TextChanged += tbCargo_TextChanged;
            // 
            // btIngresarEmpleado
            // 
            btIngresarEmpleado.BackColor = SystemColors.ActiveCaption;
            btIngresarEmpleado.Location = new Point(213, 286);
            btIngresarEmpleado.Name = "btIngresarEmpleado";
            btIngresarEmpleado.Size = new Size(130, 50);
            btIngresarEmpleado.TabIndex = 3;
            btIngresarEmpleado.Text = "REGISTRAR";
            btIngresarEmpleado.UseVisualStyleBackColor = false;
            btIngresarEmpleado.Click += btIngresarEmpleado_Click;
            // 
            // tbDocumentoEmpleado
            // 
            tbDocumentoEmpleado.Location = new Point(131, 120);
            tbDocumentoEmpleado.Name = "tbDocumentoEmpleado";
            tbDocumentoEmpleado.Size = new Size(280, 23);
            tbDocumentoEmpleado.TabIndex = 4;
            tbDocumentoEmpleado.Text = "Ingrese el documento";
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(555, 450);
            Controls.Add(tbDocumentoEmpleado);
            Controls.Add(btIngresarEmpleado);
            Controls.Add(tbCargo);
            Controls.Add(tbNombreEmpleado);
            Controls.Add(lbTitulo);
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox tbNombreEmpleado;
        private TextBox tbCargo;
        private Button btIngresarEmpleado;
        private TextBox tbDocumentoEmpleado;
    }
}