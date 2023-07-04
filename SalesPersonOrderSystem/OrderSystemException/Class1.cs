using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemException
{
    public class InvalidSalesPersonNameException : ApplicationException
    {
        public InvalidSalesPersonNameException(string msg) : base(msg)
        {

        }
    }
    public class InvalidCustomerNameException : ApplicationException
    {
        public InvalidCustomerNameException(string msg) : base(msg)
        {

        }
    }
    public class NoOrdersFoundException : ApplicationException
    {
        public NoOrdersFoundException(string msg) : base(msg)
        {

        }
    }

    public class IsValidDateFormatException : ApplicationException
    {
        public IsValidDateFormatException(String msg) : base(msg)
        {

        }
    }

    public class IsValidDateException : ApplicationException
    {
        public IsValidDateException(String msg) : base(msg)
        {

        }
    }
    
    public class AmountGreaterThanZero : ApplicationException
    {
        public AmountGreaterThanZero(String msg) : base(msg)
        {

        }
    }
}
