using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class OutputHandlerArgs
    {
        public string Message { get; private set; }
        public bool Success { get; private set; }
        public OutputHandlerArgs(string PobjMsg, bool PbolSuccess)
        {
            Message = PobjMsg;
            Success = PbolSuccess;
        }
    }
}
