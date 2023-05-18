namespace PROYECTO_INVENTARIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnagregar = new Button();
            label5 = new Label();
            label6 = new Label();
            dgvBoard = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            txtpurchase_price = new TextBox();
            txtproduct = new TextBox();
            txtamount = new TextBox();
            txtcode = new TextBox();
            label8 = new Label();
            txtsale_price = new TextBox();
            btnDelete = new Button();
            label9 = new Label();
            txtentries = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txttotal1 = new TextBox();
            txttotal2 = new TextBox();
            btnmost = new Button();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBoard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 205);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 132);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "CÓDIGO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 236);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 363);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 3;
            label4.Text = "PRECIO DE VENTA:";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(21, 557);
            btnagregar.Margin = new Padding(3, 4, 3, 4);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(86, 31);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "AGREGAR";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnAdd_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 170);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 7;
            label5.Text = "FECHA DE ENTRADA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 9);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 8;
            label6.Text = "INVENTARIO";
            // 
            // dgvBoard
            // 
            dgvBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoard.Columns.AddRange(new DataGridViewColumn[] { codigo, Column2, producto, Column4, Column6, Column5 });
            dgvBoard.Location = new Point(349, 103);
            dgvBoard.Margin = new Padding(3, 4, 3, 4);
            dgvBoard.Name = "dgvBoard";
            dgvBoard.RowHeadersWidth = 51;
            dgvBoard.RowTemplate.Height = 25;
            dgvBoard.Size = new Size(979, 525);
            dgvBoard.TabIndex = 9;
            dgvBoard.CellContentClick += dgvBoard_CellContentClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "CÓDIGO";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "FECHA DE ENTRADA";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // producto
            // 
            producto.HeaderText = "PRODUCTO";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.Width = 300;
            // 
            // Column4
            // 
            Column4.HeaderText = "CANTIDAD";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "PRECIO DE COMPRA";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "PRECIO DE VENTA";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(160, 170);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // txtpurchase_price
            // 
            txtpurchase_price.Location = new Point(160, 240);
            txtpurchase_price.Margin = new Padding(3, 4, 3, 4);
            txtpurchase_price.Name = "txtpurchase_price";
            txtpurchase_price.Size = new Size(114, 27);
            txtpurchase_price.TabIndex = 11;
            // 
            // txtproduct
            // 
            txtproduct.Location = new Point(160, 205);
            txtproduct.Margin = new Padding(3, 4, 3, 4);
            txtproduct.Name = "txtproduct";
            txtproduct.Size = new Size(183, 27);
            txtproduct.TabIndex = 12;
            // 
            // txtamount
            // 
            txtamount.Location = new Point(160, 328);
            txtamount.Margin = new Padding(3, 4, 3, 4);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(114, 27);
            txtamount.TabIndex = 13;
            // 
            // txtcode
            // 
            txtcode.Location = new Point(163, 132);
            txtcode.Margin = new Padding(3, 4, 3, 4);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(114, 27);
            txtcode.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 335);
            label8.Name = "label8";
            label8.Size = new Size(148, 20);
            label8.TabIndex = 16;
            label8.Text = "PRECIO DE COMPRA:";
            // 
            // txtsale_price
            // 
            txtsale_price.Location = new Point(160, 363);
            txtsale_price.Margin = new Padding(3, 4, 3, 4);
            txtsale_price.Name = "txtsale_price";
            txtsale_price.Size = new Size(114, 27);
            txtsale_price.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(163, 557);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1426, 143);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 20;
            label9.Text = "Entradas Total:";
            // 
            // txtentries
            // 
            txtentries.Location = new Point(1538, 140);
            txtentries.Name = "txtentries";
            txtentries.Size = new Size(125, 27);
            txtentries.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1426, 205);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 22;
            label7.Text = "Compras Totales:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1426, 265);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 23;
            label10.Text = "Ventas Totales:";
            // 
            // txttotal1
            // 
            txttotal1.Location = new Point(1554, 202);
            txttotal1.Name = "txttotal1";
            txttotal1.Size = new Size(125, 27);
            txttotal1.TabIndex = 24;
            // 
            // txttotal2
            // 
            txttotal2.Location = new Point(1538, 265);
            txttotal2.Name = "txttotal2";
            txttotal2.Size = new Size(125, 27);
            txttotal2.TabIndex = 25;
            // 
            // btnmost
            // 
            btnmost.Location = new Point(1585, 362);
            btnmost.Name = "btnmost";
            btnmost.Size = new Size(94, 29);
            btnmost.TabIndex = 26;
            btnmost.Text = "MOSTRAR";
            btnmost.UseVisualStyleBackColor = true;
            btnmost.Click += btnmost_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(1567, 80);
            label.Name = "label";
            label.Size = new Size(66, 20);
            label.TabIndex = 27;
            label.Text = "TOTALES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1826, 641);
            Controls.Add(label);
            Controls.Add(btnmost);
            Controls.Add(txttotal2);
            Controls.Add(txttotal1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtentries);
            Controls.Add(label9);
            Controls.Add(btnDelete);
            Controls.Add(txtsale_price);
            Controls.Add(label8);
            Controls.Add(txtcode);
            Controls.Add(txtamount);
            Controls.Add(txtproduct);
            Controls.Add(txtpurchase_price);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvBoard);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnagregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnagregar;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtpurchase_price;
        private TextBox txtproduct;
        private TextBox txtamount;
        private TextBox txtcode;
        private Label label8;
        private TextBox txtsale_price;
        private Button btnDelete;
        private DataGridView dgvBoard;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Label label9;
        private TextBox txtentries;
        private Label label7;
        private Label label10;
        private TextBox txttotal1;
        private TextBox txttotal2;
        private Button btnmost;
        private Label label;
    }
}