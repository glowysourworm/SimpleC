using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class OctalConstant : GrammarBase
    {
        const char ZERO = '0';  // This constant must be the first member of octal-constant (see Appendix -> 6.4.4.1)

        OctalConstant _octalConstantChild;
        OctalDigit _octalDigit;

        public OctalConstant OctalConstantChild
        {
            get { return _octalConstantChild; }
            set { this.RaiseAndSetIfChanged(ref _octalConstantChild, value); }
        }
        public OctalDigit OctalDigit
        {
            get { return _octalDigit; }
            set { this.RaiseAndSetIfChanged(ref _octalDigit, value); }
        }

        public OctalConstant()
        {
            this.OctalConstantChild = new OctalConstant();
            this.OctalDigit = new OctalDigit();
        }
    }
}
