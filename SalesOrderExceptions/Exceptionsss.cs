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
}
}
