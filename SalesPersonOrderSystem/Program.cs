using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderEntity;

namespace SalesPersonOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(" ********* Welcome to CURD App by Team-H ********* ");

            DataAccessCls dao = new DataAccessCls();
            int ch;

            do
            {
            Console.WriteLine("\n1.Add Order ");
            Console.WriteLine("2.Display Order ");
            Console.WriteLine("3.Exit ");
            Console.WriteLine("Enter your choice : ");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1://To Add Details in Orders table
                        var details = new Order();
            
                        Console.WriteLine("Enter Order Date (dd-mm-yyyy) : ");
                        string text = Console.ReadLine();
                        details.Order_date = DateTime.ParseExact(text, "dd/MM/yyyy", null);
                        Console.WriteLine("Enter Order Amount : ");
                        details.Amount=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer Id : ");
                        details.Cust_id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Sales Person Name : ");
                        details.Salesperson_id=int.Parse(Console.ReadLine());   
                        dao.AddOrder(details);
                        Console.WriteLine("Record Inserted .... ");
                    break;
                case 2:// To Display Details based on SalesPerson Name
                        var lstOrders = dao.GetOrders();
                            Console.WriteLine($"Order_id\tAmount\torder_date\tsalesperson_id\tcust_id");
                        foreach (var item in lstOrders)
                        {
                            Console.WriteLine($"\t{item.OrderId}\t{item.Amount}\t{item.Order_date}\t{item.Salesperson_id}\t{item.Cust_id}");
                        }
                    break;
                case 3://Exit
                        Console.WriteLine("Thank you for using :) ");
                        ch = 3;
                    break;
                default:
                        Console.WriteLine("Please enter valid choice !!!");
                    break;
            }
            } while (ch!=3);
        }
    }
   /* class DataAccessCls
    {
        public List<Order> GetOrders()
        {
            var dbctx = new CURDBEntities();
            var result = dbctx.Orders.ToList();
            return result;
        }
        public Order GetOrder(int id)
        {
            var dbctx = new CURDBEntities();
            var record = dbctx.Orders.Find(id);
            if (record != null)
                return record;
            else
                throw new Exception("Record Not Found....");
            dbctx.SaveChanges();
        }
        public void AddOrder(Order o)
        {
            var dbctx = new CURDBEntities();
            var rescord = dbctx.Orders.Add(o);
            dbctx.SaveChanges();
        }*/
        /* Delete any order
        public void DelOrder(int id)
        {
            var dbctx = new CURDBEntities();
            var record = dbctx.Orders.Find(id);
            dbctx.Orders.Remove(record);
            dbctx.SaveChanges();
        }
        */
    }
}
