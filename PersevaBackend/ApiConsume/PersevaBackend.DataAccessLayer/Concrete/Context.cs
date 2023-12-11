using Microsoft.EntityFrameworkCore;
using PersevaBackend.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersevaBackend.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {

        public Context(DbContextOptions<Context> options):base(options) 
        { 
        
        }


        public DbSet<Basket>Baskets { get; set; }
        public DbSet<BillingInfo>BillingInfos { get; set; }
        public DbSet<Cargo>Cargos { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Discount>Discounts { get; set; }
        public DbSet<Fulfillment>Fulfillments { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Product>Products { get; set; }
        public DbSet<Refund>Refunds { get; set; }
        public DbSet<Return>Returns { get; set; }
        public DbSet<ShopOwner>ShopOwners { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<UserAddress>UserAddresses { get; set; }



    }
}
