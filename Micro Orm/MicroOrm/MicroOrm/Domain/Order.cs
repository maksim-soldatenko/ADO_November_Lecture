using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroOrm.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public string Comments { get; set; }

        public override string ToString()
        {
            return String.Format("ORDER id={0}, customer = {1}, date = {2}, comments = {3}{4}", Id, CustomerId, Date, Comments, Environment.NewLine);
        }
    }
}
