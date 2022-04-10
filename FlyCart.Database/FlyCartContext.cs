using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyCart.Entities;


namespace FlyCart.Database
{
    public class FlyCartContext : DbContext
    {
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Order>  Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionGroup>  OptionGroups { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }

        public FlyCartContext() : base("FlyCartConnection")
        {
            
        }

    }
}
