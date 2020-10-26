using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Models.ConsumedEvents
{
    public class FoodOrder
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public Dictionary<string, int> Food { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
