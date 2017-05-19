namespace ShopSeller
{
    partial class Invoice
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
            this.Code = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InvDate = new System.Windows.Forms.DateTimePicker();
            this.EmployeeBox = new System.Windows.Forms.ComboBox();
            this.StockBox = new System.Windows.Forms.ComboBox();
            this.InvoiceTotal = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.ItemsBox = new System.Windows.Forms.ComboBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Code
            // 
            this.Code.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Code.Location = new System.Drawing.Point(73, 9);
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Size = new System.Drawing.Size(155, 20);
            this.Code.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(627, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(301, 66);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(33, 13);
            this.Stock.TabIndex = 12;
            this.Stock.Text = "Stock";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(21, 56);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(47, 13);
            this.EName.TabIndex = 11;
            this.EName.Text = "Employe";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(21, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date";
            // 
            // InvDate
            // 
            this.InvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvDate.Location = new System.Drawing.Point(371, 15);
            this.InvDate.Name = "InvDate";
            this.InvDate.Size = new System.Drawing.Size(121, 20);
            this.InvDate.TabIndex = 19;
            // 
            // EmployeeBox
            // 
            this.EmployeeBox.FormattingEnabled = true;
            this.EmployeeBox.Location = new System.Drawing.Point(73, 57);
            this.EmployeeBox.Name = "EmployeeBox";
            this.EmployeeBox.Size = new System.Drawing.Size(155, 21);
            this.EmployeeBox.TabIndex = 20;
            // 
            // StockBox
            // 
            this.StockBox.FormattingEnabled = true;
            this.StockBox.Location = new System.Drawing.Point(371, 63);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(121, 21);
            this.StockBox.TabIndex = 21;
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.Location = new System.Drawing.Point(117, 337);
            this.InvoiceTotal.Name = "InvoiceTotal";
            this.InvoiceTotal.Size = new System.Drawing.Size(155, 20);
            this.InvoiceTotal.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(504, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 23;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ItemName,
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(24, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 230);
            this.dataGridView1.TabIndex = 26;
       //     this.dataGridView1.AllowUserToAddRowsChanged += new System.EventHandler(this.dataGridView1_AllowUserToAddRowsChanged);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Number
            // 
            this.Number.HeaderText = "Invoice Number";
            this.Number.Name = "Number";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item Number";
            this.Item.Name = "Item";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(703, 57);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 33);
            this.btnAddItem.TabIndex = 27;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // ItemsBox
            // 
            this.ItemsBox.FormattingEnabled = true;
            this.ItemsBox.Location = new System.Drawing.Point(543, 63);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(121, 21);
            this.ItemsBox.TabIndex = 28;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(703, 96);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteItem.TabIndex = 29;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 433);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.ItemsBox);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.InvoiceTotal);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.EmployeeBox);
            this.Controls.Add(this.InvDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.ID);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker InvDate;
        private System.Windows.Forms.ComboBox EmployeeBox;
        private System.Windows.Forms.ComboBox StockBox;
        private System.Windows.Forms.TextBox InvoiceTotal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox ItemsBox;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}