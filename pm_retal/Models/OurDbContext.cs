using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace pm_retal.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
        public DbSet<Skills> skills { get; set; }
        public DbSet<Projects>  projects { get; set; }
        public DbSet<ASTPM> Astpm { get; set; }

        
    }
}