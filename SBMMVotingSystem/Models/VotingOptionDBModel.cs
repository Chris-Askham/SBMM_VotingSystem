using System;

namespace SBMMVotingSystem.Models
{
    public class VotingOptionDBModel
    {
        public int VotingOptionId { get; set; }
        public String VOName { get; set; }
        public String VODescription { get; set; }
        public int VotingInstanceId { get; set; }
    }
}
