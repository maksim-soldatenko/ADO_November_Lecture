using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Transaction
    {
        private const string ConnectionString =
            "Data Source=Epuakhaw1152\\mssqlserver01;Initial Catalog=AdoNetDemoDb;Integrated Security=True";

        public void InsertTransact(Action<string> logAction)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var transaction = connection.BeginTransaction("trn1");
                var command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "INSERT INTO Orders VALUES (7, GETDATE(), 'By Transaction')";
                    command.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO Orders VALUES (9, GETDATE(), 'By Transaction')";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception exception)
                {
                    logAction(exception.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex)
                    {
                        logAction(ex.Message);

                        throw;
                    }
                }



            }
        }
    }
}
