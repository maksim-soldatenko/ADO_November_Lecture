using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroOrm.Domain;

namespace MicroOrm
{
    public partial class Form1 : Form
    {
        private DbDemoOperations _demoOperations;
        public Form1()
        {
            InitializeComponent();

            _demoOperations = new DapperDemoOperations();
        }

        private void btnFillOrders_Click(object sender, EventArgs e)
        {
            _demoOperations.FillOrders();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _demoOperations = new DapperDemoOperations();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                _demoOperations = new SimpleDataDemoOPerations();
            }
        }

        private void btnClearOrders_Click(object sender, EventArgs e)
        {
            _demoOperations.ClearOrders();
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            var orders = _demoOperations.GetOrders();
            foreach (var order in orders)
            {
                richText.AppendText(order.ToString());
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var order = _demoOperations.GetOrders().First();
            _demoOperations.UpdateOrder(order.Id, "Updated by button update.");
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            var orderId = _demoOperations.GetOrders().Last().Id;
            var order = _demoOperations.GetOrder(orderId);

            richText.AppendText(order.ToString());
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            var customerId = _demoOperations.GetOrders().Last().CustomerId;

            var order = new Order() {CustomerId = customerId, Date = DateTime.Now, Comments = "Insert button works"};

            _demoOperations.InsertOrder(order);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var orderId = _demoOperations.GetOrders().First().Id;
            _demoOperations.DeleteOrder(orderId);
        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            var customerId = _demoOperations.GetOrders().First().CustomerId;

            var orders = _demoOperations.GetOrdersByCustomerId(customerId);
            foreach (var order in orders)
            {
                richText.AppendText(order.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richText.Clear();
        }
    }
}
