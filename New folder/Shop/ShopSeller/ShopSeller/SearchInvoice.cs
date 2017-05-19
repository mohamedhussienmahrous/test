using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ShopSeller
{
    public partial class SearchInvoice : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public SearchInvoice()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////problem in DataTable
            string[] s=InvoicesBox.SelectedValue.ToString().Split('-');
             DataTable dt=ws.GetInvoiceData(int.Parse(s[1]));
            InvoiceItems.DataSource = dt;
            InvoiceItems.Columns["Inv_ID"].Visible=false;
            InvoiceItems.Columns["Inv_ID1"].Visible = false;
            InvoiceItems.Columns["Emp_ID"].Visible = false;
            InvoiceItems.Columns["Stock_ID"].Visible = false;
            InvoiceItems.Columns["ID"].Visible = false;
            InvoiceItems.Columns["Code"].Visible = false;
            InvoiceItems.Columns["Tax"].Visible = false;
            InvoiceItems.Columns["Date"].Visible = false;
            InvoiceItems.Columns["Item_ID"].ReadOnly = true;
            Code.Text= dt.Rows[0][1].ToString();
             InvTax.Text = dt.Rows[0][5].ToString();
             InvDate.Text = dt.Rows[0][2].ToString();
            EmpName.Text= dt.Rows[0][3].ToString();
            StockName.Text = dt.Rows[0][4].ToString();

            CalculateTotal();
            InvoiceItems.Columns.Add("Total","Total");
            InvoiceItems.Columns["Total"].ReadOnly=true;
         for(int i=0; i<InvoiceItems.RowCount;++i)
             InvoiceItems.Rows[i].Cells[11].Value = double.Parse(InvoiceItems.Rows[i].Cells["Price"].Value.ToString()) * double.Parse(InvoiceItems.Rows[i].Cells["Quantity"].Value.ToString());
           
        }
        private void CalculateTotal()
        {
            double Total = 0;
            for (int i = 0; i <= InvoiceItems.Rows.Count - 1; ++i)
            {
                Total += double.Parse(InvoiceItems.Rows[i].Cells["Price"].Value.ToString()) * double.Parse(InvoiceItems.Rows[i].Cells["Quantity"].Value.ToString());
            }
            InvTotal.Text = (double.Parse(InvTax.Text) + Total).ToString();
        }
        private void SearchInvoice_Load(object sender, EventArgs e)
        {
            LoadControlls();
        }

        private void LoadControlls()
        {
            InvoicesBox.DataSource = ws.FillInvoices();
            InvoicesBox.DisplayMember = "Code";
            InvoicesBox.ValueMember = "Code";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
          //  DataTable dt = (DataTable)dataGridView1.DataSource;
            //dt.Columns.RemoveAt((dataGridView1.ColumnCount - 1));
            //dt.AcceptChanges();
            DataTable dt = new DataTable("Inv_Item");
            foreach (DataGridViewColumn column in InvoiceItems.Columns)
                dt.Columns.Add(column.Name); //better to have cell type
            for (int i = 0; i < InvoiceItems.Rows.Count; i++)
            {
                dt.Rows.Add();
                for (int j = 1; j < InvoiceItems.Columns.Count; j++)
                {
                    dt.Rows[i][j] = InvoiceItems.Rows[i].Cells[j].Value.ToString();
                }
            }

        
        DataSet ds = new DataSet();
        ds.Tables.Add(dt); // Table 1

        string dsXml= ds.GetXml();


        MessageBox.Show(ws.UpdateInvoiceXML(ds.GetXml(), InvDate.Text,int.Parse(EmpName.Text.ToString()), int.Parse(StockName.Text.ToString()), int.Parse(InvTax.Text), InvoicesBox.SelectedValue.ToString()));

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (InvoiceItems.Columns[e.ColumnIndex].Name == "Price" || InvoiceItems.Columns[e.ColumnIndex].Name == "Quantity")
            {
                InvoiceItems.Rows[e.RowIndex].Cells["Total"].Value = double.Parse(InvoiceItems.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * double.Parse(InvoiceItems.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                CalculateTotal();
            }
        }

        private void InvTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string[] s = Code.Text.ToString().Split('-') ;
          MessageBox.Show(  ws.DeleteInvoice(int.Parse(s[1])));
            LoadControlls();
        }

      
    }
}
