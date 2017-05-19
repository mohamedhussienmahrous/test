namespace ShopSeller
{
    partial class Stock
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
            this.StockAddress = new System.Windows.Forms.TextBox();
            this.StockID = new System.Windows.Forms.TextBox();
            this.StockName = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockAddress
            // 
            this.StockAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StockAddress.Location = new System.Drawing.Point(116, 140);
            this.StockAddress.MaxLength = 50;
            this.StockAddress.Name = "StockAddress";
            this.StockAddress.Size = new System.Drawing.Size(200, 20);
            this.StockAddress.TabIndex = 17;
            // 
            // StockID
            // 
            this.StockID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StockID.Location = new System.Drawing.Point(116, 25);
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            this.StockID.Size = new System.Drawing.Size(200, 20);
            this.StockID.TabIndex = 16;
            // 
            // StockName
            // 
            this.StockName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StockName.Location = new System.Drawing.Point(116, 87);
            this.StockName.MaxLength = 50;
            this.StockName.Name = "StockName";
            this.StockName.Size = new System.Drawing.Size(200, 20);
            this.StockName.TabIndex = 15;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(354, 250);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 34);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(354, 208);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 33);
            this.btnAddStock.TabIndex = 13;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(25, 147);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(46, 13);
            this.Address.TabIndex = 12;
            this.Address.Text = "Address";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(25, 87);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(34, 13);
            this.EName.TabIndex = 11;
            this.EName.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(25, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 297);
            this.Controls.Add(this.StockAddress);
            this.Controls.Add(this.StockID);
            this.Controls.Add(this.StockName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.ID);
            this.Name = "Stock";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StockAddress;
        private System.Windows.Forms.TextBox StockID;
        private System.Windows.Forms.TextBox StockName;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label ID;
    }
}