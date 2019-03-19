using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsletimSistemi_GorevYoneticisi_
{
    public class ErrorEventArgs : EventArgs
    {
        public Exception Error { get; set; }
    }
}
