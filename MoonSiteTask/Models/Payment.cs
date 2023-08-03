using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonSiteTask.Models
{
    //class for Vaad Page used to get list of Payments data from DB
    public class Payment
    {
        int Id { get; set; }
        public string? ResName { get; set; }
        public int Amount { get; set; }
        public int AptNum { get; set; }
        public int Month { get; set; }
        public string? PayedWith { get; set; }
        public int ReciptId {get; set;}
    }
}