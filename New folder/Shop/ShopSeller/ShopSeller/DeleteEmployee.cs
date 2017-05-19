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
    public partial class DeleteEmployee : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {
            
            DGVEmployees.DataSource = ws.GetAllEmployesData();
            DGVEmployees.Columns[0].ReadOnly = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse(DGVEmployees.Rows[DGVEmployees.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(ws.DeleteEmployee(index));
            DGVEmployees.DataSource = ws.GetAllEmployesData();
        }
    }
}
