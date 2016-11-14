using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dal.Domain;

namespace EfDemo.Models
{
    public class AuthorsModel
    {
        public IEnumerable<Author> Authors { get; set; }
    }
}