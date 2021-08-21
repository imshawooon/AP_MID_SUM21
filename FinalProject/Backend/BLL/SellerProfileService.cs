using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class SellerProfileService
    {
        public static void EditUser(UserModel usr,int id)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(usr);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            SellerProfileRepo.EditUser(data,id);
        }
        public static Array[] GetDashboard(int id)
        {
            var dash = SellerProfileRepo.GetDashboard(id);
            return dash;
        }
    }
}
