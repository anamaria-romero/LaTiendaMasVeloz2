namespace Principal
{
    partial class EliminarEmpleados
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
            btEliminarEmpleados = new Button();
            lbMostrarEmpleado = new Label();
            tbDocumento = new TextBox();
            lbEliminarEmpleados = new Label();
            SuspendLayout();
            // 
            // btEliminarEmpleados
            // 
            btEliminarEmpleados.BackColor = SystemColors.ActiveCaption;
            btEliminarEmpleados.Location = new Point(117, 242);
            btEliminarEmpleados.Name = "btEliminarEmpleados";
            btEliminarEmpleados.Size = new Size(153, 60);
            btEliminarEmpleados.TabIndex = 7;
            btEliminarEmpleados.Text = "ELIMINAR";
            btEliminarEmpleados.UseVisualStyleBackColor = false;
            // 
            // lbMostrarEmpleado
            // 
            lbMostrarEmpleado.AutoSize = true;
            lbMostrarEmpleado.Location = new Point(57, 185);
            lbMostrarEmpleado.Name = "lbMostrarEmpleado";
            lbMostrarEmpleado.Size = new Size(63, 15);
            lbMostrarEmpleado.TabIndex = 6;
            lbMostrarEmpleado.Text = "Empleado:";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(57, 133);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(287, 23);
            tbDocumento.TabIndex = 5;
            tbDocumento.Text = "Ingresa el documento";
            // 
            // lbEliminarEmpleados
            // 
            lbEliminarEmpleados.AutoSize = true;
            lbEliminarEmpleados.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarEmpleados.Location = new Point(57, 64);
            lbEliminarEmpleados.Name = "lbEliminarEmpleados";
            lbEliminarEmpleados.Size = new Size(317, 32);
            lbEliminarEmpleados.TabIndex = 4;
            lbEliminarEmpleados.Text = "Eliminar Empleados";
            // 
            // EliminarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 366);
            Controls.Add(btEliminarEmpleados);
            Controls.Add(lbMostrarEmpleado);
            Controls.Add(tbDocumento);
            Controls.Add(lbEliminarEmpleados);
            Name = "EliminarEmpleados";
            Text = "EliminarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEliminarEmpleados;
        private Label lbMostrarEmpleado;
        private TextBox tbDocumento;
        private Label lbEliminarEmpleados;
    }
}