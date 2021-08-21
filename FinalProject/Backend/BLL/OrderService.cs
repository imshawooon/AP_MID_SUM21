using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetOrderList()
        {
            var orders = OrderRepo.GetOrder();
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);


            return data;
        }
        public static List<OrderModel> GetSearchOrder(string search)
        {
            var searchPackage = OrderRepo.GetSearchOrder(search);
            return AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(searchPackage);
        }
        public static void EditStatus(int id, string status)
        {
            //var data = AutoMapper.Mapper.Map<OrderModel, Order>(id);
            //var d = new Department() { Id = dept.Id, Name = dept.Name };
            OrderRepo.EditStatus(id, status);
        }
        public static List<OrderModel> GetAllOrders(int id)
        {
            var orders = OrderRepo.GetAllOrders(id);
            var data = AutoMapper.Mapper.Map<List<Order>, List<OrderModel>>(orders);
            return data;
        }


        public static OrderModel GetOrders(int id)
        {
            var order = OrderRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<Order, OrderModel>(order);
        }
    }
}
