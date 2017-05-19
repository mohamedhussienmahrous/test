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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddEmploye().ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Stock().ShowDialog();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Item().ShowDialog();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Invoice().ShowDialog();
        }

        private void invoiceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateEmployes().ShowDialog();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateItem().ShowDialog();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateStock().ShowDialog();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            new SearchInvoice().ShowDialog();
        }

        private void iTemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteItem().ShowDialog();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteEmployee().ShowDialog();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteStock().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Search().ShowDialog();
        }
    }
}
