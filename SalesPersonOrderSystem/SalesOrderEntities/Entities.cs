using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesOrderEntities
{


    public partial class Order
    {

        public int OrderId { get; set; }

        public DateTime Order_date { get; set; }
        public int Amt { get; set; }
        public int Cust_id { get; set; }
        public int Salesperson_id { get; set; }

    }

    public class Salesperson
    {
        public int Id { get; set; }

        public string SName { get; set; }

    }

    public class Customers
    {
        public int OrderId { get; set; }

        public string CName { get; set; }


    }



    public class Entities
    {
       
    }
}
