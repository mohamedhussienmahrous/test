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
    public partial class FRM_Sublier_Mangment : Form
    {
        private readonly CompanyDataBase company = CompanyDataBase.Instance;
        public FRM_Sublier_Mangment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FRM_Supplier().ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Sublier_Mangment_Load(object sender, EventArgs e)
        {
            var supp =
               company.companyDB.Suppliers.ToList();
            var bindingList = new BindingList<Supplier>(supp);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
            this.dataGridView1.Columns["SupplierId"].HeaderText = "رقم المورد";
            this.dataGridView1.Columns["Name"].HeaderText = "اسم المورد";
            this.dataGridView1.Columns["Credit"].HeaderText = "رصيد دائن";
            this.dataGridView1.Columns["Depit"].HeaderText = "رصيد مدين";

            dataGridView1.AutoResizeColumns();
            // this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
    }
}
