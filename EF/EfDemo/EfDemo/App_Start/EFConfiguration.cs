using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Web;
using EfDemo.CommandInterception;
using EfDemo.DbConfigurations;

namespace EfDemo.App_Start
{
    public static class EFConfiguration
    {
        public static void Configure()
        {
            DbInterception.Add(new DemoInterceptor());
            DbConfiguration.SetConfiguration(new DemoConfiguration());
        }
    }
}