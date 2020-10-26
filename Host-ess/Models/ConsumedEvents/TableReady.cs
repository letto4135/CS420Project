using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host_ess.Models.ConsumedEvents
{
    public class TableReady
    {
        public int TableNumber { get; set; }
        public int SeatCount { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
