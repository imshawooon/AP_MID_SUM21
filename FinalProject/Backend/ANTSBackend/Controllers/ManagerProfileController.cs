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
    public class ManagerProfileController : ApiController
    {
        [Route("api/Manager/edit/{id}")]
        [HttpPost]
        public void Edit(UserModel usr, int id)
        {
            ManagerProfileService.EditUser(usr, id);
        }

       
    }
}
