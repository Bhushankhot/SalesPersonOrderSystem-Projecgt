using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesOrderDAL
{
    public class dbconnect : IDataAccess
    {
        
        public dbconnect()
        {
        }

        public void AddOrderForm(Order ord)
        {
            var dbctx = new ORDER_DBEntities();
            dbctx.Orders.Add(ord);
            dbctx.SaveChanges();
        }

        public void DisplayOrders(string sname)
        {

        }
        public List<Order> GetAllOrders()
        {
            var dbctx = new ORDER_DBEntities();
            var result = dbctx.Orders.ToList();
            return result;

        }

        public Order GetorderById(int id)
        {
            var dbctx = new ORDER_DBEntities();
            var record = dbctx.Orders.Find(id);
            if (record != null)
            { 
                return record;
            }
            else
            {
                throw new Exception("Record Not Found....");
                dbctx.SaveChanges();
            }
                

        }


    }
}


