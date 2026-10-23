using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_88_EF01
{
    public class DbContextApp : DbContext
    {
        //public DbContextApp():base()
        //{

        //}
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=G_NET_88_EF01;Integrated Security=True;TrustServerCertificate=true;");
        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
