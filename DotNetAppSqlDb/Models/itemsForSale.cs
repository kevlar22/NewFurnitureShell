using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class itemsForSale
    {
        [Key]
        public int itemID { get; set; }
        public int userID { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string category { get; set; }
    }
}