using System.Collections.Generic;
using Dal.Domain;

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
            context.Authors.RemoveRange(context.Authors); //Clear db

            var pub1 = new Publisher() {PublisherName = "Pub1", Rate = 1};
            var pub2 = new Publisher() { PublisherName = "Pub2", Rate = 2 };
            var pub3 = new Publisher() { PublisherName = "Pub3", Rate = 3 };

            var book1 = new Book() {BookName = "Book1", Publishers = new List<Publisher>() {pub1, pub2}};
            var book2 = new Book() { BookName = "Book2", Publishers = new List<Publisher>() { pub3 } };

            var author = new Author() {Name = "Maksim", Books = new List<Book>() {book1, book2}, YearOfBirth = 1984};

            context.Authors.Add(author);
            context.SaveChanges();
        }
    }
}
