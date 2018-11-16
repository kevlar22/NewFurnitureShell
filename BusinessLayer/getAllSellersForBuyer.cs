using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class getAllSellersForBuyer(int buyerID,int zip)
    {
        public IEnumerable<sellerMatches> Sellers
        {
            get
            {
                string userName = user.userName;
                string l = null;
                string sql = "SELECT userName FROM Users WHERE userName = @userName";
            }

        }
        

        
    }
            using (SqlConnection conn = new SqlConnection("Data Source=uncc.database.windows.net;Initial Catalog=Moving_App;Persist Security Info=True;User ID=kparso12;Password=Sugarrush1"))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
    cmd.Parameters.AddWithValue("@userName", userName)
    }
}
