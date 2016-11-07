using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperExtensions;
using DapperExtensions.Mapper;
using MicroOrm.Domain;

namespace MicroOrm
{
    public class DapperDemoOperations: DbDemoOperations
    {
        public DapperDemoOperations()
        {
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(PluralizedAutoClassMapper<>);
        }

        public override void ClearOrders()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM Orders");
            }
        }

        public override void FillOrders()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                connection.Execute(@"INSERT INTO Orders VALUES (@custId, @datetime, @comments)",
                    new[]
                    {
                        new {custId = 1, datetime = DateTime.Now, comments = "Inserted by multiple times approach"},
                        new {custId = 7, datetime = DateTime.Now, comments = "Inserted by multiple times approach"},
                        new {custId = 9, datetime = DateTime.Now, comments = "Inserted by multiple times approach"}
                    });
            }
        }

        public override List<Order> GetOrders()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var orders = connection.Query<Order>("SELECT * FROM Orders");

                return orders.ToList();
            }
        }

        public override Order GetOrder(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var order = connection.Get<Order>(id);

                return order;
            }
        }

        public override void UpdateOrder(int orderId, string comment)
        {
            var order = GetOrder(orderId);
            order.Comments = comment;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Update(order);
            }
        }

        public override void DeleteOrder(int id)
        {
            var order = GetOrder(id);
            using (var connection = new SqlConnection(ConnectionString))
            {
                var predicate = Predicates.Field<Order>(f => f.Id, Operator.Eq, id);
                connection.Delete<Order>(predicate);
            }
        }

        public override List<Order> GetOrdersByCustomerId(int customerId)
        {
            var predicate = Predicates.Field<Order>(f => f.CustomerId, Operator.Eq, customerId);
            var sort = Predicates.Sort<Order>(o => o.Date, false);

            using (var connection = new SqlConnection(ConnectionString))
            {
                return connection.GetList<Order>(predicate, new List<ISort>() {sort}).ToList();
            }
        }

        public override void InsertOrder(Order order)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Insert(order);
            }
        }
    }
}
