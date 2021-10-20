using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.Validators
{
    public class ValidateOfficeJS : IValidator
    {
        private string MstrHtml = "";
        private const string MCstrAPPSFOROFFICEURL = "https://appsforoffice.microsoft.com/lib/1.1/hosted/office.js";
        private const string MCstrAPPSFOROFFICEJS = "office.js";
        public ValidateOfficeJS(string PstrHtml)
        {
            MstrHtml = PstrHtml;
        }

        /// <summary>
        /// Check to see if the document is an OfficeJS file.
        /// We will know because it is pointed to our OfficeJS library
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            if(MstrHtml.Contains(MCstrAPPSFOROFFICEURL) || MstrHtml.Contains(MCstrAPPSFOROFFICEJS)) return true;
            return false;
        }
    }
}
