using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermittentFasting.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal HeightInInches { get; set; }
        public decimal StartWeight { get; set; }
        //WeighIn added on 5.21 to tie in with UpdateUser View
        public decimal WeighIn { get; set; }
        public DateTime FastStartDate { get; set; }
        public int TimeToFast { get; set; }
    }
}
// blah blah