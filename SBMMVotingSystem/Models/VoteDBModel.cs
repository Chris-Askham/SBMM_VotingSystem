using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Models
{
    public class VoteDBModel
    {
        public int VotedForOptionId { get; set; }
        public int VotingInstanceId { get; set; }
        public string VotedAtCity { get; set; }
        public int Preference { get; set; }
    }
}
