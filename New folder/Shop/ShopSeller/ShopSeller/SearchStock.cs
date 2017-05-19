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
    public partial class SearchStock : Form
    {
        ServiceReference2.ShopClient ws = new ServiceReference2.ShopClient();
        public SearchStock()
        {
            InitializeComponent();
        }
    }
}
