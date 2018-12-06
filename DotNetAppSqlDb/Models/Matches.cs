using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class Matches
    {
        [Key]
        public int matchID { get; set; }  
        public string sellerName { get; set; }
        public string itemForSaleName { get; set; }
        public int salePrice { get; set; }
        public string sellingCategory { get; set; }
        public string image { get; set; }
        public int buyerID { get; set; }
        public int requestID { get; set; }
        public int sellerID { get; set; }
        public int itemID { get; set; }
    }
}