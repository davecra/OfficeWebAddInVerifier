using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.Validators
{
    class ValidateJS : IValidator
    {
        public ValidateJS(string PstrHtml)
        {

        }
        public bool Check()
        {
            return true;
        }
    }
}
