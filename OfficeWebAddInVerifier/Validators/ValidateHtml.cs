using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.Validators
{
    public class ValidateHtml : IValidator
    {
        private const string MCstrHTMLTag = "<html";
        private const string MCstrScriptTag = "<script";
        private readonly string MstrHtml = "";
        public ValidateHtml(string PstrHtml)
        {
            MstrHtml = PstrHtml;
        }
        public bool Check()
        {
            if (MstrHtml.Contains(MCstrHTMLTag) || MstrHtml.Contains(MCstrScriptTag)) return true;
            return false;
        }
    }
}
