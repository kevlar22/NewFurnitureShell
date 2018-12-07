using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class MyDatabaseContext : DbContext
    {
    
        public MyDatabaseContext() : base("name=MyDbConnection")
        {
        }
      
        public DbSet<User> Users { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<itemsForSale> ITEMS_FOR_SALEs { get; set; }
        public DbSet<itemNeedRequests> itemNeedRequests { get; set; }
        public DbSet<Matches> Matches { get; set; }
       
       


       // public System.Data.Entity.DbSet<DotNetAppSqlDb.Models.MatchBuyertoSellers_Result> MatchBuyertoSellers_Result { get; set; }
    }
}
