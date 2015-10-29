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
    public partial class FirmsContacts : Form
    {
        DataTable data;
        public FirmsContacts()
        {
            InitializeComponent();
            DataBaseQuery dq = new DataBaseQuery();
            data = dq.ShowFirms();
             
        }

        private void FirmsContacts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data;
        }

    }
}
