using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonSiteTask.Entities
{
    public class Payment
    {
        public int AptNum { get; set; }
        public string? ResName { get; set; }
        public int Amount { get; set; }
        public Month PayMonth { get; set; }
        public string? PayedWith { get; set; }
    }
    public enum Month{
        jan = 0,
        feb = 1,
        mar = 2,
        apr = 3, 
        may = 4,
        jun = 5,
        jul = 6,
        aug = 7,
        sep = 8,
        oct = 9,
        nov = 10,
        dec = 11
    }
}