using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.ManifestParts
{
    /// <summary>
    /// Log event ags
    /// </summary>
    public class NotifyEventArgs
    {
        public string Message { get; private set; }
        public NotifyEventArgs(string PstrMessage)
        {
            Message = PstrMessage;
        }
    }
}
