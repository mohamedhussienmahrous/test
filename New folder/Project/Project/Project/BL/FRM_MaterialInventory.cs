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
    public partial class FRM_MaterialInventory : Form
    {
        private CompanyDataBase company = CompanyDataBase.Instance;

        public FRM_MaterialInventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_MaterialInventory_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = company.companyDB.Materials.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "MeterialId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int material=int.Parse(comboBox1.SelectedValue.ToString()) ;
            Material matinv = company.companyDB.Materials.FirstOrDefault(m => m.MeterialId == material);
            if (matinv != null)
            {
                matinv.Quantity = matinv.Quantity==null?double.Parse(textBox1.Text.ToString()): matinv.Quantity+ double.Parse(textBox1.Text.ToString());
                company.companyDB.Materials.Attach(matinv);
            }
            else
            {
                MessageBox.Show("هذة الخامه غير موجودة مسبقا!!");
            }

            company.companyDB.SaveChanges();
            this.Close();
        }
    }
}
