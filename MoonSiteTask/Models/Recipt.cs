using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoonSiteTask.Models
{
    //class for Vaad Page used to get list of Recipts from DB
    public class Recipt
    {
        public int Id { get; set; }
        public int AptNum { get; set; }
        public int Amount { get; set; }
        public string? Month { get; set; }
        public string? PayedWith { get; set; }
        public string? DayPayed {get; set;}
    }
}