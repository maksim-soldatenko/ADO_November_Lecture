using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orders
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var dataAccess = new DataAccess();
            var customers = dataAccess.ReadAllCustomers();

            GridCustomers.DataSource = customers;
            this.GridCustomers.SelectionChanged += GridCustomers_SelectionChanged;
        }

        private void GridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var selected = GridCustomers.CurrentRow;
            var id = int.Parse(selected.Cells[0].Value.ToString());
            var da = new DataAccess();
            var viewModel = da.GetAllProductsByCustomerId(id);

            GridProducts.DataSource = viewModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var da = new DataAccess();
            da.ClearOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var da = new DataAccess();
            da.FillTables();
        }
    }
}
