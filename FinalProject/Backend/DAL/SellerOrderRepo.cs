using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SellerOrderRepo
    {
        static ANTSEntities context;
        static SellerOrderRepo()
        {
            context = new ANTSEntities();
        }

        //BLONDE CHEF
        public static List<Order> GetOrder(int id)
        {
            var list = (from p in context.Orders
                        where p.sellerid == id
                        select p).ToList();
            return list;
        }
        public static List<Order> GetSearchOrder(string search,int id)
        {
            var list = (from p in context.Orders
                        where p.ordername.Contains(search)
                        where p.sellerid == id
                        select p).ToList();
            return list;
        }
        public static void EditStatus(int id, string status)
        {
            var oldp = context.Orders.FirstOrDefault(e => e.orderid == id);
            oldp.status = status;

            context.SaveChanges();
        }

        //NUSHRAT APA
        public static List<Order> GetAllOrders(int id)
        {
            return context.Orders.Where(e => e.customerid == id).ToList();
        }

        public static List<Order> GetFullOrders()
        {
            return context.Orders.ToList();
        }

        public static Order GetOrders(int id)
        {
            return context.Orders.FirstOrDefault(e => e.orderid == id);
        }
    }
}
