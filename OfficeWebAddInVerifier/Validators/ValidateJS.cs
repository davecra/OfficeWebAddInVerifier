using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier.Validators
{
    class ValidateJS : IValidator
    {
        private const string MCstrFunction = "function";
        private const string MCstrSemiColon = ";";
        private const string MCstrOpenParen = "(";
        private const string MCstrCloseParen = ")";
        private const string MCstrOpenBrace = "{";
        private const string MCstrCloseBrace = "}";
        private readonly string MstrScript = ""; 
        public ValidateJS(string PstrScript)
        {
            MstrScript = PstrScript;
        }
        public bool Check()
        {
            if (MstrScript.Contains(MCstrFunction) || MstrScript.Contains(MCstrSemiColon) ||
                MstrScript.Contains(MCstrOpenParen) || MstrScript.Contains(MCstrCloseParen) ||
                MstrScript.Contains(MCstrOpenBrace) || MstrScript.Contains(MCstrCloseBrace)) return true;
            return false;
        }
    }
}
