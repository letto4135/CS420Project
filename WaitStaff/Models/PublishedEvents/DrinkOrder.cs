﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaitStaff.Models.PublishedEvents
{
    public class DrinkOrder
    {
        public Int16 OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public List<ArrayList> Drink { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
