using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Domain
{
    public class Publisher:IEntity
    {
        public string PublisherName { get; set; }
        public int Rate { get; set; }

        public Book Book { get; set; }
        public int Id { get; set; }
    }
}
