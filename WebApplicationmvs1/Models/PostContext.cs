using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class PostContext : DbContext
    {
        public DbSet<PostText> PostTexts { get; set; }
        public DbSet<Consult> Consults { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<OrderServis> OrderServises { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }


    }

    // public class 
    //public static void SetInitializer<TContext>(System.Data.Entity.IDatabaseInitializer<TContext> strategy) where TContext : System.Data.Entity.DbContext;

}