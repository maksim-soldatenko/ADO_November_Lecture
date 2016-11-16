using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace EfDemo.DbConfigurations
{
    public class DemoConfiguration: DbConfiguration
    {
        public DemoConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new DemoExecutionStrategy(5, TimeSpan.FromSeconds(5)));
        }
    }

    public class DemoExecutionStrategy: DbExecutionStrategy
    {
        public DemoExecutionStrategy(int maxRetryCount, TimeSpan maxDelay):base(maxRetryCount, maxDelay)
        {
        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            var logger = new Logger.Logger();

            logger.Warning(exception, "ALARM{0}", Environment.NewLine);

            return true;
        }
    }
}