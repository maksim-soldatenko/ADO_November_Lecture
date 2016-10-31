using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class DataSetOperations
    {
        private const string ConnectionString = "Data Source=Epuakhaw1152\\mssqlserver01;Initial Catalog=AdoNetDemoDb;Integrated Security=True";

        private DataSet _dataSet;

        public void Init()
        {
            _dataSet = new DataSet();

            var selectCommand = @"SELECT * FROM Customers
                                    SELECT * FROM Orders";

            using (var adapter = new SqlDataAdapter(selectCommand, ConnectionString))
            {
                adapter.TableMappings.Add("Customers", "Customers");
                adapter.TableMappings.Add("Customers1", "Orders");

                adapter.Fill(_dataSet, "Customers");

                _dataSet.Relations.Add("CustomerOrders", _dataSet.Tables["Customers"].Columns["Id"],
                    _dataSet.Tables["Orders"].Columns["CustomerId"]);
            }
        }

        public DataTable GetCustomersTable()
        {
            return _dataSet.Tables["Customers"];
        }

        public DataTable GetOrdersByCustomer(int customerId)
        {
            var table = _dataSet.Tables["Orders"].Clone();
            var relation = _dataSet.Relations["CustomerOrders"];

            foreach (DataRow dataRow in _dataSet.Tables["Customers"].Rows)
            {
                if ((int)dataRow[0]==customerId)
                {
                    foreach (var childRow in dataRow.GetChildRows(relation))
                    {
                        var newRow = table.NewRow();

                        for (int i = 0; i < childRow.ItemArray.Length; i++)
                        {
                            newRow[i] = childRow.ItemArray[i];
                        }

                        table.Rows.Add(newRow);
                    }

                    break;
                }
            }

            return table;
        }

        public void MakeSomeChanges()
        {
            var orders = _dataSet.Tables["Orders"];

            foreach (DataRow row in orders.Rows)
            {
                if ((int)row["CustomerId"] == 7)
                {
                    row["CustomerId"] = 9;
                    row["Comments"] = "Moved from customer 7";
                }

                if ((int)row["CustomerId"] == 1)
                {
                    row.Delete();
                }
            }
        }

        public void SubmitChanges()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                using (var adapter = GetOrdersAdapter(connection))
                {
                    var i = adapter.Update(_dataSet, "Orders");
                }
            }
        }

        public void InsertOrder(int id)
        {
            var orders = _dataSet.Tables["Orders"];
            var newRow = orders.NewRow();
            newRow["CustomerId"] = id;
            newRow["Date"] = DateTime.Now;
            newRow["Comments"] = "Added by button add";

            orders.Rows.Add(newRow);
        }

        private SqlDataAdapter GetOrdersAdapter(SqlConnection connection)
        {
            var selectCommand = new SqlCommand("SELECT * FROM Orders");
            selectCommand.Connection = connection;
            var adapter = new SqlDataAdapter(selectCommand);
            adapter.TableMappings.Add("Orders", "Orders");

            var insert = new SqlCommand("INSERT INTO Orders VALUES(@customerId, @date, @comments)");
            insert.Parameters.AddRange(new[] { CustomerId(), Date(), Comments() });
            insert.Connection = connection;

            var update = new SqlCommand("UPDATE Orders SET CustomerId = @customerId, Date = @date, Comments = @comments WHERE Id = @id");
            update.Parameters.AddRange(new[] { Id(), CustomerId(), Date(), Comments() });
            update.Connection = connection;

            var delete = new SqlCommand("DELETE FROM Orders WHERE Id = @id");
            delete.Parameters.Add(Id());
            delete.Connection = connection;

            adapter.DeleteCommand = delete;
            adapter.InsertCommand = insert;
            adapter.UpdateCommand = update;

            return adapter;
        }

        private SqlParameter Date()
        {
            var date = new SqlParameter("@date", SqlDbType.DateTime);
            date.SourceColumn = "Date";
            return date;
        }

        private SqlParameter CustomerId()
        {
            var customerId = new SqlParameter("@customerId", SqlDbType.Int);
            customerId.SourceColumn = "CustomerId";
            return customerId;
        }

        private SqlParameter Id()
        {
            var id = new SqlParameter("@id", SqlDbType.Int);
            id.SourceColumn = "Id";
            return id;
        }

        private SqlParameter Comments()
        {
            var comments = new SqlParameter("@comments", SqlDbType.VarChar);
            comments.SourceColumn = "Comments";
            return comments;
        }

    }
}
