using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataFactoryMr.Models
{
    public class Spending
    {
        public long SpendingId { get; set; }
        public string Month { get; set; }
        public string Media { get; set; }
        public string Region { get; set; }
        public string Quarter { get; set; }
        public string Category { get; set; }
        public string Advertizer { get; set; }
        public string Brand { get; set; }
        public string Station { get; set; }
        public string TvRadio { get; set; }
        public string Days { get; set; }
        public string TimeBand { get; set; }
        public string TimeSlot { get; set; }
        public string PrintOOH { get; set; }
        public string AverageDuration { get; set; }
        public string AdSize { get; set; }
        public decimal TotalSpend { get; set; }
        
    }
}