using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling;
using Orders.Domain;

namespace Orders
{
    public class Transient
    {
        private const string ConnectionString = "Data Source=Epuakhaw1152\\mssqlserver01;Initial Catalog=AdoNetDemoDb;Integrated Security=True";

        public List<Product> GetProductsWithRetry(Action<string> logAction)
        {
            var res = new List<Product>();

            var retryStrategy = new Incremental("incr1", 120, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            //ITransientErrorDetectionStrategy
            //SqlAzureTransientErrorDetectionStrategy
            var retryPolicy = new RetryPolicy<SqlDatabaseTransientErrorDetectionStrategy>(retryStrategy);

            var cmd = "SELECT * FROM Products" + Environment.NewLine + "WAITFOR DELAY '00:05'";

            retryPolicy.Retrying += (sender, eventArgs) =>
            {
                //Debugger.Launch();
                logAction(String.Format("Retrying, CurrentRetryCount = {0} , Exception = {1}",
                    eventArgs.CurrentRetryCount, eventArgs.LastException.Message));
                if (eventArgs.CurrentRetryCount>1)
                {
                    cmd = "SELECT * FROM Products";
                }
            };

            using (var reliableConnection = new ReliableSqlConnection(ConnectionString, retryPolicy, retryPolicy))
            {
                using (var connection = reliableConnection.Open())
                {
                    retryPolicy.ExecuteAction(() =>
                    {
                        try
                        {
                            var command = new SqlCommand(cmd, connection);
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    res.Add(new Product() {Id = reader.GetInt32(0), Name = reader.GetString(1)});
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            var to = exception is TimeoutException;

                            throw new TimeoutException(exception.Message);
                        }
                    });
                }
            }

            return res;
        }
    }
}
