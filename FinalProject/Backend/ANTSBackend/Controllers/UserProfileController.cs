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
    public class UserProfileController : ApiController
    {
        [Route("api/User/Get")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }

        [Route("api/User/edit")]
        [HttpPost]
        public void Edit(UserModel prdct)
        {
            UserService.EditUser(prdct);
        }

        [Route("api/Login")]
        [HttpPost]
        public UserModel Login(UserModel user)
        {
            if (user == null)
            {
                return null;
            }
            return UserService.GetUserlogin(user.email, user.password);
        }

        [Route("api/registration")]
        [HttpPost]
        public UserModel AddUser(UserModel user)
        {
            user.status = "Active";
            user.createdat = DateTime.Now;
            return UserService.AddUser(user);
        }

    }
}
