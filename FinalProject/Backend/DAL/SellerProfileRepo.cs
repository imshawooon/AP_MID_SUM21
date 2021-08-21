using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class SellerProfileRepo
    {
        static ANTSEntities context;
        static SellerProfileRepo()
        {
            context = new ANTSEntities();
        }
        public static void EditUser(User d,int id)
        {
            //have to use session
            var oldp = context.Users.FirstOrDefault(e => e.userid == id);
            oldp.name = d.name;
            oldp.password = d.password;
            oldp.email = d.email;
            oldp.phone = d.phone;
            context.SaveChanges();
        }
        public static Array[] GetDashboard(int id)
        {
            Array[] dash;
            var price = (from p in context.Orders
                         where p.sellerid == id
                         where p.status == "accepted"
                         select (p.totalprice));

            if (price != null)
            {
                var sum = Convert.ToInt32(price.Sum());
                dash = new Array[sum];
                return dash;
            }
            else
            {
                var sumj = 0;
                dash = new Array[sumj];
                return dash;
            }
        }
    }
}
