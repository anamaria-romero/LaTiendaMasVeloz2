namespace Principal
{
    partial class ConsultarEmpleados
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
            lbMostrarEmpleado = new Label();
            btConsultar = new Button();
            tbDocumento = new TextBox();
            lbTituloConsultarEmpleados = new Label();
            SuspendLayout();
            // 
            // lbMostrarEmpleado
            // 
            lbMostrarEmpleado.AutoSize = true;
            lbMostrarEmpleado.Location = new Point(106, 181);
            lbMostrarEmpleado.Name = "lbMostrarEmpleado";
            lbMostrarEmpleado.Size = new Size(63, 15);
            lbMostrarEmpleado.TabIndex = 16;
            lbMostrarEmpleado.Text = "Empleado:";
            lbMostrarEmpleado.Click += lbMostrarEmpleado_Click;
            // 
            // btConsultar
            // 
            btConsultar.BackColor = SystemColors.ActiveCaption;
            btConsultar.Location = new Point(159, 224);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(127, 63);
            btConsultar.TabIndex = 15;
            btConsultar.Text = "CONSULTAR";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(106, 131);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(241, 23);
            tbDocumento.TabIndex = 14;
            tbDocumento.Text = "Ingresar Documento";
            tbDocumento.TextChanged += tbDocumento_TextChanged;
            // 
            // lbTituloConsultarEmpleados
            // 
            lbTituloConsultarEmpleados.AutoSize = true;
            lbTituloConsultarEmpleados.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloConsultarEmpleados.Location = new Point(68, 57);
            lbTituloConsultarEmpleados.Name = "lbTituloConsultarEmpleados";
            lbTituloConsultarEmpleados.Size = new Size(341, 32);
            lbTituloConsultarEmpleados.TabIndex = 13;
            lbTituloConsultarEmpleados.Text = "CONSULTAR EMPLEADOS";
            // 
            // ConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 344);
            Controls.Add(lbMostrarEmpleado);
            Controls.Add(btConsultar);
            Controls.Add(tbDocumento);
            Controls.Add(lbTituloConsultarEmpleados);
            Name = "ConsultarEmpleados";
            Text = "ConsultarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarEmpleado;
        private Button btConsultar;
        private TextBox tbDocumento;
        private Label lbTituloConsultarEmpleados;
    }
}