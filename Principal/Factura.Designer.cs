namespace Principal
{
    partial class Fecha
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
            lbIdArticulo = new Label();
            lbIdCliente = new Label();
            lbIdEmpleado = new Label();
            lbTotalFactura = new Label();
            lbFechaFactura = new Label();
            btBuscarFactura = new Button();
            btCargaralalistaFactura = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbTotalpagarFactura = new Label();
            lbNumeroTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            lbCantidadProductoFactura = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloFactura
            // 
            lbTituloFactura.AutoSize = true;
            lbTituloFactura.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloFactura.Location = new Point(244, 9);
            lbTituloFactura.Name = "lbTituloFactura";
            lbTituloFactura.Size = new Size(139, 32);
            lbTituloFactura.TabIndex = 0;
            lbTituloFactura.Text = "FACTURA";
            // 
            // lbIdArticulo
            // 
            lbIdArticulo.AutoSize = true;
            lbIdArticulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdArticulo.Location = new Point(19, 170);
            lbIdArticulo.Name = "lbIdArticulo";
            lbIdArticulo.Size = new Size(74, 17);
            lbIdArticulo.TabIndex = 1;
            lbIdArticulo.Text = "Id Articulo: ";
            // 
            // lbIdCliente
            // 
            lbIdCliente.AutoSize = true;
            lbIdCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdCliente.Location = new Point(28, 98);
            lbIdCliente.Name = "lbIdCliente";
            lbIdCliente.Size = new Size(65, 17);
            lbIdCliente.TabIndex = 2;
            lbIdCliente.Text = "Id Cliente:";
            // 
            // lbIdEmpleado
            // 
            lbIdEmpleado.AutoSize = true;
            lbIdEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdEmpleado.Location = new Point(8, 130);
            lbIdEmpleado.Name = "lbIdEmpleado";
            lbIdEmpleado.Size = new Size(85, 17);
            lbIdEmpleado.TabIndex = 3;
            lbIdEmpleado.Text = "Id Empleado:";
            // 
            // lbTotalFactura
            // 
            lbTotalFactura.AutoSize = true;
            lbTotalFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalFactura.Location = new Point(40, 247);
            lbTotalFactura.Name = "lbTotalFactura";
            lbTotalFactura.Size = new Size(39, 17);
            lbTotalFactura.TabIndex = 4;
            lbTotalFactura.Text = "Total:";
            // 
            // lbFechaFactura
            // 
            lbFechaFactura.AutoSize = true;
            lbFechaFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFechaFactura.Location = new Point(40, 64);
            lbFechaFactura.Name = "lbFechaFactura";
            lbFechaFactura.Size = new Size(41, 17);
            lbFechaFactura.TabIndex = 5;
            lbFechaFactura.Text = "Fecha";
            // 
            // btBuscarFactura
            // 
            btBuscarFactura.BackColor = SystemColors.ActiveCaption;
            btBuscarFactura.Location = new Point(283, 169);
            btBuscarFactura.Name = "btBuscarFactura";
            btBuscarFactura.Size = new Size(91, 22);
            btBuscarFactura.TabIndex = 6;
            btBuscarFactura.Text = "Buscar";
            btBuscarFactura.UseVisualStyleBackColor = false;
            // 
            // btCargaralalistaFactura
            // 
            btCargaralalistaFactura.BackColor = SystemColors.ActiveCaption;
            btCargaralalistaFactura.Location = new Point(122, 287);
            btCargaralalistaFactura.Name = "btCargaralalistaFactura";
            btCargaralalistaFactura.Size = new Size(110, 43);
            btCargaralalistaFactura.TabIndex = 7;
            btCargaralalistaFactura.Text = "Cargar a la lista";
            btCargaralalistaFactura.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(28, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 132);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "IdArticulo";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "IdCliente";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "IdEmpleado";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "SubTotal";
            Column5.Name = "Column5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(99, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // lbTotalpagarFactura
            // 
            lbTotalpagarFactura.AutoSize = true;
            lbTotalpagarFactura.Font = new Font("Segoe UI", 10F);
            lbTotalpagarFactura.Location = new Point(450, 120);
            lbTotalpagarFactura.Name = "lbTotalpagarFactura";
            lbTotalpagarFactura.Size = new Size(91, 19);
            lbTotalpagarFactura.TabIndex = 15;
            lbTotalpagarFactura.Text = "Total a pagar:";
            // 
            // lbNumeroTotal
            // 
            lbNumeroTotal.AutoSize = true;
            lbNumeroTotal.Location = new Point(12, 13);
            lbNumeroTotal.Name = "lbNumeroTotal";
            lbNumeroTotal.Size = new Size(13, 15);
            lbNumeroTotal.TabIndex = 16;
            lbNumeroTotal.Text = "$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 17;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 13);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 18;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 13);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 19;
            label3.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbNumeroTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(432, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 41);
            panel1.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(412, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 23);
            textBox5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(463, 225);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 21;
            label4.Text = "Efectivo:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(444, 288);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 23;
            button2.Text = "Vender";
            button2.UseVisualStyleBackColor = false;
            // 
            // lbCantidadProductoFactura
            // 
            lbCantidadProductoFactura.AutoSize = true;
            lbCantidadProductoFactura.Location = new Point(19, 209);
            lbCantidadProductoFactura.Name = "lbCantidadProductoFactura";
            lbCantidadProductoFactura.Size = new Size(58, 15);
            lbCantidadProductoFactura.TabIndex = 24;
            lbCantidadProductoFactura.Text = "Cantidad:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(99, 209);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 23);
            textBox6.TabIndex = 25;
            // 
            // Fecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 521);
            Controls.Add(textBox6);
            Controls.Add(lbCantidadProductoFactura);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(lbTotalpagarFactura);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btCargaralalistaFactura);
            Controls.Add(btBuscarFactura);
            Controls.Add(lbFechaFactura);
            Controls.Add(lbTotalFactura);
            Controls.Add(lbIdEmpleado);
            Controls.Add(lbIdCliente);
            Controls.Add(lbIdArticulo);
            Controls.Add(lbTituloFactura);
            Name = "Fecha";
            Text = "Fecha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTituloFactura;
        private Label lbIdArticulo;
        private Label lbIdCliente;
        private Label lbIdEmpleado;
        private Label lbTotalFactura;
        private Label lbFechaFactura;
        private Button btBuscarFactura;
        private Button btCargaralalistaFactura;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label lbTotalpagarFactura;
        private Label lbNumeroTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox textBox5;
        private Label label4;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label lbCantidadProductoFactura;
        private TextBox textBox6;
    }
}