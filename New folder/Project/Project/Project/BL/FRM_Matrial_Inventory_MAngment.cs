using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DataAccessLayer;

namespace Project.BL
{
    public partial class FRM_Matrial_Inventory_MAngment : Form
    {
        private CompanyDataBase company = CompanyDataBase.Instance;

        public FRM_Matrial_Inventory_MAngment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Material fr = new FRM_Material();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Matrial_Inventory_MAngment_Load(object sender, EventArgs e)
        {
           var Matrials =
                company.companyDB.Materials.ToList();
            var bindingList = new BindingList<Material>(Matrials);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            this.dataGridView1.Columns["MeterialId"].HeaderText = "رقم الخامه";
            this.dataGridView1.Columns["Name"].HeaderText = "اسم الخامه";
            this.dataGridView1.Columns["Descripion"].HeaderText = "وصف الخامه";
            this.dataGridView1.Columns["PricePerKilo"].HeaderText = "السعر بالكيلو";
            this.dataGridView1.Columns["Quantity"].HeaderText = "الكميه المتاحه";

        }
    }
}
