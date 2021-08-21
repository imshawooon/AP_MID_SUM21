using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class ManagerPackageService
    {
        public static List<PackageModel> GetAllPackages()
        {
            var products = ManagerPackageRepo.GetAllPackages();
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(products);


            return data;
        }
        public static List<PackageModel> GetAllPackages(int id)
        {
            var products = ManagerPackageRepo.GetAllPackages(id);
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(products);


            return data;
        }

      

        public static List<PackageModel> GetPackage(int id)
        {
            var productOrders = ManagerPackageRepo.GetPackage(id);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(productOrders);
        }

        
        
        public static List<PackageModel> GetSearchPackage(string search, int id)
        {
            var searchPackage = ManagerPackageRepo.GetSearchPackage(search, id);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(searchPackage);
        }
    }
}
