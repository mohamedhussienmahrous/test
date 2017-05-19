using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.BL
{
    public partial class FRM_Customer_Order_Mangment : Form
    {
        FRM_CustomerMakeOrder com = new FRM_CustomerMakeOrder();
        public FRM_Customer_Order_Mangment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            com.ShowDialog();
        }
    }
}
