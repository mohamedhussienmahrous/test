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
    public partial class FRM_Product_Mangment : Form
    {
        private readonly CompanyDataBase company = CompanyDataBase.Instance;
        public FRM_Product_Mangment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          new FRM_Product().ShowDialog();
        }

        private void FRM_Product_Mangment_Load(object sender, EventArgs e)
        {
            var pros =
               company.companyDB.Products.ToList();
            var bindingList = new BindingList<Product>(pros);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
