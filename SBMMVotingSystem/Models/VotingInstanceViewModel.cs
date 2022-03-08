using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SBMMVotingSystem.Managers.VotingManager;

namespace SBMMVotingSystem.Models
{
    public class VotingInstanceViewModel
    {
        public int VotingInstanceId { get; set; }
        public string VIName { get; set; }
        public string VIDescription { get; set;}
        public int AddressId { get; set; }
        public int CurrentlyInUse { get; set; }
        public VotingMode VIVotingMode { get; set; }
        public AddressDBModel Address { get; set; }
        public List<VotingOptionDBModel> VotingOptions { get; set; }
    }
}
