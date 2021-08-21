using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BEL;

namespace ANTSBackend.Controllers
{
    public class SellerProfileController : ApiController
    {

        [Route("api/User/edit/{id}")]
        [HttpPost]
        public void Edit(UserModel usr,int id)
        {
            SellerProfileService.EditUser(usr,id);
        }

        [Route("api/Seller/Dashboard/{id}")]
        [HttpGet]
        public static Array[] Dashboard(int id)
        {
            return SellerProfileService.GetDashboard(id);
        }

    }
}
