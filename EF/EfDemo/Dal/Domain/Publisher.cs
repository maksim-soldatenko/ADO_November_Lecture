using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Domain
{
    public class Publisher:Entity
    {
        public string PublisherName { get; set; }
        public int Rate { get; set; }

        public Book Book { get; set; }
    }
}
