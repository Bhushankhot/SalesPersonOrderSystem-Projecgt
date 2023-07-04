using SalesOrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDOL
{
    public class SalesOrderCRUD : IDataAccess
    {
        public void AddOrderToDB(Order order)
        {
            var dbCtx = new SalesOrderDBEntities();
            dbCtx.Orders.Add(order);
            dbCtx.SaveChanges();
        }

        public IEnumerable<Order> DisplayOrdersFromDB(string sname)
        {
            var dbCtx = new SalesOrderDBEntities();
            var listSales = dbCtx.SalesPersons.ToList();
            var listCust = dbCtx.Customers.ToList();
            var listOrders = dbCtx.Orders.ToList();

            
            var records = listOrders.Where(e => e.salesperson_id == (listSales.Where(s => s.Name == sname).Select(w => w.ID).SingleOrDefault()));
            return records;
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetorderById(int id)
        {
            throw new NotImplementedException();
        }

        public bool isValidSaleName(string sname)
        {
            var dbCtx = new SalesOrderDBEntities();
            //var listSales = dbCtx.SalesPersons.ToList();

            var record = dbCtx.SalesPersons
                                .Where(s => s.Name == sname).ToList();
            if (record != null)
            {
                return true;
            }
            throw new Exception("an error occured");


        }
        public bool isValidCustName(string cname)
        {
            var dbCtx = new SalesOrderDBEntities();
            var listCust = dbCtx.Customers.ToList();

            var record = listCust.Where(c => c.Name == cname);
            if (record != null)
            {
                return true;
            }
            return false;
        }

        public int GetCustId(string name)
        {
            var dbCtx = new SalesOrderDBEntities();
            var nm = dbCtx.Customers.ToList();

            var rec = nm.Where(i => i.Name == name).Select(e => e.ID).FirstOrDefault();
            
            return rec;
        }
        
        public int GetSalId(string name)
        {
            var dbCtx = new SalesOrderDBEntities();
            var nm = dbCtx.SalesPersons.ToList();

            var rec = nm.Where(i => i.Name == name).Select(e => e.ID).FirstOrDefault();
            return rec;
        }

    }
}
