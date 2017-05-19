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
    public partial class Item : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public Item()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = ws.AddItem(ItemName.Text, ItemPrice.Text).ToString();
            if (s != "")
            {
                ItemID.Text = s;
            }
            else MessageBox.Show("I cann't Add this Item, There is an Item With The Same Name !!");
        }

      
    }
}
