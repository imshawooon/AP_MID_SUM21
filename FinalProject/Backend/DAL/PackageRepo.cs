using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PackageRepo
    {
        static ANTSEntities context;
        static PackageRepo()
        {
            context = new ANTSEntities();
        }

        public static List<Package> GetProducts()
        {
            //return context.Packages.ToList();
            //  var id = Convert.ToInt32(Session["id"].ToString());
            var list = (from p in context.Packages
                        where p.userid == 8
                        select p).ToList();
            return list;
        }
        public static void AddProduct(Package d)
        {
            d.createdat = DateTime.Now;
            d.approvestatus = "pending";
            d.userid = 8;
            context.Packages.Add(d);
            context.SaveChanges();
        }

        public static List<Package> GetPackage(int id)
        {
            return context.Packages.Where(e => e.packageid == id).ToList();
        }

        public static void EditPackage(int id, Package d)
        {
            var oldp = context.Packages.FirstOrDefault(e => e.packageid == id);
            oldp.packagename = d.packagename;
            oldp.price = d.price;
            oldp.category = d.category;
            oldp.discount = d.discount;
            oldp.details = d.details;
            oldp.location = d.location;
            oldp.advertisement = d.advertisement;
            context.SaveChanges();
        }
        public static void DeletePackage(int id)
        {
            var pr = context.Packages.FirstOrDefault(e => e.packageid == id);
            context.Packages.Remove(pr);
            context.SaveChanges();
        }
        public static List<Package> GetSearchPackage(string search)
        {
            var list = (from p in context.Packages
                        where p.packagename.Contains(search)
                        select p).ToList();
            return list;
        }
    }
}