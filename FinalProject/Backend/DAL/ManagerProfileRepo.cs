using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerProfileRepo
    {
        static ANTSEntities context;
        static ManagerProfileRepo()
        {
            context = new ANTSEntities();
        }
        public static void EditUser(User d, int id)
        {
            //have to use session
            var oldp = context.Users.FirstOrDefault(e => e.userid == id);
            oldp.name = d.name;
            oldp.password = d.password;
            oldp.email = d.email;
            oldp.phone = d.phone;
            context.SaveChanges();
        }
        
    }
}
