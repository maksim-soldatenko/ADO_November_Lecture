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
        private DataSetOperations _dataSetOperations;
        public Form1()
        {
            InitializeComponent();
            _dataSetOperations = new DataSetOperations();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var dataAccess = new DataAccess();
            var customers = dataAccess.ReadAllCustomers();

            GridCustomers.DataSource = customers;
            this.GridCustomers.SelectionChanged -= GridCustomers_SelectionChanged;
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

        private void button3_Click(object sender, EventArgs e)
        {
            _dataSetOperations.Init();
            GridDsCustomers.DataSource = _dataSetOperations.GetCustomersTable();

            GridDsCustomers.SelectionChanged -= ShowRelatedOrders;
            GridDsCustomers.SelectionChanged += ShowRelatedOrders;
        }

        private void ShowRelatedOrders(object sender, EventArgs e)
        {
            var selected = GridDsCustomers.CurrentRow;
            var id = int.Parse(selected.Cells[0].Value.ToString());

            GridDsOrders.DataSource = _dataSetOperations.GetOrdersByCustomer(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _dataSetOperations.MakeSomeChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selected = GridDsCustomers.CurrentRow;
            var id = int.Parse(selected.Cells[0].Value.ToString());

            _dataSetOperations.InsertOrder(id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _dataSetOperations.SubmitChanges();
        }
    }
}
