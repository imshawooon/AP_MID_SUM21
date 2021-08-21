using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerService
    {
        //Get All Customer List
        public static List<UserModel> GetCustomers()
        {
            var customers = CustomerRepo.GetCustomers();
            var data = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(customers);
            return data;
        }

        //Get Customer Details
        public static CustomerDetails GetCustomerDetails(int id)
        {
            var c = CustomerRepo.GetCustomerDetails(id);
            var customerdetails = AutoMapper.Mapper.Map<User, CustomerDetails>((User)c);
            return customerdetails;
        }

        //Edit Customer Profile
        public static void EditUser(UserModel user, int id)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(user);
            CustomerRepo.EditUser(data, id);
        }

        //Get Package Details
        public static List<PackageModel> GetPackages()
        {
            var packages = CustomerRepo.GetPackages();
            var data = AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(packages);
            return data;
        }

        public static PackageModel GetPackage(int id)
        {
            var packages = CustomerRepo.GetPackage(id);
            var data = AutoMapper.Mapper.Map<Package, PackageModel>(packages);
            return data;
        }

        public static List<PackageModel> GetSearchPackage(string search)
        {
            var packageSearch = CustomerRepo.GetSearchPackage(search);
            return AutoMapper.Mapper.Map<List<Package>, List<PackageModel>>(packageSearch);
        }



        //Get All Notices
        /*
        public static List<NoticeModel> GetNotices()
        {
            var notices = CustomerRepo.GetNotices();
            return AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(notices);
        }
        
        public static List<NoticeModel> GetSearchNotice(string search)
        {
            var noticeSearch = CustomerRepo.GetSearchNotice(search);
            return AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(noticeSearch);
        }
        */
        //Get All Blogs
        public static List<BlogsModel> GetBlogs(int id)
        {
            var blogs = CustomerRepo.GetBlogs(id);
            var data = AutoMapper.Mapper.Map<List<Blog>, List<BlogsModel>>((List<Blog>)blogs);
            return data; ;
        }

        public static void AddBlogs(int id, BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
             CustomerRepo.AddBlogs(id,b);
          
        }

        
        public static List<BlogsModel> GetBlog(int id)
        {
            var b = CustomerRepo.GetBlog(id);
            return AutoMapper.Mapper.Map<List<Blog>, List<BlogsModel>>(b);
        }

        public static void EditBlog(int id, BlogsModel blogs)
        {
            var b = AutoMapper.Mapper.Map<BlogsModel, Blog>(blogs);
            CustomerRepo.EditBlog(id, b);

        }
        public static void DeleteBlogs(int id)
        {
            CustomerRepo.DeleteBlogs(id);
        }
      
        //Get Order data
        public static List<OrderModel> GetAllOrders(int id)
        {
            var orders = CustomerRepo.GetAllOrders(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }

        public static List<OrderModel> GetSearchOrder(string search, int id)
        {
            var orderSearch = CustomerRepo.GetSearchOrder(search, id);
            return AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orderSearch);
        }

        public static OrderModel GetOrders(int id)
        {
            var order = CustomerRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }

        public static void AddOrder(int id, int packid, OrderModel order)
        {
            var data = AutoMapper.Mapper.Map<OrderModel, Order>(order);
            CustomerRepo.AddOrder(id, packid, data);
        }

        public static void CancelOrder( int orderid)
        {
            CustomerRepo.CancelOrder( orderid);
        }
      
    }
}
