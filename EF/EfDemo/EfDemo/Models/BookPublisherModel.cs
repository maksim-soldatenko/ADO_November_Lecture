using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dal.Domain;

namespace EfDemo.Models
{
    public class BookPublisherModel
    {
        public List<BookModel> BookModels { get; set; }
    }

    public class BookModel
    {
        public Book Book { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }
    }
}