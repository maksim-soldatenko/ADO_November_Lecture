using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Models
{
    public class ProductListViewModel
    {
        public int OrderId { get; set; }
        public string Date { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
