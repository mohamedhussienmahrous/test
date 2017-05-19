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
    public partial class UpdateStock : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Stocks.DataSource;


            dt.TableName = "Stocks";
            DataSet ds = new DataSet("ShopSeller");
            ds.Tables.Add(dt);
            string xmll = ds.GetXml();

            MessageBox.Show(ws.UpdateStock(xmll));
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            Stocks.DataSource = ws.GetAllStockssData();
            Stocks.DataSource = ws.GetAllStockssData();
            Stocks.Columns[0].ReadOnly = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(Stocks.Rows[Stocks.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(ws.DeleteStock(index));
            Stocks.DataSource = ws.GetAllStockssData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
