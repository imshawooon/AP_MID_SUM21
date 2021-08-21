using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;

namespace BLL
{
    public class NoticeService
    {
        public static List<NoticeModel> GetAllNotices()
        {
            var notices = NoticeRepo.GetAllNotices();
            return AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(notices);
        }

        public static List<NoticeModel> GetSearchNotices(string search)
        {
            var notices = NoticeRepo.GetSearchNotices(search);
            return AutoMapper.Mapper.Map<List<Notice>, List<NoticeModel>>(notices);
        }

        public static NoticeModel GetNotice(int id)
        {
            var notice = NoticeRepo.GetNotice(id);
            return AutoMapper.Mapper.Map<Notice, NoticeModel>(notice);
        }

        public static NoticeModel AddNotice(NoticeModel notice)
        {
            var n = AutoMapper.Mapper.Map<NoticeModel, Notice>(notice);
            var data = NoticeRepo.AddNotice(n);
            return AutoMapper.Mapper.Map<Notice, NoticeModel>(data);
        }

        public static NoticeModel EditNotice(NoticeModel notice)
        {
            var n = AutoMapper.Mapper.Map<NoticeModel, Notice>(notice);
            var data = NoticeRepo.EditNotice(n);
            return AutoMapper.Mapper.Map<Notice, NoticeModel>(data);
        }

        public static NoticeModel DeleteNotice(int id)
        {
            var notice = NoticeRepo.DeleteNotice(id);
            return AutoMapper.Mapper.Map<Notice, NoticeModel>(notice);
        }
    }
}
