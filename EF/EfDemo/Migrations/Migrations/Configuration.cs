namespace Migrations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //enable-migrations -ProjectName Migrations -ContextProjectName Dal
    //Add-Migration InitialCreate -ProjectName Migrations
    //Update-Database -ProjectName Migrations -Verbose
    //migrate.exe Migrations.dll Configuration Dal.dll /startUpConfigurationFile="D:\CDP EF\ADO.Net November lecture\ADO_November_Lecture\EF\EfDemo\EfDemo\Web.config"
    internal sealed class Configuration : DbMigrationsConfiguration<Dal.DemoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dal.DemoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
