using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShopSeller.ServiceReference2;


namespace ShopSeller
{
    public partial class UpdateItem : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();

        public UpdateItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DataTable dt = (DataTable)Items.DataSource;
            dt.TableName = "Items";
            DataSet ds = new DataSet("ShopSeller");
            ds.Tables.Add(dt);
            string xmll = ds.GetXml();

            MessageBox.Show(ws.UpdateEItem(xmll));
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            DataTable dt = ws.FillItems();
            Items.DataSource = dt;
            Items.Columns[0].ReadOnly = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(Items.Rows[Items.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(ws.DeleteItem(index));
            Items.DataSource = ws.GetAllItemsData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
