using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoucherRepo
    {
        //static ANTSEntities ContextClass.context;
        //static VoucherRepo()
        //{
        //    ContextClass.context = new ANTSEntities();
        //}

        public static List<Voucher> GetAllVouchers()
        {
            return ContextClass.context.Vouchers.ToList();
        }


        public static List<Voucher> GetSearchVouchers(string search)
        {
            var list = (from p in ContextClass.context.Vouchers
                        where p.voucher1.Contains(search)
                        select p).ToList();
            return list;
        }


        public static Voucher GetVoucher(int id)
        {
            return ContextClass.context.Vouchers.FirstOrDefault(e => e.voucherid == id);
        }

        public static Voucher AddVoucher(Voucher v)
        {
            ContextClass.context.Vouchers.Add(v);
            ContextClass.context.SaveChanges();
            return v;
        }

        public static Voucher EditVoucher(Voucher v)
        {
            var voucher = ContextClass.context.Vouchers.FirstOrDefault(e => e.voucherid == v.voucherid);
            ContextClass.context.Entry(voucher).CurrentValues.SetValues(v);
            ContextClass.context.SaveChanges();
            return voucher;
        }

        public static Voucher DeleteVoucher(int id)
        {
            var voucher = ContextClass.context.Vouchers.FirstOrDefault(e => e.voucherid == id);
            ContextClass.context.Vouchers.Remove(voucher);
            ContextClass.context.SaveChanges();
            return voucher;
        }
    }
}
