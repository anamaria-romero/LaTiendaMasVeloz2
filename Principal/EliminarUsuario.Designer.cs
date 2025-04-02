namespace Principal
{
    partial class EliminarUsuario
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
            btEliminarCliente = new Button();
            tbDocumento = new TextBox();
            lbEliminarUsuario = new Label();
            SuspendLayout();
            // 
            // btEliminarCliente
            // 
            btEliminarCliente.BackColor = SystemColors.ActiveCaption;
            btEliminarCliente.Location = new Point(125, 210);
            btEliminarCliente.Name = "btEliminarCliente";
            btEliminarCliente.Size = new Size(153, 60);
            btEliminarCliente.TabIndex = 7;
            btEliminarCliente.Text = "ELIMINAR";
            btEliminarCliente.UseVisualStyleBackColor = false;
            btEliminarCliente.Click += btEliminarCliente_Click;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(65, 141);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(287, 23);
            tbDocumento.TabIndex = 5;
            tbDocumento.Text = "Ingresa el documento";
            // 
            // lbEliminarUsuario
            // 
            lbEliminarUsuario.AutoSize = true;
            lbEliminarUsuario.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEliminarUsuario.Location = new Point(65, 72);
            lbEliminarUsuario.Name = "lbEliminarUsuario";
            lbEliminarUsuario.Size = new Size(279, 32);
            lbEliminarUsuario.TabIndex = 4;
            lbEliminarUsuario.Text = "Eliminar Usuario";
            // 
            // EliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 316);
            Controls.Add(btEliminarCliente);
            Controls.Add(tbDocumento);
            Controls.Add(lbEliminarUsuario);
            Name = "EliminarUsuario";
            Text = "EliminarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEliminarCliente;
        private TextBox tbDocumento;
        private Label lbEliminarUsuario;
    }
}