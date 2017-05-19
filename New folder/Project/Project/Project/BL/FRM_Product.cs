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
    public partial class FRM_Product : Form
    {
        private readonly CompanyDataBase company = CompanyDataBase.Instance;
        public FRM_Product()
        {
            InitializeComponent();
            label5.Text = 0.ToString();
        }
        public FRM_Product(int id)
        {
            InitializeComponent();
            ///fill UI
            label5.Text = id.ToString();
            Product pro = company.companyDB.Products.FirstOrDefault(p => p.ProductId == id);
            if (pro != null)
            {
                textBox1.Text = pro.Name;
                richTextBox1.Text = pro.Description;
                textBox3.Text = pro.Wieght.ToString();
                textBox2.Text = pro.PricePerUnit.ToString();
            }
        }
        private void FRM_Product_Load(object sender, EventArgs e)
        {
            label5.Hide();
            textBox1.KeyPress += new KeyPressEventHandler(charonly_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(numiriconly_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(numiriconly_KeyPress);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void charonly_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\-^\/^\*^\(^\)!£$%&]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        // number only
        private void numiriconly_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^.]") && (e.KeyChar != '\b'))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro;
            int id = int.Parse(label5.Text.ToString());

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("برجاء استكمال بيانات المنتج بالطريقه الصحيحه");
            }
            else
            {
                if (id == 0)
                {

                    pro = new Product() { Name = textBox1.Text.ToString(), Description = richTextBox1.Text.ToString(), Wieght = double.Parse(textBox3.Text.ToString()), PricePerUnit = decimal.Parse(textBox2.Text.ToString()) };
                    company.companyDB.Products.Add(pro);
                    MessageBox.Show("تم اضافه المنتج بنجاح");

                }
                else
                {
                    pro = new Product()
                    {
                        ProductId = id,
                        Name = textBox1.Text.ToString(),
                        Description = richTextBox1.Text.ToString(),
                        Wieght = double.Parse(textBox3.Text.ToString()),
                        PricePerUnit = decimal.Parse(textBox2.Text.ToString())
                    };
                    company.companyDB.Products.Attach(pro);

                }


                this.Close();
                company.companyDB.SaveChanges();
            }
        }
    }
}
