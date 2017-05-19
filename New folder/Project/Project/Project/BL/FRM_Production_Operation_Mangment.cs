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
    public partial class FRM_Production_Operation_Mangment : Form
    {
        FRM_Production_Operation po = new FRM_Production_Operation();
        
        public FRM_Production_Operation_Mangment()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            po.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
