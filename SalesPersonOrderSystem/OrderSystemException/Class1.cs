using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderSystemException
{
    public class InvalidSalesPersonNameException : ApplicationException
    {
        public InvalidSalesPersonNameException(string msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }
    public class InvalidCustomerNameException : ApplicationException
    {
        public InvalidCustomerNameException(string msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }
    public class NoOrdersFoundException : ApplicationException
    {
        public NoOrdersFoundException(string msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }

    public class IsValidDateFormatException : ApplicationException
    {
        public IsValidDateFormatException(String msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }

    public class IsValidDateException : ApplicationException
    {
        public IsValidDateException(String msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }
    
    public class AmountGreaterThanZero : ApplicationException
    {
        public AmountGreaterThanZero(String msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }
    public class DataNotInserted : ApplicationException
    {
        public DataNotInserted(String msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }
    public class NoOrdersFound : ApplicationException
    {
        public NoOrdersFound(String msg) : base(msg)
        {
            Exception ex = new Exception(msg);
            ErrorLogger.LogError(ex);
        }
    }


    public class ErrorLogger

    {

        public static void LogError(Exception ex)

        {

            //log the error in a tezt file

            string filename = @"C:\Users\Rahul.surve\source\repos\PROJECT_SALES\SalesPersonOrderSystem\ErrorFile.txt";

            string str = "\n==========================================";

            str += "\nError Description:" + ex.Message;

            str += "\nDate an Time:" + DateTime.Now.ToString();

            if (File.Exists(filename))

            {

                File.AppendAllText(filename, str);

            }

            else

            {

                File.Create(filename);

                File.AppendAllText(filename, str);

            }

        }
    }
    }
