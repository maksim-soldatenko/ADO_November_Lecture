using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Domain
{
    public class Author: Entity
    {
        public string Name { get; set; }

        public int YearOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
