using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ANTSBackend.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/Customer/GetAll")]
        [HttpGet]
        public List<UserModel> GetAllCustomers()
        {
            return CustomerService.GetCustomers();
        }

        [Route("api/Customer/{id}/Details")]
        public CustomerDetails GetCustomerDetails(int id)
        {
            return CustomerService.GetCustomerDetails(id);
        }

        [Route("api/Customer/edit/{id}")]
        [HttpPost]
        public void Edit(UserModel user, int id)
        {
            CustomerService.EditUser(user, id);
        }

        [Route("api/Packages/GetAll")]
        [HttpGet]
        public List<PackageModel> GetPackages()
        {
            return CustomerService.GetPackages();
        }

        [Route("api/Package/{id}")]
        [HttpGet]
        public PackageModel GetPackage(int id)
        {
            return CustomerService.GetPackage(id);
        }

        [Route("api/Customer/Package/{search}")]
        [HttpGet]
        public List<PackageModel> GetSearchPackage(string search)
        {
            return CustomerService.GetSearchPackage(search);
        }

        /*
        [Route("api/Notices/GetAll")]
        [HttpGet]
        public List<NoticeModel> GetNotices()
        {
            return CustomerService.GetNotices();
        }
        
        [Route("api/Customer/Notices/{search}")]
        [HttpGet]
        public List<NoticeModel> GetSearchNotice(string search)
        {
            return CustomerService.GetSearchNotice(search);
        }
        */
        [Route("api/Blogs/{id}/GetAll")]
        [HttpGet]
        public List<BlogsModel> GetBlogs(int id)
        {
            return CustomerService.GetBlogs(id);
        }
        [Route("api/Blogs/add/{id}")]
        [HttpPost]

        public void AddBlogs(int id,BlogsModel blogs)
        {
            CustomerService.AddBlogs(id, blogs);
        }

        //Edit Blog
        [Route("api/Blog/edit/{id}")]
        [HttpGet]
        public List<BlogsModel> GetBlog(int id)
        {
            return CustomerService.GetBlog(id);
        }
        [Route("api/Blog/edit/{id}")]
        [HttpPost]
        public void EditBlog(int id, BlogsModel blogs)
        {
            CustomerService.EditBlog(id,blogs);
        }

        [Route("api/Blogs/delete/{id}")]
        [HttpPost]
        public void DeleteBlog(int id)
        {
            CustomerService.DeleteBlogs(id);
        }
       
    }
}
