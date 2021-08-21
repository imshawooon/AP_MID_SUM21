using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NoticeRepo
    {
        //static ANTSEntities ContextClass.context;
        //static NoticeRepo()
        //{
        //    ContextClass.context = new ANTSEntities();
        //}


        public static List<Notice> GetAllNotices()
        {
            return ContextClass.context.Notices.ToList();
        }

        public static List<Notice> GetSearchNotices(string search)
        {
            var list = (from p in ContextClass.context.Notices
                        where p.notice1.Contains(search)
                        select p).ToList();
            return list;
        }

        public static Notice GetNotice(int id)
        {
            return ContextClass.context.Notices.FirstOrDefault(e => e.noticeid == id);
        }

        public static Notice AddNotice(Notice n)
        {
            ContextClass.context.Notices.Add(n);
            ContextClass.context.SaveChanges();
            return n;
        }

        public static Notice EditNotice(Notice n)
        {
            var notice = ContextClass.context.Notices.FirstOrDefault(e => e.noticeid == n.noticeid);
            ContextClass.context.Entry(notice).CurrentValues.SetValues(n);
            ContextClass.context.SaveChanges();
            return notice;
        }

        public static Notice DeleteNotice(int id)
        {
            var notice = ContextClass.context.Notices.FirstOrDefault(e => e.noticeid == id);
            ContextClass.context.Notices.Remove(notice);
            ContextClass.context.SaveChanges();
            return notice;
        }
    }
}
