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
    public partial class DeleteStock : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();

        public DeleteStock()
        {
            InitializeComponent();
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            DGVStocks.DataSource = ws.GetAllStockssData();
            DGVStocks.Columns[0].ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           int index=int.Parse( DGVStocks.Rows[ DGVStocks.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
          MessageBox.Show(  ws.DeleteStock(index));
            DGVStocks.DataSource = ws.GetAllStockssData();
        }
    }
}
