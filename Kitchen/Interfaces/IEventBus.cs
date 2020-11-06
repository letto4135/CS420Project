﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Interfaces
{
    public interface IEventBus
    {
        int PortNumber { get; set; }
        String HostName { get; set; }
        void PublishEvent<T>(String queueName, T e);
        string ConsumeEvent(String queueName);
    }
}
