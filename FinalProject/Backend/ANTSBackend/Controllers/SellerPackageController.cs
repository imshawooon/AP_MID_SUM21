using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BEL;
using BLL;

namespace ANTSBackend.Controllers
{
    public class SellerPackageController : ApiController
    {
        [Route("api/Package/GetAll/{id}")]
        [HttpGet]
        public List<PackageModel> GetAllPackages(int id)
        {
            return SellerPackageService.GetAllPackages(id);
        }

        [Route("api/Package/Add/{id}")]
        [HttpPost]
        public void Add(int id,PackageModel prdct)
        {
            SellerPackageService.AddProduct(id,prdct);
        }

        [Route("api/Package/edit/{id}")]
        [HttpGet]
        public List<PackageModel> GetPackage(int id)
        {
            return SellerPackageService.GetPackage(id);
        }
        [Route("api/Package/edit/{id}")]
        [HttpPost]
        public void Edit(int id,PackageModel prdct)
        {
            SellerPackageService.EditPackage(id,prdct);
        }
        [Route("api/Package/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            SellerPackageService.DeletePackage(id);
        }

        [Route("api/Package/Search/{search}/{id}")]
        [HttpGet]
        public List<PackageModel> GetSearchPackage(string search,int id)
        {
            return SellerPackageService.GetSearchPackage(search,id);
        }
    }
}
