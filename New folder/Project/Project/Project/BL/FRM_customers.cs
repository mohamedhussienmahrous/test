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
    public partial class FRM_customers : Form
    {

        private CompanyDataBase company = CompanyDataBase.Instance;
        Decimal dep;

        public FRM_customers()
        {
            InitializeComponent();
            label7.Text = 0.ToString();
        }
        public FRM_customers(int id )
        {
            InitializeComponent();
            label7.Text = id.ToString();
            Customer cus = company.companyDB.Customers.FirstOrDefault(c=>c.CustomerId==id);
            if (cus != null)
            {
             label7.Text = cus.CustomerId.ToString() ;
               textBox1.Text= cus.Name;
                  richTextBox1.Text       =     cus.address    ;
                  textBox3.Text           =   cus.Email           ;
                  textBox4.Text           =  cus.PhoneNum1    ;
                  textBox5.Text           =  cus.PhoneNum2    ;
                 textBox6.Text =cus.Depit.ToString()             ;
            }                                               
        }                                                   
                                                            
        private void FٌRM_customers_Load(object sender, EventArgs e)
        {
            label7.Hide();
            textBox4.KeyPress += new KeyPressEventHandler(numiriconly_KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(numiriconly_KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(numiriconly_KeyPress);
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label7.Text.ToString());
            Customer cus;

            if (textBox6.Text == "")
            { dep = 0; }
            else { dep = decimal.Parse(textBox6.Text.ToString()); }

            if (textBox1.Text == "")
            {
                MessageBox.Show("برجاء ادخال اسم العميل ");
            }
           
            else
            {
                if (id == 0)
                {
                    cus = new Customer() { Name = textBox1.Text.ToString(), address = richTextBox1.Text.ToString(), Email = textBox3.Text.ToString(), PhoneNum1 = textBox4.Text.ToString(), PhoneNum2 = textBox5.Text.ToString(), Depit = dep };
                    company.companyDB.Customers.Add(cus);

                }
                else
                {
                    cus = new Customer()
                    {
                        CustomerId = int.Parse(label7.Text.ToString()),
                        Name = textBox1.Text.ToString(),
                        address = richTextBox1.Text.ToString(),
                        Email = textBox3.Text.ToString(),
                        PhoneNum1 = textBox4.Text.ToString(),
                        PhoneNum2 = textBox5.Text.ToString(),
                        Depit = decimal.Parse(textBox6.Text.ToString())
                    };
                    company.companyDB.Customers.Attach(cus);


                }
                this.Close();
                company.companyDB.SaveChanges();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
