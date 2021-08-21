using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class SellerPackageService
    {
        public static List<PackageModel> GetAllPackages(int id)
        {
            var products = SellerPackageRepo.GetAllPackages(id);
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(products);


            return data;
        }

        public static void AddProduct(int id,PackageModel prdct)
        {
            var data = AutoMapper.Mapper.Map<PackageModel, Package>(prdct);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            SellerPackageRepo.AddProduct(id,data);
        }

        public static List<PackageModel> GetPackage(int id)
        {
            var productOrders = SellerPackageRepo.GetPackage(id);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(productOrders);
        }

        public static void EditPackage(int id, PackageModel pckage)
        {
            var data = AutoMapper.Mapper.Map<PackageModel, Package>(pckage);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            SellerPackageRepo.EditPackage(id, data);
        }
        public static void DeletePackage(int id)
        {
            //var data = AutoMapper.Mapper.Map<PackageModel, Package>(pckage);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            SellerPackageRepo.DeletePackage(id);
        }

        public static List<PackageModel> GetSearchPackage(string search,int id)
        {
            var searchPackage = SellerPackageRepo.GetSearchPackage(search,id);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(searchPackage);
        }
    }
}
