using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DataAccessLayer;

namespace Project.BL
{
    public partial class FRM_Customer_Mangments : Form
    {

        private readonly CompanyDataBase company = CompanyDataBase.Instance;

        public FRM_Customer_Mangments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FRM_customers().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FRM_Customer_Mangments_Load(object sender, EventArgs e)
        {
            var cus =
               company.companyDB.Customers.ToList();
            var bindingList = new BindingList<Customer>(cus);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
         //   dataGridView1.Columns["Name"].Name="الاسم";

            dataGridView1.Columns.Remove("Orders");
        }
    }
}
