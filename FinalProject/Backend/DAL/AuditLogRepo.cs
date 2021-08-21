using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuditLogRepo
    {
        //static ANTSEntities ContextClass.context;
        //static AuditLogRepo()
        //{
        //    ContextClass.context = new ANTSEntities();
        //}

        public static Auditlog AddAuditLog(Auditlog a)
        {
            ContextClass.context.Auditlogs.Add(a);
            ContextClass.context.SaveChanges();
            return a;
        }

        public static List<Auditlog> GetAllAuditLogs()
        {
            return ContextClass.context.Auditlogs.ToList();
        }



    }
}
