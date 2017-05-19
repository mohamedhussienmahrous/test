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
    public partial class DeleteItem : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            DGVItems.DataSource = ws.GetAllItemsData();
            DGVItems.Columns[0].ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(DGVItems.Rows[DGVItems.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(ws.DeleteItem(index));
            DGVItems.DataSource = ws.GetAllItemsData();
        }
    }
}
