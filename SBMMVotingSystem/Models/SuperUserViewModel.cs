using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SBMMVotingSystem.Managers.UserManager;

namespace SBMMVotingSystem.Models
{
    public class SuperUserViewModel : UserDBModel
    {
        internal string Username { get; set; }
        internal string Password { get; set; }
        internal UserType UserType { get; set; }
    }
}
