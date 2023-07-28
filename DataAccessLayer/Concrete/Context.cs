using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=OKANK;initial catalog=EasyCashDB;integrated Security=true");
        }
        public DbSet<CustomerAccount> customerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> customerAccountProcesses { get; set; }



    }
}
