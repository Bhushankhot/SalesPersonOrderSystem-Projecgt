using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderEntities;
using SalesPersonOrderManger;

namespace SalesPersonOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(" ********* Welcome to CURD App by Team-H ********* ");

            int ch;

            do
            {
                OrderManger ordb = new OrderManger();
                Console.WriteLine("\n1.Add Order ");
                Console.WriteLine("2.Display Order ");
                Console.WriteLine("3.Exit ");
                Console.WriteLine("Enter your choice : ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1://To Add Details in Orders table

                        Console.WriteLine("Enter Order Date (dd-mm-yyyy) : ");
                        string Order_date = Console.ReadLine();
                        Console.WriteLine("Enter Order Amount : ");
                        int Amount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Customer Name : ");
                        string CName = Console.ReadLine();
                        Console.WriteLine("Enter Sales Person Name : ");
                        string SName= Console.ReadLine();
                        ordb.AddOrder(Order_date,Amount,CName,SName);
                        Console.WriteLine("Record Inserted .... ");
                        break;
                    case 2:// To Display Details based on SalesPerson Name
                        Console.WriteLine("Enter Sales Person Name : ");
                        string SName1 = Console.ReadLine();
                        ordb.DisplayOrder(SName1);
                        break;
                    case 3://Exit
                        Console.WriteLine("Thank you for using :) ");
                        ch = 3;
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice !!!");
                        break;
                }
            } while (ch != 3);

        }
    }
}
