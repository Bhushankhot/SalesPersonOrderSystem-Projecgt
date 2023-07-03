using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderEntity;


namespace SalesOrderDAL
{
    interface IDataAccess
    {

        void AddOrderForm(Order ord);

        void DisplayOrders(string sname);
        List<Order> GetAllOrders();
        Order GetorderById(int id);

    }
}
