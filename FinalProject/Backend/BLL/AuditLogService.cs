using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BLL
{
    public class AuditLogService
    {
        public static AuditLogModel AddAuditLog(AuditLogModel auditLog)
        {
            var a = AutoMapper.Mapper.Map<AuditLogModel, Auditlog>(auditLog);
            var data = AuditLogRepo.AddAuditLog(a);
            return AutoMapper.Mapper.Map<Auditlog, AuditLogModel>(data);
        }

        public static List<AuditLogModel> GetAllAuditLogs()
        {
            var auditlogs = AuditLogRepo.GetAllAuditLogs();
            //List<AuditLogModel> data = new List<AuditLogModel>();
            //foreach (var auditlog in auditlogs)
            //{
            //    var a = new AuditLogModel();
            //    a.adminid = auditlog.adminid;
            //    a.createdat = auditlog.createdat;
            //    a.actiontypeid = auditlog.actiontypeid;
            //    a.details = auditlog.details;
            //    a.action_actionanme = auditlog.Action.actionanme;
            //    a.userid = auditlog.userid;
            //    a.user_name = auditlog.User.name;
            //    a.user1_name = auditlog.User1.name;
            //    a.auditlogid = auditlog.auditlogid;

            //    data.Add(a);

            //}
            //return data;
            return AutoMapper.Mapper.Map<List<Auditlog>, List<AuditLogModel>>(auditlogs);
        }

    }
}
