using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOrm.Domain;

namespace MicroOrm
{
    public class SimpleDataDemoOPerations: DbDemoOperations
    {
        public override void ClearOrders()
        {
            throw new NotImplementedException();
        }

        public override void FillOrders()
        {
            throw new NotImplementedException();
        }

        public override List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public override Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public override void UpdateOrder(int orderId, string comment)
        {
            throw new NotImplementedException();
        }

        public override void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public override void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
