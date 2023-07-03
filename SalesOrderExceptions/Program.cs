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
<<<<<<<< HEAD:SalesOrderExceptions/Exceptionsss.cs
}
}
========

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
>>>>>>>> e4c103e5c0f7afffca2e7ed9aaa7d85a3f280354:SalesOrderExceptions/Program.cs
