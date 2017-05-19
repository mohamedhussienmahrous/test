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
    public partial class FRM_Supplier : Form
    {
        decimal dep=0;
        decimal cri = 0;
        private readonly CompanyDataBase company = CompanyDataBase.Instance;
        public FRM_Supplier()
        {
            InitializeComponent();
        }
        public FRM_Supplier(int id)
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier sub;
            //  int id = int.Parse(label5.Text.ToString());

            if (textBox1.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم المورد");
            }
            else
            {
                int id = 0;
                if (id == 0)
                {
                    if (textBox2.Text == "")
                    {
                        dep = 0;
                    }
                    else dep = decimal.Parse(textBox2.Text.ToString());
                    if (textBox3.Text == "")
                    {
                        cri = 0;
                    }
                    else cri = decimal.Parse(textBox3.Text.ToString());



                    sub = new Supplier()
                    {
                        Name = textBox1.Text.ToString(),

                        Depit = dep,
                        Credit = cri
                    };
                    company.companyDB.Suppliers.Add(sub);
                }


                else
                {
                    sub = new Supplier()
                    {
                        SupplierId = id,
                        Name = textBox1.Text.ToString(),
                        Depit = decimal.Parse(textBox2.Text.ToString()),
                        Credit = decimal.Parse(textBox3.Text.ToString())

                    };
                    company.companyDB.Suppliers.Attach(sub);

                }
                MessageBox.Show("تمت اضافه المورد بنجاح");
                this.Close();
                company.companyDB.SaveChanges();



            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Supplier_Load(object sender, EventArgs e)
        {

        }
    }
}
