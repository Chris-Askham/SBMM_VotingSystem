using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Models
{
    /// <summary>
    /// Total summary of the selected election
    /// This include all the election details, plus the 2 result views (By option, By City)
    /// </summary>
    public class SummaryExportModel
    {
        public VotingInstanceViewModel VotingInstance { get; set; }
        public List<SummaryForAreaViewModel> ResultsForArea { get; set; }
        public List<SummaryChartViewModel> ResultsForOption { get; set; }
    }

    /// <summary>
    /// Summary of the election data based on the city the vote was placed
    /// </summary>
    public class SummaryForAreaViewModel
    {
        public int VotedForOptionId { get; set; }
        public string VOName { get; set; }
        public string City { get; set; }
        public int NumberOfVotesPerCity { get; set; }
    }

    /// <summary>
    /// Summary of the election data based on the option that was chosen
    /// </summary>
    public class SummaryChartViewModel
    {
        public int VotedForOptionId { get; set; }
        public string VOName { get; set; }
        public int NumberOfVotes { get; set; }
    }
}
