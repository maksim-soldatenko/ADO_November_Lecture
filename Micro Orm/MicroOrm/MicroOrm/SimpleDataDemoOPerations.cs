using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOrm.Domain;
using Simple.Data;

namespace MicroOrm
{
    public class SimpleDataDemoOPerations: DbDemoOperations
    {
        public override void ClearOrders()
        {
            var db = Database.Open();
            db.Orders.DeleteAll(); // db.Orders.DeleteAll(db.Orders.Id > 7);
        }

        public override void FillOrders()
        {
            var orders = new List<Order>()
            {
                new Order() { CustomerId = 1, Date = DateTime.Now, Comments = "Inserted by Simple.Data multi-insert."},
                new Order() { CustomerId = 7, Date = DateTime.Now, Comments = "Inserted by Simple.Data multi-insert."},
                new Order() { CustomerId = 9, Date = DateTime.Now, Comments = "Inserted by Simple.Data multi-insert."}
            };

            var db = Database.Open();
            db.Orders.Insert(orders);
        }

        public override List<Order> GetOrders()
        {
            var result = new List<Order>();

            var db = Database.Open();
            var orders = db.Orders.All();

            foreach (var order in orders)
            {
                var ord = (Order) order;
                result.Add(ord);
            }

            return orders;
        }

        public override Order GetOrder(int id)
        {
            var db = Database.Open();
            var order = db.Orders.Find(db.Orders.Id == id); //Gets TOP 1
            var ord = (Order) order;

            return ord;
        }

        public override void UpdateOrder(int orderId, string comment)
        {
            var db = Database.Open();
            db.Orders.UpdateById(Id: orderId, Comments: comment); // UpdateAll
        }

        public override void DeleteOrder(int id)
        {
            var db = Database.Open();
            db.Orders.DeleteById(id); //DeleteAll
        }

        public override List<Order> GetOrdersByCustomerId(int customerId)
        {
            var result = new List<Order>();

            var db = Database.Open();
            var orders = db.Orders.FindAllByCustomerId(customerId);
            foreach (var order in orders)
            {
                var ord = (Order) order;
                result.Add(ord);
            }

            return result;
        }

        public override void InsertOrder(Order order)
        {
            var db = Database.Open();
            db.Orders.Insert(order);
        }
    }
}
