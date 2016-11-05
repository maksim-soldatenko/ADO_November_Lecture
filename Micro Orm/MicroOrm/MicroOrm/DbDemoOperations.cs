using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroOrm.Domain;

namespace MicroOrm
{
    public abstract class DbDemoOperations
    {
        protected string ConnectionString
        {
            get
            {
                return "Data Source=Epuakhaw1152\\mssqlserver01;Initial Catalog=AdoNetDemoDb;Integrated Security=True";
            }
        }

        public abstract void ClearOrders();
        public abstract void FillOrders();
        


        public abstract List<Order> GetOrders();
        public abstract Order GetOrder(int id);
        public abstract void InsertOrder(Order order);
        public abstract void UpdateOrder(int orderId, string comment);
        public abstract void DeleteOrder(int id);

    }
}
