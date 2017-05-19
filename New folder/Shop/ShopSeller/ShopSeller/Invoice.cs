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
    public partial class Invoice : Form
    {
        DataTable ItemsTable;
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        DataTable dt = new DataTable(); 
        string invCode = "";
        public Invoice()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            LoadData();

            CreateDataGridview();
        }

        private void CreateDataGridview()
        {
            DataGridViewComboBoxColumn d = dataGridView1.Columns[1] as DataGridViewComboBoxColumn;
            d.DataSource = ItemsTable;
            d.DisplayMember = "Item_Name";

            d.ValueMember = "Item_ID";
          //  dataGridView1.Rows.Add(new object[6] { "10", ItemsTable.Columns["ItemName"], "", "", "", "" });
        }
        private void LoadData()
        {
            Code.Text = invCode = ws.CreateInvoiceCode();
            EmployeeBox.DataSource = ws.FillEmployes();
            EmployeeBox.ValueMember = "Emp_ID";
            EmployeeBox.DisplayMember = "Emp_Name";

            StockBox.DataSource = ws.FillStocks();
            StockBox.ValueMember = "Stock_ID";
            StockBox.DisplayMember = "Stock_Name";

            ItemsTable = ws.FillItems();
            ItemsBox.DataSource = ItemsTable;
            ItemsBox.ValueMember = "Item_Name";
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int inde=ItemsBox.SelectedIndex;
            #region Check if the Item already Added
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if (dataGridView1.Rows[i].Cells["Item"].Value.ToString() == ItemsTable.Rows[inde][0].ToString())
                {
                    MessageBox.Show("You Cannot Add This Item Because You added before !!");
                    return;
                }
            }
            #endregion
            string[] invIDs = invCode.Split('-');
            string[] row = { invIDs[1], ItemsTable.Rows[inde][0].ToString(), ItemsTable.Rows[inde][1].ToString(), "0", ItemsTable.Rows[inde][2].ToString(), "0" };
            dataGridView1.Rows.Add(row);
          /* 
                
            dt.Rows.Add(row);
            dataGridView1.Rows.Add(dt.Rows[inde]);
            dataGridView1.Columns["CompanyName"].ReadOnly = true;
            */
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price" || dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString() != null && dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString() != null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString()) * double.Parse(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                    CalculateTotal();
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name== "ItemName")
            {
                this.dataGridView1.CellValueChanged -= new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
                int index =-1+ int.Parse(((dataGridView1.Rows[e.RowIndex].Cells["ItemName"] as DataGridViewComboBoxCell)).Value.ToString());
                dataGridView1.Rows[e.RowIndex].Cells["Item"].Value = ItemsTable.Rows[index][0];
                dataGridView1.Rows[e.RowIndex].Cells["Price"].Value = ItemsTable.Rows[index][2];
                dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value = 0;
                string[] s = Code.Text.ToString().Split('-');
                dataGridView1.Rows[e.RowIndex].Cells["Number"].Value = s[1];
                dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = 0;
                this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            }
        }
        private void CalculateTotal()
        {
           
            double Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
            {
                Total += double.Parse(dataGridView1.Rows[i].Cells["Total"].Value.ToString());
            }

            InvoiceTotal.Text = (double.Parse(textBox3.Text) +Total).ToString();
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3 || dataGridView1.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(i);
                CalculateTotal();
            }
            catch { MessageBox.Show("Please Select All cells !!"); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                //dt =((DataTable) dataGridView1.DataSource);
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                    dt.Columns.Add(column.Name); //better to have cell type
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    dt.Rows.Add();
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        dt.Rows[i][j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        
                    }
                }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            string XML=ds.GetXml();
            ws.InsertInvoiceData(XML,InvDate.Text.ToString(),int.Parse( EmployeeBox.SelectedValue.ToString()),int.Parse(StockBox.SelectedValue.ToString()),int.Parse( textBox3.Text.ToString()),Code.Text.ToString());
            
            MessageBox.Show("Added Successfully !!");
            dataGridView1.Rows.Clear();
            LoadData();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            CalculateTotal();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
