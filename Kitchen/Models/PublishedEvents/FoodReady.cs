﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Models.PublishedEvents
{
    public class FoodReady
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public List<ArrayList> Food { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
