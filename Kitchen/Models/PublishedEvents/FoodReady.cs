using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Models.PublishedEvents
{
    public class FoodReady
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public List<Dictionary<string, int>> Food { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
