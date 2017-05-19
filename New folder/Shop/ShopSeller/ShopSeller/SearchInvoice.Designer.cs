namespace ShopSeller
{
    partial class SearchInvoice
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
            this.InvoicesBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InvoiceItems = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InvTax = new System.Windows.Forms.TextBox();
            this.InvTotal = new System.Windows.Forms.TextBox();
            this.InvDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.StockName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // InvoicesBox
            // 
            this.InvoicesBox.FormattingEnabled = true;
            this.InvoicesBox.Location = new System.Drawing.Point(12, 12);
            this.InvoicesBox.Name = "InvoicesBox";
            this.InvoicesBox.Size = new System.Drawing.Size(121, 21);
            this.InvoicesBox.TabIndex = 0;
         //   this.InvoicesBox.SelectedIndexChanged += new System.EventHandler(this.InvoicesBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceItems
            // 
            this.InvoiceItems.AllowUserToAddRows = false;
            this.InvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceItems.Location = new System.Drawing.Point(80, 159);
            this.InvoiceItems.Name = "InvoiceItems";
            this.InvoiceItems.Size = new System.Drawing.Size(640, 230);
            this.InvoiceItems.TabIndex = 43;
            this.InvoiceItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tax";
            // 
            // InvTax
            // 
            this.InvTax.Location = new System.Drawing.Point(560, 409);
            this.InvTax.Name = "InvTax";
            this.InvTax.Size = new System.Drawing.Size(121, 20);
            this.InvTax.TabIndex = 40;
            this.InvTax.TextChanged += new System.EventHandler(this.InvTax_TextChanged);
            // 
            // InvTotal
            // 
            this.InvTotal.Location = new System.Drawing.Point(173, 409);
            this.InvTotal.Name = "InvTotal";
            this.InvTotal.Size = new System.Drawing.Size(155, 20);
            this.InvTotal.TabIndex = 39;
            // 
            // InvDate
            // 
            this.InvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InvDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InvDate.Location = new System.Drawing.Point(427, 87);
            this.InvDate.Name = "InvDate";
            this.InvDate.Size = new System.Drawing.Size(121, 20);
            this.InvDate.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Date";
            // 
            // Code
            // 
            this.Code.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Code.Location = new System.Drawing.Point(129, 81);
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Size = new System.Drawing.Size(155, 20);
            this.Code.TabIndex = 34;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(683, 440);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 34);
            this.Close.TabIndex = 33;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(357, 138);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(33, 13);
            this.Stock.TabIndex = 31;
            this.Stock.Text = "Stock";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(77, 128);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(47, 13);
            this.EName.TabIndex = 30;
            this.EName.Text = "Employe";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(77, 84);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 13);
            this.ID.TabIndex = 29;
            this.ID.Text = "Code";
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(142, 128);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(100, 20);
            this.EmpName.TabIndex = 44;
            // 
            // StockName
            // 
            this.StockName.Location = new System.Drawing.Point(427, 131);
            this.StockName.Name = "StockName";
            this.StockName.Size = new System.Drawing.Size(100, 20);
            this.StockName.TabIndex = 45;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(576, 442);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(452, 442);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SearchInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 484);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.StockName);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.InvoiceItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvTax);
            this.Controls.Add(this.InvTotal);
            this.Controls.Add(this.InvDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InvoicesBox);
            this.Name = "SearchInvoice";
            this.Text = "SearchInvoice";
            this.Load += new System.EventHandler(this.SearchInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InvoicesBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView InvoiceItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InvTax;
        private System.Windows.Forms.TextBox InvTotal;
        private System.Windows.Forms.DateTimePicker InvDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox StockName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}