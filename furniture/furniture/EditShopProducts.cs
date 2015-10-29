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
    public partial class EditShopProducts : Form
    {
        
        public EditShopProducts(string value)
        {
            DataTable data;
            string Value = value;
            InitializeComponent();
            DataBaseQuery dq = new DataBaseQuery();
            data = dq.GetOneProduct(Value);
            textBox1.Text = data.Rows[0].Field<string>("product_name");
            textBox2.Text = data.Rows[0].Field<int>("product_type").ToString();
            textBox3.Text = data.Rows[0].Field<int>("product_price").ToString();
            
        }
    }
}
