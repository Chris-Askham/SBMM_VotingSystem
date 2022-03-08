using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Models
{
    public class UserAuditDBModel
    {
        public int UserId { get; set; }
        public int VotingInstanceId { get; set; }
        public string LoggedDatetimeUTC { get; set; }
        public string Message { get; set; }
        public string AuditType { get; set; }
    }
}
