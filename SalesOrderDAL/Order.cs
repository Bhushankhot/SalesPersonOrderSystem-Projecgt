namespace SalesOrderDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int Order_id { get; set; }

        public DateTime order_date { get; set; }

        public int Amount { get; set; }

        public int? cust_id { get; set; }

        public int? salesperson_id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual SalesPerson SalesPerson { get; set; }
    }
}
