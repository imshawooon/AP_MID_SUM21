using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerPackageRepo
    {
        static ANTSEntities context;
        static ManagerPackageRepo()
        {
            context = new ANTSEntities();
        }

        public static List<Package> GetAllPackages()
        {
            //return context.Packages.ToList();
            //  var id = Convert.ToInt32(Session["id"].ToString());
            //var list = (from p in context.Packages
            //            where p.userid == id
            //            select p).ToList();
            //return list;
            return ContextClass.context.Packages.ToList();
        }
        public static List<Package> GetAllPackages(int id)
        {
            //return context.Packages.ToList();
            //  var id = Convert.ToInt32(Session["id"].ToString());
            var list = (from p in context.Packages
                        where p.userid == id
                        select p).ToList();
            return list;
        }
        
        public static List<Package> GetPackage(int id)
        {
            return context.Packages.Where(e => e.packageid == id).ToList();
        }

       
        
        public static List<Package> GetSearchPackage(string search, int id)
        {
            var list = (from p in context.Packages
                        where p.packagename.Contains(search)
                        where p.userid == id
                        select p).ToList();
            return list;
        }
    }
}
