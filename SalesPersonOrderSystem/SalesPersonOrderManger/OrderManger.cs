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
            string dateFormat = "MM/dd/yyyy";

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
            string curDate = DateTime.Now.ToString("MM/dd/yyyy");
            DateTime date1 = DateTime.Parse(curDate);
            DateTime date2 = DateTime.Parse(Order_date);
            /*Console.WriteLine(date1);
            Console.WriteLine(date2);*/
            if (date2 < date1)
            {
                //Console.WriteLine("Date is valid");
            }
            else
            {
                //-----------------New
                throw new IsValidDateFormatException("Order date must be lesser than current date.");
            }

            // amt greater than zero
            
            if (Amt > 0)
            {
                //Console.WriteLine("Amount is Valid");
            }
            else
            {
                throw new AmountGreaterThanZero("Invalid Amount, must be greater than zero!");
            }

            // check valid customer name

            try
            {
               dal.isValidCustName(CName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);   
            }
            /*if (dal.isValidCustName(CName))
            {
                // Console.WriteLine("Valid Sname");
            }
            else
            {
                throw new InvalidCustomerNameException("Invalid Customer name!");
            }*/

            try
            {
                dal.isValidSaleName(SName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            // check valid sales name
            /*if (dal.isValidSaleName(SName))
            {
               // Console.WriteLine("Valid Sname");
            }
            else
            {
                throw new InvalidSalesPersonNameException("Invalid salesperson name!");
            }*/

            
            
            //Order newOrderData = new Order();
            Order newOrderData = new Order();
            SalesOrderCRUD so = new SalesOrderCRUD();
            newOrderData.order_date = Convert.ToDateTime(Order_date);
            newOrderData.Amount = Amt;
            newOrderData.cust_id = so.GetCustId(CName);
            newOrderData.salesperson_id = so.GetSalId(SName);
            //dal.AddOrderToDB(newOrderData);
            dal.AddOrderToDB(newOrderData);

            


        }

       
        public void DisplayOrder(string sname)
        {

            SalesOrderCRUD dal = new SalesOrderCRUD();
            try
            {
                dal.isValidSaleName(sname);
            }
            catch (InvalidSalesPersonNameException s)
            {
                Console.WriteLine(s.Message);
                
            }
            try
            {
                
                var res = dal.DisplayOrdersFromDB(sname).ToList();
                if(res.Count == 0)
                {
                    throw new NoOrdersFound("No orders found for this person");
                }
                Console.WriteLine("\tOrder Id\tAmount\tDate\t\t\tSalesPerson Id\tCustomer Id");
                foreach (var item in res)
                {
                    Console.WriteLine($"\t{item.Order_id}\t\t{item.Amount}\t{item.order_date}\t{item.salesperson_id}\t\t{item.cust_id}");
                }
            }
            catch (Exception e)
            {
                throw new NoOrdersFound("No orders found for this person");

            }
            

            

        }

    }
}