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
    public partial class UpdateEmployes : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public UpdateEmployes()
        {
            InitializeComponent();
        }

        private void UpdateEmployes_Load(object sender, EventArgs e)
        {
            Employees.DataSource = ws.GetAllEmployesData();
            Employees.Columns[0].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Employees.DataSource;
            dt.TableName = "Employees";
            DataSet ds = new DataSet("ShopSeller");
            ds.Tables.Add(dt);
            string xmll = ds.GetXml();
            MessageBox.Show(ws.UpdateEmploye(xmll));
           
        }

    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(Employees.Rows[Employees.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(ws.DeleteEmployee(index));
            Employees.DataSource = ws.GetAllEmployesData();
        }
    }
}
