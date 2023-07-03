using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesOrderExceptions
{
    class InvalidSalesPersonNameException : ApplicationException
    {
        public InvalidSalesPersonNameException(string msg) : base(msg)
        {

        }
    }
    class InvalidCustomerNameException : ApplicationException
    {
        public InvalidCustomerNameException(string msg) : base(msg)
        {

        }
    }
    class NoOrdersFoundException : ApplicationException
    {
        public NoOrdersFoundException(string msg) : base(msg)
        {

        }
    }

    class IsValidDateFormatException : ApplicationException
    {
        public IsValidDateFormatException(String msg) : base(msg)
        {

        }
    }
    
    class IsValidDateException : ApplicationException
    {
        public IsValidDateException(String msg) : base(msg)
        {

        }
    }
}