using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Web.Http;


namespace ANTSBackend.Controllers
{
    public class AdminController : ApiController
    {
        //USERS
        [Route("api/users/all")]
        [HttpGet]
        public List<UserModel> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }

        [Route("api/users/search/{search}")]
        [HttpGet]
        public List<UserModel> GetSearchUsers(string search)
        {
            return UserService.GetSearchUsers(search);
        }

        [Route("api/users/{id}")]
        [HttpGet]
        public UserModel GetUser(int id)
        {
            return UserService.GetUser(id);
        }

        [Route("api/users/add")]
        [HttpPost]
        public UserModel AddUser(UserModel user)
        {
            user.usertype = "Manager";
            user.createdat = DateTime.Now;
            return UserService.AddUser(user);
        }

        [Route("api/users/edit")]
        [HttpPut]
        public UserModel EditUser(UserModel user)
        {
            return UserService.EditUser(user);
        }

        [Route("api/users/delete/{id}")]
        [HttpDelete]
        public UserModel DeleteUser(int id)
        {
            return UserService.DeleteUser(id);
        }

        //NOTICES
        [Route("api/notices/all")]
        [HttpGet]
        public List<NoticeModel> GetAllNotices()
        {
            return NoticeService.GetAllNotices();
        }

        [Route("api/notices/search/{search}")]
        [HttpGet]
        public List<NoticeModel> GetSearchNotices(string search)
        {
            return NoticeService.GetSearchNotices(search);
        }


        [Route("api/notices/{id}")]
        [HttpGet]
        public NoticeModel GetNotice(int id)
        {
            return NoticeService.GetNotice(id);
        }

        [Route("api/notices/add")]
        [HttpPost]
        public NoticeModel AddNotice(NoticeModel notice)
        {
            notice.createdat = DateTime.Now;
            return NoticeService.AddNotice(notice);
        }

        [Route("api/notices/edit")]
        [HttpPut]
        public NoticeModel EditNotice(NoticeModel notice)
        {
            return NoticeService.EditNotice(notice);
        }

        [Route("api/notices/delete/{id}")]
        [HttpDelete]
        public NoticeModel DeleteNotice(int id)
        {
            return NoticeService.DeleteNotice(id);
        }

        //COMPLAINS
        [Route("api/complains/all")]
        [HttpGet]
        public List<RatingModel> GetAllRatings()
        {
            return RatingService.GetAllRatings();
        }

        [Route("api/complains/{id}")]
        [HttpGet]
        public RatingModel GetRating(int id)
        {
            return RatingService.GetRating(id);
        }

        [Route("api/ratings/add")]
        [HttpPost]
        public RatingModel AddRating(RatingModel rating)
        {
            return RatingService.AddRating(rating);
        }

        [Route("api/complains/edit")]
        [HttpPut]
        public RatingModel EditRating(RatingModel rating)
        {
            return RatingService.EditRating(rating);
        }

        [Route("api/complains/delete/{id}")]
        [HttpDelete]
        public RatingModel DeleteRating(int id)
        {
            return RatingService.DeleteRating(id);
        }

        //VOUCHERS
        [Route("api/vouchers/all")]
        [HttpGet]
        public List<VoucherModel> GetAllVouchers()
        {
            return VoucherService.GetAllVouchers();
        }


        [Route("api/vouchers/search/{search}")]
        [HttpGet]
        public List<VoucherModel> GetSearchVouchers(string search)
        {
            return VoucherService.GetSearchVouchers(search);
        }


        [Route("api/vouchers/{id}")]
        [HttpGet]
        public VoucherModel GetVoucher(int id)
        {
            return VoucherService.GetVoucher(id);
        }

        [Route("api/vouchers/add")]
        [HttpPost]
        public VoucherModel AddVoucher(VoucherModel voucher)
        {
            return VoucherService.AddVoucher(voucher);
        }

        [Route("api/vouchers/edit")]
        [HttpPut]
        public VoucherModel EditVoucher(VoucherModel voucher)
        {
            return VoucherService.EditVoucher(voucher);
        }

        [Route("api/vouchers/delete/{id}")]
        [HttpDelete]
        public VoucherModel DeleteVoucher(int id)
        {
            return VoucherService.DeleteVoucher(id);
        }

        //AUDIT LOG
        [Route("api/auditlogs/add")]
        [HttpPost]
        public AuditLogModel AddAuditLog(AuditLogModel auditLog)
        {
            auditLog.createdat = DateTime.Now;
            auditLog.details = "apatoto Thak";
            var data = AuditLogService.AddAuditLog(auditLog);
            return data;
        }

        [Route("api/auditlogs/all")]
        [HttpGet]
        public List<AuditLogModel> GetAllAuditLogs()
        {
            return AuditLogService.GetAllAuditLogs();
        }

        //ORDER
        [Route("api/orders/all")]
        [HttpGet]
        public List<OrderModel> GetFullOrders()
        {
            return SellerOrderService.GetFullOrders();
        }

    }
}
