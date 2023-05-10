namespace H2H_App
{
    partial class Invoice_Form
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
            this.description_TB = new System.Windows.Forms.TextBox();
            this.Qty_TB = new System.Windows.Forms.TextBox();
            this.UnitPrice_TB = new System.Windows.Forms.TextBox();
            this.Discount_TB = new System.Windows.Forms.TextBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.H2H_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Print_TB = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.SubTotal_lbl = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.ADD_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyName_TB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Description_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitprice_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // description_TB
            // 
            this.description_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description_TB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_TB.Location = new System.Drawing.Point(587, 154);
            this.description_TB.Multiline = true;
            this.description_TB.Name = "description_TB";
            this.description_TB.Size = new System.Drawing.Size(203, 97);
            this.description_TB.TabIndex = 3;
            // 
            // Qty_TB
            // 
            this.Qty_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Qty_TB.Location = new System.Drawing.Point(223, 154);
            this.Qty_TB.Multiline = true;
            this.Qty_TB.Name = "Qty_TB";
            this.Qty_TB.Size = new System.Drawing.Size(167, 31);
            this.Qty_TB.TabIndex = 1;
            // 
            // UnitPrice_TB
            // 
            this.UnitPrice_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.UnitPrice_TB.Location = new System.Drawing.Point(403, 154);
            this.UnitPrice_TB.Multiline = true;
            this.UnitPrice_TB.Name = "UnitPrice_TB";
            this.UnitPrice_TB.Size = new System.Drawing.Size(167, 31);
            this.UnitPrice_TB.TabIndex = 2;
            // 
            // Discount_TB
            // 
            this.Discount_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Discount_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.Discount_TB.Location = new System.Drawing.Point(995, 154);
            this.Discount_TB.Multiline = true;
            this.Discount_TB.Name = "Discount_TB";
            this.Discount_TB.Size = new System.Drawing.Size(167, 31);
            this.Discount_TB.TabIndex = 5;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Location = new System.Drawing.Point(223, 276);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(147, 24);
            this.paymentMethodComboBox.TabIndex = 6;
            this.paymentMethodComboBox.Text = "Payment Method";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(223, 304);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(147, 24);
            this.employeeComboBox.TabIndex = 7;
            this.employeeComboBox.Text = "Employee Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // H2H_lbl
            // 
            this.H2H_lbl.AutoSize = true;
            this.H2H_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2H_lbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.H2H_lbl.Location = new System.Drawing.Point(653, 32);
            this.H2H_lbl.Name = "H2H_lbl";
            this.H2H_lbl.Size = new System.Drawing.Size(110, 50);
            this.H2H_lbl.TabIndex = 11;
            this.H2H_lbl.Text = "H2H";
            this.H2H_lbl.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.H2H_lbl);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1382, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Print_TB
            // 
            this.Print_TB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Print_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Print_TB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Print_TB.Location = new System.Drawing.Point(869, 329);
            this.Print_TB.Name = "Print_TB";
            this.Print_TB.Size = new System.Drawing.Size(121, 32);
            this.Print_TB.TabIndex = 9;
            this.Print_TB.Text = "PRINT";
            this.Print_TB.UseVisualStyleBackColor = true;
            this.Print_TB.Click += new System.EventHandler(this.Print_TB_Click);
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Description.Location = new System.Drawing.Point(596, 145);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(86, 16);
            this.Description.TabIndex = 15;
            this.Description.Text = "Description";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Qty.Location = new System.Drawing.Point(220, 145);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(30, 16);
            this.Qty.TabIndex = 21;
            this.Qty.Text = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.UnitPrice.Location = new System.Drawing.Point(403, 145);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(70, 16);
            this.UnitPrice.TabIndex = 22;
            this.UnitPrice.Text = "UnitPrice";
            // 
            // SubTotal_lbl
            // 
            this.SubTotal_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTotal_lbl.AutoSize = true;
            this.SubTotal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SubTotal_lbl.Location = new System.Drawing.Point(1059, 287);
            this.SubTotal_lbl.Name = "SubTotal_lbl";
            this.SubTotal_lbl.Size = new System.Drawing.Size(70, 16);
            this.SubTotal_lbl.TabIndex = 23;
            this.SubTotal_lbl.Text = "SubTotal";
            // 
            // Total_lbl
            // 
            this.Total_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Total_lbl.Location = new System.Drawing.Point(1074, 312);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(43, 16);
            this.Total_lbl.TabIndex = 24;
            this.Total_lbl.Text = "Total";
            // 
            // Discount
            // 
            this.Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Discount.Location = new System.Drawing.Point(995, 145);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(67, 16);
            this.Discount.TabIndex = 25;
            this.Discount.Text = "Discount";
            // 
            // ADD_Btn
            // 
            this.ADD_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ADD_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_Btn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ADD_Btn.Location = new System.Drawing.Point(612, 329);
            this.ADD_Btn.Name = "ADD_Btn";
            this.ADD_Btn.Size = new System.Drawing.Size(121, 32);
            this.ADD_Btn.TabIndex = 8;
            this.ADD_Btn.Text = "ADD";
            this.ADD_Btn.UseVisualStyleBackColor = true;
            this.ADD_Btn.Click += new System.EventHandler(this.ADD_Btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(806, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Company Name";
            // 
            // CompanyName_TB
            // 
            this.CompanyName_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyName_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.CompanyName_TB.Location = new System.Drawing.Point(806, 154);
            this.CompanyName_TB.Multiline = true;
            this.CompanyName_TB.Name = "CompanyName_TB";
            this.CompanyName_TB.Size = new System.Drawing.Size(167, 31);
            this.CompanyName_TB.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description_col,
            this.Quantity_col,
            this.Unitprice_col,
            this.subtotal_col});
            this.dataGridView1.Location = new System.Drawing.Point(12, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 274);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Description_col
            // 
            this.Description_col.HeaderText = "Description";
            this.Description_col.MinimumWidth = 6;
            this.Description_col.Name = "Description_col";
            // 
            // Quantity_col
            // 
            this.Quantity_col.HeaderText = "Quantity";
            this.Quantity_col.MinimumWidth = 6;
            this.Quantity_col.Name = "Quantity_col";
            // 
            // Unitprice_col
            // 
            this.Unitprice_col.HeaderText = "Unit price";
            this.Unitprice_col.MinimumWidth = 6;
            this.Unitprice_col.Name = "Unitprice_col";
            // 
            // subtotal_col
            // 
            this.subtotal_col.HeaderText = "subtotal";
            this.subtotal_col.MinimumWidth = 6;
            this.subtotal_col.Name = "subtotal_col";
            // 
            // Invoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompanyName_TB);
            this.Controls.Add(this.ADD_Btn);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Total_lbl);
            this.Controls.Add(this.SubTotal_lbl);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Print_TB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Controls.Add(this.Discount_TB);
            this.Controls.Add(this.UnitPrice_TB);
            this.Controls.Add(this.Qty_TB);
            this.Controls.Add(this.description_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Invoice_Form";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Invoice_Form_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description_TB;
        private System.Windows.Forms.TextBox Qty_TB;
        private System.Windows.Forms.TextBox UnitPrice_TB;
        private System.Windows.Forms.TextBox Discount_TB;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label H2H_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Print_TB;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label SubTotal_lbl;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Button ADD_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyName_TB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitprice_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_col;
    }
}

