using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaitStaff.Models.PublishedEvents
{
    public class DrinkOrder
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public Dictionary<string, int> Drink { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
