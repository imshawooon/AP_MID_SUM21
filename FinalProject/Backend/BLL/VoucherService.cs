using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class VoucherService
    {
        public static List<VoucherModel> GetAllVouchers()
        {
            var vouchers = VoucherRepo.GetAllVouchers();
            return AutoMapper.Mapper.Map<List<Voucher>, List<VoucherModel>>(vouchers);
        }

        public static List<VoucherModel> GetSearchVouchers(string search)
        {
            var vouchers = VoucherRepo.GetSearchVouchers(search);
            return AutoMapper.Mapper.Map<List<Voucher>, List<VoucherModel>>(vouchers);
        }

        public static VoucherModel GetVoucher(int id)
        {
            var voucher = VoucherRepo.GetVoucher(id);
            return AutoMapper.Mapper.Map<Voucher, VoucherModel>(voucher);
        }

        public static VoucherModel AddVoucher(VoucherModel voucher)
        {
            var v = AutoMapper.Mapper.Map<VoucherModel, Voucher>(voucher);
            var data = VoucherRepo.AddVoucher(v);
            return AutoMapper.Mapper.Map<Voucher, VoucherModel>(data);
        }

        public static VoucherModel EditVoucher(VoucherModel voucher)
        {
            var v = AutoMapper.Mapper.Map<VoucherModel, Voucher>(voucher);
            var data = VoucherRepo.EditVoucher(v);
            return AutoMapper.Mapper.Map<Voucher, VoucherModel>(data);
        }

        public static VoucherModel DeleteVoucher(int id)
        {
            var voucher = VoucherRepo.DeleteVoucher(id);
            return AutoMapper.Mapper.Map<Voucher, VoucherModel>(voucher);
        }
    }
}
