using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopSeller
{
    public partial class Search : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public Search()
        {
            InitializeComponent();
        }
        private void Search_Load(object sender, EventArgs e)
        {
            Tables.DataSource = ws.GetDBTables();
            Tables.ValueMember = "Tables";
        }
        private void Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            Columns.DataSource = ws.GetDBTableColumns(Tables.SelectedValue.ToString());
            Columns.ValueMember = "Columns";
            btnSearch.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
          SearchResults.DataSource=ws.EmployeeSelect(content.Text, null);
        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            // SearchResults.DataSource = ws.EmployeeSelect(content.Text, null);
            string comm = "select * from " + Tables.SelectedValue + " where " + Columns.SelectedValue + " like '%" + content.Text + "%'";
            SearchResults.DataSource = ws.ExecuteCommand(comm);
            //SearchResults.Columns[0].ReadOnly = true; 
            for(int i=0;i<SearchResults.Columns.Count;++i)
                SearchResults.Columns[i].ReadOnly = true;
        }
    }
}
