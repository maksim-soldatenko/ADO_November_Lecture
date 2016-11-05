using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var txt = String.Format("ORDER id={0}, customer = {1}, date = {2}, comments = {3}{4}", order.Id,
                    order.CustomerId, order.Date, order.Comments, Environment.NewLine);
                richText.AppendText(txt);
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var order = _demoOperations.GetOrders().First();
            _demoOperations.UpdateOrder(order.Id, "Updated by button update.");
        }
    }
}
