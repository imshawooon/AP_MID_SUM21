using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepo
    {
        static ANTSEntities context;
        static CustomerRepo()
        {
            context = new ANTSEntities();
        }

        //Get All customers
        public static List<User> GetCustomers()
        {
            var data = context.Users.Where(e => e.usertype == "Customer");
            return data.ToList();
        }

        //Get customer details
        public static object GetCustomerDetails(int id)
        {
            return context.Users.FirstOrDefault(e => e.userid == id); 
        }

        //Edit Customer
        public static void EditUser(User cr, int id)
        {
            var oldp = context.Users.FirstOrDefault(e => e.userid == id);
            oldp.name = cr.name;
            oldp.password = cr.password;
            oldp.email = cr.email;
            oldp.phone = cr.phone;
            context.SaveChanges();
        }

        //Get all packages
        public static List<Package> GetPackages()
        {
            var data = context.Packages;
            return data.ToList();
        }

        public static Package GetPackage(int id)
        {
            return context.Packages.FirstOrDefault(e => e.packageid == id);
        }

        public static List<Package> GetSearchPackage(string search)
        {
            var list = (from p in context.Packages
                        where p.packagename.Contains(search)
                        select p).ToList();
            return list;
        }

        //Get All notices
        /*
        public static List<Notice> GetNotices()
        {
             return context.Notices.ToList();
        }
       
        public static List<Notice> GetSearchNotice(string search)
        {
            var list = (from n in context.Notices
                        where n.notice1.Contains(search)
                        select n).ToList();
            return list;
        }
         */
        //Get all blogs
        public static object GetBlogs(int id)
        {
            return context.Blogs.Where(e => e.userid == id).ToList();
        }

        public static void AddBlogs(int id,Blog b)
        {
            b.userid = id;
            context.Blogs.Add(b);
            context.SaveChanges();
        }

        public static List<Blog> GetBlog(int id)
        {
            return context.Blogs.Where(e => e.blogid == id).ToList();
        }

        public static void EditBlog(int id, Blog b)
        {
            var blog = context.Blogs.FirstOrDefault(e => e.blogid == id);
            blog.blog1 = b.blog1;
            context.SaveChanges();
        }

        public static void DeleteBlogs(int id)
        {
            var data = context.Blogs.FirstOrDefault(e => e.blogid == id);
            context.Blogs.Remove(data);
            context.SaveChanges();
        }

        //Get orders
        public static List<Order> GetAllOrders(int id)
        {
            return context.Orders.Where(e => e.customerid == id).ToList();
        }

        public static List<Order> GetSearchOrder(string search, int id)
        {
            var list = (from p in context.Orders
                        where p.ordername.Contains(search)
                        where p.customerid == id
                        select p).ToList();
            return list;
        }
        public static Order GetOrders(int id)
        {
            return context.Orders.FirstOrDefault(e => e.orderid == id);
        }

        public static void AddOrder(int id, int packid, Order o)
        {
            var pk = context.Packages.FirstOrDefault(e => e.packageid == packid);
            var user = context.Users.FirstOrDefault(e => e.userid == id);
            o.createdat = DateTime.Now;
            o.customerid = id;
            o.customerphone = user.phone;
            o.status = "unsold";
            o.sellerid = pk.userid;
            o.ordername = pk.packagename;
            o.totalprice = pk.price * o.quantity;
            context.Orders.Add(o);
            context.SaveChanges();
        }

       
        public static void CancelOrder( int orderid)
        {
            var data = context.Orders.FirstOrDefault(e => e.orderid == orderid);
            data.status = "cancelled";
            context.SaveChanges();
        }
    }
}
