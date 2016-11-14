using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Domain;

namespace Dal
{
    public class DemoContext: DbContext
    {
        public DemoContext(): base("Name=DefaultConnectionString")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<DemoContext>());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
    }
}
