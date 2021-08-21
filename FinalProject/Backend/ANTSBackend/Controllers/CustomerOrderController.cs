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
    public class CustomerOrderController : ApiController
    {
        [Route("api/CustomerOrder/{id}/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders(int id)
        {
            return CustomerService.GetAllOrders(id);
        }

        [Route("api/CustomerOrder/{id}")]
        [HttpGet]
        public OrderModel GetOrders(int id)
        {
            return CustomerService.GetOrders(id);
        }

        [Route("api/CustomerOrder/Search/{search}/{id}")]
        [HttpGet]
        public List<OrderModel> GetSearchOrder(string search, int id)
        {
            return CustomerService.GetSearchOrder(search, id);
        }

        [Route("api/CustomerOrder/Add/{id}/{packid}")]
        [HttpPost]
        public void AddOrder(int id, int packid, OrderModel order)
        {
            order.createdat = DateTime.Now;
            order.customerid = id;
            order.customerphone = "123";
            order.ordername = "Name";
            order.packageid = 12;
            order.sellerid = 12;
            order.status = "unsold";
            order.totalprice = 0;
            CustomerService.AddOrder(id, packid, order);
        }


        [Route("api/CustomerOrder/cancel/{orderid}")]
        [HttpPost]
        public void CancelOrder( int orderid)
        {
            CustomerService.CancelOrder( orderid);
        }
    }
}
