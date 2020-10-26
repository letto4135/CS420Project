using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaitStaff.Models.ConsumedEvents
{
    public class SeatedTable
    {
        public int TableNumber { get; set; }
        public int Guests { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
