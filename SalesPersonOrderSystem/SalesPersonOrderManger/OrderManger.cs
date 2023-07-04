using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemException;
using SalesOrderDOL;

namespace SalesPersonOrderManger
{
    public class OrderManger
    {
        public OrderManger()
        {

        }

        public void AddOrder(string Order_date, int Amt, string CName,string SName)
        {

            SalesOrderCRUD dal = new SalesOrderCRUD();
            // Check date format
            string dateFormat = "dd/MM/yyyy";

            bool isValidDate = DateTime.TryParseExact(Order_date, dateFormat, null, DateTimeStyles.None, out DateTime parsedDate);
            if (isValidDate)
            {
               // Console.WriteLine("Valid")
            }
            else
            {
                throw new IsValidDateFormatException("Invalid date format!");
            }
               
            // Check valid date
            string curDate = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime date1 = DateTime.Parse(curDate);
            DateTime date2 = DateTime.Parse(Order_date);
            if (date2 < date1)
            {
                //Console.WriteLine("Date is valid");
            }
            else
            {
                throw new IsValidDateFormatException("Invalid Date!");
            }

            // amt greater than zero
            if (Amt > 0)
            {
                Console.WriteLine("Amount is Valid");
            }
            else
            {
                throw new AmountGreaterThanZero("Amount is greater than zero!");
            }

            // check valid sales name
            if (dal.isValidSaleName(SName))
            {
               // Console.WriteLine("Valid Sname");
            }
            else
            {
                throw new InvalidSalesPersonNameException("Invalid salesperson name!");
            }

            // check valid customer name
            if (dal.isValidCustName(CName))
            {
                //Console.WriteLine("Valid cname");
            }
            else
            {
                throw new InvalidCustomerNameException("Invalid customer name!"); 
            }
            //Order newOrderData = new Order();
            Order newOrderData = new Order();
            SalesOrderCRUD so = new SalesOrderCRUD();
            newOrderData.order_date=Convert.ToDateTime(Order_date);
            newOrderData.Amount=Amt;
            newOrderData.cust_id  =  so.GetCustId(CName);
            newOrderData.salesperson_id=so.GetSalId(SName);
            //dal.AddOrderToDB(newOrderData);
            dal.AddOrderToDB(newOrderData);


        }

       
        public void DisplayOrder(string sname)
        {
            SalesOrderCRUD dal = new SalesOrderCRUD();
            var res = dal.DisplayOrdersFromDB(sname);
            foreach (var item in res)
            {
                Console.WriteLine($"\t{item.Order_id}\t{item.Amount}\t{item.order_date}\t{item.salesperson_id}\t{item.cust_id}");
            }

        }

    }
}