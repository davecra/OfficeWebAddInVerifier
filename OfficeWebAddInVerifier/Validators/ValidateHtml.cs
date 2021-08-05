using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.Validators
{
    public class ValidateHtml : IValidator
    {
        public ValidateHtml(string PstrHtml)
        {

        }
        public bool Check()
        {
            return true;
        }
    }
}
