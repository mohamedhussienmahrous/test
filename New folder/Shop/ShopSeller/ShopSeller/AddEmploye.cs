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
    public partial class AddEmploye : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public AddEmploye()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string s=ws.AddEmploye(EmpName.Text, EmpAddress.Text).ToString();
            //EmpID.Text = s;

            string s = ws.AddEmploye(EmpName.Text, EmpAddress.Text).ToString();
            if (s != "")
            {
                EmpID.Text = s;
            }
            else MessageBox.Show("I cann't Add this Employee, There is an Employee With The Same Name !!");
        }
    }
    }

