namespace ShopSeller
{
    partial class Item
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
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.ItemID = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemPrice
            // 
            this.ItemPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ItemPrice.Location = new System.Drawing.Point(109, 153);
            this.ItemPrice.MaxLength = 50;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(200, 20);
            this.ItemPrice.TabIndex = 17;
            // 
            // ItemID
            // 
            this.ItemID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ItemID.Location = new System.Drawing.Point(109, 38);
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Size = new System.Drawing.Size(200, 20);
            this.ItemID.TabIndex = 16;
            // 
            // ItemName
            // 
            this.ItemName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ItemName.Location = new System.Drawing.Point(109, 100);
            this.ItemName.MaxLength = 50;
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(200, 20);
            this.ItemName.TabIndex = 15;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(234, 268);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 35);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(234, 226);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 34);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.ForeColor = System.Drawing.Color.Black;
            this.Address.Location = new System.Drawing.Point(18, 153);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(30, 13);
            this.Address.TabIndex = 12;
            this.Address.Text = "Price";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(18, 100);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(34, 13);
            this.EName.TabIndex = 11;
            this.EName.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(18, 38);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 315);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemID);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.ID);
            this.Name = "Item";
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.TextBox ItemID;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label ID;
    }
}