namespace ShopSeller
{
    partial class AddEmploye
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
            this.ID = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.EmpAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(22, 22);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Location = new System.Drawing.Point(22, 84);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(34, 13);
            this.EName.TabIndex = 2;
            this.EName.Text = "Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(22, 144);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(46, 13);
            this.Address.TabIndex = 3;
            this.Address.Text = "Address";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(351, 205);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(75, 33);
            this.btnAddEmp.TabIndex = 4;
            this.btnAddEmp.Text = "Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(351, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmpName
            // 
            this.EmpName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmpName.Location = new System.Drawing.Point(113, 84);
            this.EmpName.MaxLength = 50;
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(200, 20);
            this.EmpName.TabIndex = 6;
            // 
            // EmpID
            // 
            this.EmpID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmpID.Location = new System.Drawing.Point(113, 22);
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Size = new System.Drawing.Size(200, 20);
            this.EmpID.TabIndex = 8;
            // 
            // EmpAddress
            // 
            this.EmpAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.EmpAddress.Location = new System.Drawing.Point(113, 137);
            this.EmpAddress.MaxLength = 50;
            this.EmpAddress.Name = "EmpAddress";
            this.EmpAddress.Size = new System.Drawing.Size(200, 20);
            this.EmpAddress.TabIndex = 9;
            // 
            // AddEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 295);
            this.Controls.Add(this.EmpAddress);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.ID);
            this.Name = "AddEmploye";
            this.Text = "AddEmploye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.TextBox EmpAddress;
    }
}