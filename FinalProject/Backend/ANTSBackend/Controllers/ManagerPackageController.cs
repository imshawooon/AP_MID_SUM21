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
    public class ManagerPackageController : ApiController
    {
        [Route("api/MPackage/GetAll")]
        [HttpGet]
        public List<PackageModel> GetAllPackages()
        {
            return ManagerPackageService.GetAllPackages();
        }

        [Route("api/MPackage/GetAll/{id}")]
        [HttpGet]
        public List<PackageModel> GetAllPackages(int id)
        {
            return ManagerPackageService.GetAllPackages(id);
        }

        [Route("api/MPackage/Search/{search}/{id}")]
        [HttpGet]
        public List<PackageModel> GetSearchPackage(string search, int id)
        {
            return ManagerPackageService.GetSearchPackage(search, id);
        }
    }
}
