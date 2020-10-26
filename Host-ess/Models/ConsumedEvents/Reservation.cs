using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host_ess.Models.ConsumedEvents
{
    public class Reservation
    {
        public int GuestCount { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
