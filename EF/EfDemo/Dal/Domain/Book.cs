using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Domain
{
    public class Book: IEntity
    {
        public string BookName { get; set; }

        public string Annotation { get; set; }

        public Author Author { get; set; }

        public ICollection<Publisher> Publishers { get; set; }
        public int Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
