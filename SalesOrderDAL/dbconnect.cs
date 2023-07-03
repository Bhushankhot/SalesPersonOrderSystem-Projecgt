using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SalesOrderEntity;
namespace SalesOrderDAL
{
    public class dbconnect : IDataAccess
    {
        SalesOrderEntity dbctx;
        public dbconnect()
        {
        }

        public void AddOrderForm(Order ord)
        {
            dbctx.Orders.Add(ord);
            dbctx.SaveChanges();
        }

        public void DisplayOrders(string sname)
        {

        }
        public List<Order> GetAllOrders()
        {
            var dbctx = new CURDBEntities();
            var result = dbctx.Orders.ToList();
            return result;

        }

        public Order GetorderById(int id)
        {
            var dbctx = new CURDBEntities();
            var record = dbctx.Orders.Find(id);
            if (record != null)
                return record;
            else
                throw new Exception("Record Not Found....");
            dbctx.SaveChanges();

        }


    }
}


