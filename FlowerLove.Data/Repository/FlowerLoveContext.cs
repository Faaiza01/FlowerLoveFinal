using FlowerLove.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerLove.Data.Repository
{
    public class FlowerLoveContext : DbContext
    {
        public FlowerLoveContext() : base("FlowerLoveContext")
        {
            Database.SetInitializer(new FlowerLoveInitialiser());
        }
        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblCategory> tblCategories { get; set; }
        public DbSet<tblProduct> tblProducts { get; set; }
        public DbSet<tblInvoice> tblInvoices { get; set; }
        public DbSet<tblOrder> tblOrders { get; set; }
        public DbSet<getallorder> getallorders { get; set; }
        public DbSet<user_invoices> user_invoices { get; set; }
        public DbSet<vw_getallproducts> vw_getallproducts { get; set; }


    }
}
