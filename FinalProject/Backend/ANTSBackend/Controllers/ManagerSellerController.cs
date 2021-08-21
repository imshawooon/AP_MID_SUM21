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
    public class ManagerSellerController : ApiController
    {
        [Route("api/Seller/GetAll")]
        [HttpGet]
        public List<UserModel> GetAllSellers()
        {
            return ManagerSellerService.GetAllSellers();
        }
        [Route("api/Seller/GetAll/{id}")]
        [HttpGet]
        public List<UserModel> GetAllSellers(int id)
        {
            return ManagerSellerService.GetAllSellers(id);
        }

        [Route("api/Seller/Add/{id}")]
        [HttpPost]
        public void Add(int id, UserModel sell)
        {
            ManagerSellerService.AddSeller(id, sell);
        }

        [Route("api/Seller/edit/{id}")]
        [HttpGet]
        public List<UserModel> GetSeller(int id)
        {
            return ManagerSellerService.GetSeller(id);
        }
        [Route("api/Seller/edit/{id}")]
        [HttpPost]
        public void Edit(int id, UserModel sell)
        {
            ManagerSellerService.EditSeller(id, sell);
        }
        [Route("api/Seller/delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            ManagerSellerService.DeleteSeller(id);
        }

        [Route("api/Seller/Search/{search}/{id}")]
        [HttpGet]
        public List<UserModel> GetSearchSeller(string search, int id)
        {
            return ManagerSellerService.GetSearchSeller(search, id);
        }



    }
}
