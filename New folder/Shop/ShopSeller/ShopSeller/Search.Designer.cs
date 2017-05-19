namespace ShopSeller
{
    partial class Search
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.Tables = new System.Windows.Forms.ComboBox();
            this.Columns = new System.Windows.Forms.ComboBox();
            this.content = new System.Windows.Forms.TextBox();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(583, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(36, 24);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(121, 21);
            this.Tables.TabIndex = 1;
            this.Tables.SelectedIndexChanged += new System.EventHandler(this.Tables_SelectedIndexChanged);
            // 
            // Columns
            // 
            this.Columns.FormattingEnabled = true;
            this.Columns.Location = new System.Drawing.Point(36, 68);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(121, 21);
            this.Columns.TabIndex = 2;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(372, 66);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(143, 20);
            this.content.TabIndex = 3;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            // 
            // SearchResults
            // 
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Location = new System.Drawing.Point(12, 109);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(679, 289);
            this.SearchResults.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.btnSearch);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox Tables;
        private System.Windows.Forms.ComboBox Columns;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Button button1;
    }
}