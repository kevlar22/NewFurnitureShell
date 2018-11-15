using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class itemNeedRequests
    {
        [Key]
        public int requestId { get; set; }
        public int userId { get; set; }
        public string category { get; set; }
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
    }
}