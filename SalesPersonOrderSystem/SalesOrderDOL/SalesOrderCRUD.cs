using SalesOrderEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemException;

namespace SalesOrderDOL
{
    public class SalesOrderCRUD : IDataAccess
    {
        public void AddOrderToDB(Order order)
        {
            try
            {
                var dbCtx = new My_DBEntities();
                dbCtx.Orders.Add(order);
                dbCtx.SaveChanges();
                Console.WriteLine("Record Inserted!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Data Not Inserted");
            }
            
        }

        public IEnumerable<Order> DisplayOrdersFromDB(string sname)
        {
                var dbCtx = new My_DBEntities();
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
            var dbCtx = new My_DBEntities();
            //var listSales = dbCtx.SalesPersons.ToList();

            var record = dbCtx.SalesPersons
                                .Where(s => s.Name == sname).ToList();
            if (record.Count == 0)
            {
                throw new InvalidSalesPersonNameException("Salesperson does not exist!");
            }
            else
            {
                return true;
            }


        }
        public bool isValidCustName(string cname)

        { 
                var dbCtx = new My_DBEntities();
                var listCust = dbCtx.Customers.ToList();

                var record = listCust.Where(c => c.Name == cname).ToList();
            if (record.Count == 0)
            {
                throw new InvalidCustomerNameException("Customer does not exist!");
                
            }
            return true;
            
        }

        public int GetCustId(string name)
        {
            var dbCtx = new My_DBEntities();
            var nm = dbCtx.Customers.ToList();

            var rec = nm.Where(i => i.Name == name).Select(e => e.ID).FirstOrDefault();
            
            return rec;
        }
        
        public int GetSalId(string name)
        {
            var dbCtx = new My_DBEntities();
            var nm = dbCtx.SalesPersons.ToList();

            var rec = nm.Where(i => i.Name == name).Select(e => e.ID).FirstOrDefault();
            return rec;
        }

    }
}
