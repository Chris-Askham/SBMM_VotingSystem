using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Models
{
    public class ErrorLogDBModel
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string LoggedDatetimeUTC { get; set; }
        public string Exception { get; set; }
    }
}
