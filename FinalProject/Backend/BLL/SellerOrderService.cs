using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class SellerOrderService
    {
        public static List<OrderModel> GetOrderList(int id)
        {
            var orders = SellerOrderRepo.GetOrder(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);


            return data;
        }
        public static List<OrderModel> GetSearchOrder(string search,int id)
        {
            var searchPackage = SellerOrderRepo.GetSearchOrder(search,id);
            return AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(searchPackage);
        }
        public static void EditStatus(int id, string status)
        {
            //var data = AutoMapper.Mapper.Map<OrderModel, Order>(id);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            SellerOrderRepo.EditStatus(id, status);
        }
        public static List<OrderModel> GetAllOrders(int id)
        {
            var orders = SellerOrderRepo.GetAllOrders(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }

        public static List<OrderModel> GetFullOrders()
        {
            var orders = SellerOrderRepo.GetFullOrders();
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }


        public static OrderModel GetOrders(int id)
        {
            var order = SellerOrderRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }
    }
}
