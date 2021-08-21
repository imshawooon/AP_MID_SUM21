using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerSellerRepo
    {
        static ANTSEntities context;
        static ManagerSellerRepo()
        {
            context = new ANTSEntities();
        }

        public static List<User> GetAllSellers()
        {
            //return context.Packages.ToList();
            //  var id = Convert.ToInt32(Session["id"].ToString());
            // var list = (from p in context.Users
            //             where p.userid == id
            //            select p).ToList();
            // return list;
            return ContextClass.context.Users.ToList();
        }
        public static List<User> GetAllSellers(int id)
        {
            //return context.Packages.ToList();
            //  var id = Convert.ToInt32(Session["id"].ToString());
            var list = (from p in context.Users
                        where p.userid == id
                        select p).ToList();
            return list;
        }
        public static void AddSeller(int id, User d)
        {
            d.createdat = DateTime.Now;
            d.usertype = "Seller";
            
            context.Users.Add(d);
            context.SaveChanges();
        }

        public static List<User> GetSeller(int id)
        {
            return context.Users.Where(e => e.userid == id).ToList();
        }

        public static void EditSeller(int id, User d)
        {
            var oldp = context.Users.FirstOrDefault(e => e.userid == id);
            oldp.name = d.name;
            oldp.status = d.status;
            oldp.email = d.email;
            oldp.password = d.password;
            oldp.image = d.image;
            oldp.phone = d.phone;
            context.SaveChanges();
        }
        public static void DeleteSeller(int id)
        {
            var pr = context.Users.FirstOrDefault(e => e.userid == id);
            context.Users.Remove(pr);
            context.SaveChanges();
        }
        public static List<User> GetSearchSeller(string search, int id)
        {
            var list = (from p in context.Users
                        where p.name.Contains(search)
                        where p.userid == id
                        select p).ToList();
            return list;
        }
    }
}
