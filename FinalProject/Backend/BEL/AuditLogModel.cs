using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AuditLogModel
    {
        public int auditlogid { get; set; }
        public int adminid { get; set; }
        public int userid { get; set; }
        public System.DateTime createdat { get; set; }
        public string details { get; set; }
        public Nullable<int> actiontypeid { get; set; }

        public string user_name { get; set; }
        public string user1_name { get; set; }
        public string action_actionanme { get; set; }

    }
}
