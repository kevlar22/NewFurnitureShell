﻿using System;
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
        public DbSet<address> addresses { get; set; }
        public DbSet<itemsForSale> itemsForSales { get; set; }
        public DbSet<itemNeedRequests> itemNeedRequests { get; set; }

        public System.Data.Entity.DbSet<DotNetAppSqlDb.Models.MatchBuyertoSellers_Result> MatchBuyertoSellers_Result { get; set; }
    }
}
