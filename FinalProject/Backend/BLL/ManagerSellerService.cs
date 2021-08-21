using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class ManagerSellerService
    {
        public static List<UserModel> GetAllSellers()
        {
            var sellers = ManagerSellerRepo.GetAllSellers();
            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(sellers);


            return data;
        }
        public static List<UserModel> GetAllSellers(int id)
        {
            var sellers = ManagerSellerRepo.GetAllSellers(id);
            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(sellers);


            return data;
        }

        public static void AddSeller(int id, UserModel sell)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(sell);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            ManagerSellerRepo.AddSeller(id, data);
        }

        public static List<UserModel> GetSeller(int id)
        {
            var productOrders = ManagerSellerRepo.GetSeller(id);
            return AutoMapper.Mapper.Map<List<User>, List<UserModel>>(productOrders);
        }

        public static void EditSeller(int id, UserModel selle)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(selle);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            ManagerSellerRepo.EditSeller(id, data);
        }
        public static void DeleteSeller(int id)
        {
            //var data = AutoMapper.Mapper.Map<PackageModel, Package>(pckage);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            ManagerSellerRepo.DeleteSeller(id);
        }

        public static List<UserModel> GetSearchSeller(string search, int id)
        {
            var searchSeller = ManagerSellerRepo.GetSearchSeller(search, id);
            return AutoMapper.Mapper.Map<List<User>, List<UserModel>>(searchSeller);
        }
    }
}
