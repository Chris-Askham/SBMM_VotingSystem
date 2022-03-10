using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMMVotingSystem.Models
{
    public class UserDBModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
        public int Age { get; set; }
        public string RefNumber { get; set; }
        public AddressDBModel Address {get;set;}
        public int Enabled { get; set; }
    }
}
