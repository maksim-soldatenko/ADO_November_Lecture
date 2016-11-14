using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Dal;
using Dal.Repository;
using RegistrationExtensions = Autofac.RegistrationExtensions;

namespace EfDemo.App_Start
{
    public class IocConfig
    {
        public static IContainer Configure()
        {
            var container = CreateContainer().Build(); 
            var resolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(resolver); //// Register resolver for Asp.Net MVC
            return container;
        }

        private static ContainerBuilder CreateContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(IocConfig).Assembly);

            builder.Register(c => new DemoContext()).As<DbContext>().InstancePerRequest();
            builder.RegisterType(typeof(UnitOfWork)).As<IUnitOfWork>().InstancePerRequest();

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            return builder;
        }
    }
}