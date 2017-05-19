namespace ShopSeller
{
    partial class UpdateStock
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
            this.btnUpdateStocks = new System.Windows.Forms.Button();
            this.Stocks = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateStocks
            // 
            this.btnUpdateStocks.Location = new System.Drawing.Point(404, 57);
            this.btnUpdateStocks.Name = "btnUpdateStocks";
            this.btnUpdateStocks.Size = new System.Drawing.Size(75, 44);
            this.btnUpdateStocks.TabIndex = 3;
            this.btnUpdateStocks.Text = "Update";
            this.btnUpdateStocks.UseVisualStyleBackColor = true;
            this.btnUpdateStocks.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stocks
            // 
            this.Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stocks.Location = new System.Drawing.Point(30, 34);
            this.Stocks.Name = "Stocks";
            this.Stocks.Size = new System.Drawing.Size(295, 262);
            this.Stocks.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 51);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UpdateStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 331);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateStocks);
            this.Controls.Add(this.Stocks);
            this.Name = "UpdateStock";
            this.Text = "UpdateStock";
            this.Load += new System.EventHandler(this.UpdateStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateStocks;
        private System.Windows.Forms.DataGridView Stocks;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}