using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furniture
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(620, 100);
            this.MinimumSize = new System.Drawing.Size(620, 100);
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void графикПрибылиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartProfitForm chart = new ChartProfitForm();
            chart.ShowDialog();
        }

       

        private void графикПроходимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartPassabilityForm chart = new ChartPassabilityForm();
            chart.ShowDialog();
        }

        private void ShopProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopProducts shopProducts = new ShopProducts();
            shopProducts.ShowDialog();
        }

        private void контактыФирмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmsContacts firms = new FirmsContacts();
            firms.ShowDialog();
        }

        

        
    }
}
