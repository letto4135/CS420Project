﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bartender.Models.ConsumedEvents
{
    public class DrinkOrder
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public List<Dictionary<string, int>> Drink { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
