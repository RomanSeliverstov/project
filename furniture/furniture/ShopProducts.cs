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
    public partial class ShopProducts : Form
    {
        private DataTable data;
        public ShopProducts()
        {
            InitializeComponent();
            DataBaseQuery dq = new DataBaseQuery();
            data = dq.ShowShopProducts();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelExport toexcel = new ExcelExport();
            toexcel.export(data);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (textBox1.Text != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString() == textBox1.Text)
                            {
		                        dataGridView1.Rows[i].Selected = true;
                                dataGridView1.FirstDisplayedScrollingRowIndex = j;
                                break;
                            }
                    }
                    else dataGridView1.ClearSelection();
            }
        }

        private void ShopProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data;
        }


        public int index;
        public string keyValue;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
    {
        
              if (e.Button == MouseButtons.Right)
             {
     
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
            index = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            dataGridView1.Rows[index].Selected = true;
            keyValue = dataGridView1.Rows[index].Cells[0].Value.ToString();
            
             
             }
         
     }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShopProducts edit = new EditShopProducts(keyValue);
            edit.Show();
        }


    }
}
