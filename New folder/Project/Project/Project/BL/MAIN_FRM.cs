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
    public partial class MAIN_FRM : Form
    {
        BL.FRM_Customer_acc_mangmentcs cam = new FRM_Customer_acc_mangmentcs();
        BL.FRM_Product p = new FRM_Product();
        BL.FRM_Product_Mangment pm = new FRM_Product_Mangment();
        BL.FRM_Material m = new FRM_Material();
        BL.FRM_MaterialInventory mi = new FRM_MaterialInventory();
        BL.FRM_Matrial_Inventory_MAngment mim = new FRM_Matrial_Inventory_MAngment();
        BL.FRM_CustomerMakeOrder cmo = new FRM_CustomerMakeOrder();
        BL.FRM_Customer_Order_Mangment com = new FRM_Customer_Order_Mangment();
        BL.FRM_Production_Operation po = new FRM_Production_Operation();
        BL.FRM_Production_Operation_Mangment pom = new FRM_Production_Operation_Mangment();
        BL.FRM_Supplier s = new FRM_Supplier();
        BL.FRM_Sublier_Mangment sm = new FRM_Sublier_Mangment();
        

        public MAIN_FRM()
        {
            InitializeComponent();
        }

        private void اضافهعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_customers().ShowDialog();
        }

        private void ادارهالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_Customer_Mangments().ShowDialog();
        }

        private void حسابالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FRM_Customer_acc_mangmentcs().ShowDialog();
        }

        private void اضافهمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.ShowDialog();
        }

        private void ادارهالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.ShowDialog();
        }

        private void اضافهخامهجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.ShowDialog();
        }

        private void توريدكمياتجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mi.ShowDialog();
        }

        private void ادارهالخاماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mim.ShowDialog();
        }

        private void اضافهبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmo.ShowDialog();
        }

        private void ادارهعملياتجديدهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.ShowDialog();
        }

        private void اضافهعمليهانتاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            po.ShowDialog();
        }

        private void ادارهعملياتالانتاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pom.ShowDialog();
        }

        private void اضافهموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s.ShowDialog();
        }

        private void ادارهالموردونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sm.ShowDialog();
        }

        private void MAIN_FRM_Load(object sender, EventArgs e)
        {

        }
    }
}
