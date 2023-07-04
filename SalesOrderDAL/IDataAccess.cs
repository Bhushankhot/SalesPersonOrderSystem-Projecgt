using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SalesOrderDAL
{
    public interface IDataAccess
    {

        void AddOrderForm(Order ord);

        void DisplayOrders(string sname);
        List<Order> GetAllOrders();
        Order GetorderById(int id);

    }
}
