
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace IsletimSistemi_GorevYoneticisi_
{
    public class TotalCpuUsageMonitor : CpuUsageMonitorBase
    {
        const string categoryName = "Processor";
        const string counterName = "% Processor Time";
        const string instanceName = "_Total";

        public TotalCpuUsageMonitor(int timerPeriod, int valueArrayCapacity)
            : base(timerPeriod, valueArrayCapacity, categoryName, counterName, instanceName)
        { }
    }
}
