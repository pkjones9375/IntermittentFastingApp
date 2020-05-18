using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermittentFasting.Models
{
    public class WeightInfo
    {
        public int WeightID { get; set; }
        public int UserID { get; set; }
        public DateTime WeighInDate { get; set; }
        public decimal WeighIn { get; set; }
        public decimal CalculatedBMI { get; set; }
    }
}
