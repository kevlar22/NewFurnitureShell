using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class User
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        //[Display(Name = "Created Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime CreatedDate { get; set; }

        public ICollection<address> addresses { get; set; }
        public ICollection<itemsForSale> itemsForSales { get; set; }
        public ICollection<itemNeedRequests> itemNeedRequests { get; set; }
    }
}