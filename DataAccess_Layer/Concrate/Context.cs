using Entity_Layer.Concrate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Concrate
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A2B47T0\\SQLEXPRESS01;database=Project_OOP;integrated security=true; TrustServerCertificate=True ");
        }

        internal static void SaveChance()
        {
            throw new NotImplementedException();
        }

        public DbSet<Customer> customers {  get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Joop> joops { get; set; }

    }
}
