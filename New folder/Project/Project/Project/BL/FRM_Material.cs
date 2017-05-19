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
    public partial class FRM_Material : Form
    {
        private CompanyDataBase company = CompanyDataBase.Instance;

        public FRM_Material()
        {
            InitializeComponent();
            label4.Text = 0.ToString();
        }
        public FRM_Material(int id)
        {
            InitializeComponent();
            Material mat = company.companyDB.Materials.FirstOrDefault(m => m.MeterialId == id);
            if (mat != null)
            {
                label4.Text = id.ToString();
                textBox1.Text = mat.Name;
                richTextBox1.Text = mat.Descripion;
                textBox2.Text = mat.Quantity.ToString();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(label4.Text.ToString());

            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {

                MessageBox.Show("برجاء استكمال بيانات الخامه");
            }
            else
            {
                if (id == 0)
                {
                    Material mat = new Material
                    {
                        Name = textBox1.Text.ToString(),
                        Descripion = richTextBox1.Text.ToString(),
                        PricePerKilo = Decimal.Parse(textBox2.Text.ToString()),
                        Quantity = 0
                    };
                    company.companyDB.Materials.Add(mat);
                    MessageBox.Show("تم حفظ الخامه بنجاح");

                }
                else
                {
                    Material editmat = company.companyDB.Materials.FirstOrDefault(m => m.MeterialId == id);
                    if (editmat != null)
                    {


                        editmat.Name = textBox1.Text.ToString();
                        editmat.Descripion = richTextBox1.Text.ToString();
                        editmat.PricePerKilo = int.Parse(textBox2.Text.ToString());
                        company.companyDB.Materials.Attach(editmat);
                    }
                }
                this.Close();
                company.companyDB.SaveChanges();

            }
        }
        //chars only
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
        private void textBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^.]" )&& (e.KeyChar != '\b'))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        private void txtAdd_KeyPress(object sender,System.Windows.Forms. KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsNumber(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void FRM_Material_Load(object sender, EventArgs e)
        {
            label4.Hide();

            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
          //  textBox3.KeyPress += new KeyPressEventHandler(txtAdd_KeyPress);



        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
