using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BEL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<UserModel, User>();
            CreateMap<NoticeModel, Notice>();
            CreateMap<RatingModel, Rating>();
            CreateMap<VoucherModel, Voucher>();
            CreateMap<PackageModel, Package>();
            CreateMap<AuditLogModel, Auditlog>();
            CreateMap<BlogsModel, Blog>();
            CreateMap<OrderModel, Order>();
            //CreateMap<AuditLogModel, Auditlog>().ForMember(e => e.ac, opt => opt.MapFrom(e => e.admin_name));
            //var map = CreateMap<AuditLogModel, DAL.Action>();
            //map.ForAllMembers(opt => opt.Ignore());
            //map.ForMember(dest => dest.actionanme, opt => opt.MapFrom(src => src.action_actionanme));

            //var map2 = CreateMap<AuditLogModel, User>();
            //map2.ForAllMembers(opt => opt.Ignore());
            //map2.ForMember(dest => dest.name, opt => opt.MapFrom(src => src.user_name));
            //map2.ForMember(dest => dest.name, opt => opt.MapFrom(src => src.user1_name));
            ////CreateMap<ProductModel, product>();
            //CreateMap<OrderModel, order>();
            //CreateMap<ProductOrderModel, productorder>();

            //CreateMap<DepartmentModel, Department>().ForMember(e=>e.Students, d=>d.Ignore().ForMember(..));
        }
    }
}
