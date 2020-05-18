using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermittentFasting.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HeightInInches { get; set; }
        public decimal StartWeight { get; set; }
        public DateTime FastStartDate { get; set; }
        public DateTime TimeToFast { get; set; }
    }
}
// blah blah