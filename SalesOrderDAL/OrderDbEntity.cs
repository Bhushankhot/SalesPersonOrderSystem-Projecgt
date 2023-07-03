using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SalesOrderDAL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.cust_id);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.SalesPerson)
                .HasForeignKey(e => e.salesperson_id);
        }
    }
}
