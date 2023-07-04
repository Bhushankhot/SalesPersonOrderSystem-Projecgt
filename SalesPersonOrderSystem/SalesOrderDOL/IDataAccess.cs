using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDOL
{
    interface IDataAccess
    {
        void AddOrderToDB(Order order);

        IEnumerable<Order> DisplayOrdersFromDB(string sname);
        List<Order> GetAllOrders();
        Order GetorderById(int id);
    }
}
