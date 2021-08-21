using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class PackageService
    {
        public static List<PackageModel> GetProductList()
        {
            var products = PackageRepo.GetProducts();
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(products);


            return data;
        }

        public static void AddProduct(PackageModel prdct)
        {
            var data = AutoMapper.Mapper.Map<PackageModel, Package>(prdct);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            PackageRepo.AddProduct(data);
        }

        public static List<PackageModel> GetPackage(int id)
        {
            var productOrders = PackageRepo.GetPackage(id);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(productOrders);
        }

        public static void EditPackage(int id, PackageModel pckage)
        {
            var data = AutoMapper.Mapper.Map<PackageModel, Package>(pckage);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            PackageRepo.EditPackage(id, data);
        }
        public static void DeletePackage(int id)
        {
            //var data = AutoMapper.Mapper.Map<PackageModel, Package>(pckage);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            PackageRepo.DeletePackage(id);
        }

        public static List<PackageModel> GetSearchPackage(string search)
        {
            var searchPackage = PackageRepo.GetSearchPackage(search);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(searchPackage);
        }
    }
}
