using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        //static ANTSEntities ContextClass.context;
        //static UserRepo()
        //{
        //    ContextClass.context = new ANTSEntities();
        //}

        public static List<User> GetAllUsers()
        {
            return ContextClass.context.Users.ToList();
        }

        public static List<User> GetSearchUsers(string search)
        {
            var list = (from p in ContextClass.context.Users
                        where p.name.Contains(search)
                        select p).ToList();
            return list;
        }

        public static User GetUser(int id)
        {
            return ContextClass.context.Users.FirstOrDefault(e => e.userid == id);
        }

        public static User AddUser(User u)
        {
            ContextClass.context.Users.Add(u);
            ContextClass.context.SaveChanges();
            return u;
        }

        public static User EditUser(User u)
        {
            var user = ContextClass.context.Users.FirstOrDefault(e => e.userid == u.userid);
            ContextClass.context.Entry(user).CurrentValues.SetValues(u);
            ContextClass.context.SaveChanges();
            return user;
        }

        public static User DeleteUser(int id)
        {
            var user = ContextClass.context.Users.FirstOrDefault(e => e.userid == id);
            ContextClass.context.Users.Remove(user);
            ContextClass.context.SaveChanges();
            return user;
        }
        public static User GetUserLogin(string mail, string pass)
        {
            var usercheck = ContextClass.context.Users.FirstOrDefault(e => e.email == mail && e.password == pass);
            if (usercheck != null)
            {
                return usercheck;
            }
            return null;
        }
    }
}
