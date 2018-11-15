using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetAppSqlDb.Models
{
    public class address
    {
        [Key]
        public string userID { get; set; }
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string aptNum { get; set; }
    }
}