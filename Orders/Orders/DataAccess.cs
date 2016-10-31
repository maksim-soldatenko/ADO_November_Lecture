using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain;
using Orders.Models;

namespace Orders
{
    public class DataAccess
    {
        private const string ConnectionString = "Data Source=Epuakhaw1152\\mssqlserver01;Initial Catalog=AdoNetDemoDb;Integrated Security=True";

        public List<Customer> ReadAllCustomers()
        {
            var result = new List<Customer>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = "SELECT * FROM CUSTOMERS";
                var command = new SqlCommand(cmd, connection) { CommandType = CommandType.Text };

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new Customer()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            TelephoneNumber = reader["TelephoneNumber"].ToString()
                        };

                        result.Add(customer);
                    }
                }

                connection.Close();
            }

            return result;
        }

        public void ClearOrders()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var cmd = "DELETE FROM ORDERS";
                using (var command = new SqlCommand(cmd, connection))
                {
                    var affected = command.ExecuteNonQuery();
                }
                
                connection.Close();
            }
        }

        public void FillTables()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var cmd = "INSERT INTO Orders VALUES (1, GETDATE(), 'First order')";

                using (var command = new SqlCommand(cmd, connection))
                {
                    var affected = command.ExecuteNonQuery();

                    cmd = "INSERT INTO Orders VALUES (7, GETDATE(), 'New order')" + Environment.NewLine +
                          "INSERT INTO Orders VALUES (9, GETDATE(), 'New order')";
                    command.CommandText = cmd;

                    affected = command.ExecuteNonQuery();
                }

                connection.Close();
            }

            var orders = GetOrdersIds();
            var rnd = new Random();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("", connection))
                {
                    foreach (var id in orders)
                    {
                        var cmd = String.Format("INSERT INTO ProductLists VALUES ({0},{1},{2},{3})", id, rnd.Next(1, 4),
                            rnd.Next(1, 5), rnd.Next(5, 17));
                        command.CommandText = cmd;

                        command.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }

        public List<ProductListViewModel> GetAllProductsByCustomerId(int customerId)
        {
            var res = new List<ProductListViewModel>();

            var products = new Dictionary<int, string>();

            var cmd = "SELECT * FROM Products" + Environment.NewLine +
                      String.Format(
                          "SELECT Orders.Id AS OrderId, Orders.Date, ProductLists.ProductId, ProductLists.Count, ProductLists.Price FROM Orders JOIN ProductLists ON Orders.Id = ProductLists.OrderId WHERE CustomerId = {0}",
                          customerId);

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(cmd, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(reader.GetInt32(0), reader.GetString(1));
                        }

                        reader.NextResult();

                        while (reader.Read())
                        {
                            var model = new ProductListViewModel()
                            {
                                OrderId = reader.GetInt32(0),
                                Date = reader.GetDateTime(1).ToString("d"),
                                ProductName = products[reader.GetInt32(2)],
                                Count = reader.GetInt32(3),
                                Price = reader.GetDouble(4)
                            };

                            res.Add(model);
                        }
                    }
                }

                connection.Close();
            }

            return res;
        }

        private List<int> GetOrdersIds()
        {
            var res = new List<int>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Close();

                connection.Open();

                var cmd = "Select Id from Orders";
                var command = new SqlCommand(cmd, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        res.Add(reader.GetInt32(0));
                    }
                }

                connection.Close();
            }

            return res;
        }
    }
}
