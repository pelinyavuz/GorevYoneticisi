using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsletimSistemi_GorevYoneticisi_
{
    public class CpuUsageValueArrayChangedEventArg : EventArgs
    {
        public double[] Values { get; set; }
    }
}
