using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class Matches
    {
        [Key]
        public int matchID { get; set; }
        [DisplayName("Seller Name")]
        public string sellerName { get; set; }
        [DisplayName("Item for Sale")]
        public string itemForSaleName { get; set; }
        [DisplayName("Price")]
        public int salePrice { get; set; }
        [DisplayName("Category")]
        public string sellingCategory { get; set; }
        [DisplayName("Image")]
        public string image { get; set; }
        public int buyerID { get; set; }
        public int requestID { get; set; }
        public int sellerID { get; set; }
        public int itemID { get; set; }
        public int zip { get; set; }
    }
}