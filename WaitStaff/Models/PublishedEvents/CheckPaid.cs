using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaitStaff.Models.PublishedEvents
{
    public class CheckPaid
    {
        public int TableNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
