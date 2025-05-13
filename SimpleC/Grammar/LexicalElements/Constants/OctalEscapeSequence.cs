using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class OctalEscapeSequence : GrammarBase
    {
        public const char BackslashPrefix = GrammarCConstants.Backslash;
        OctalDigit _octalDigit1;
        OctalDigit _octalDigit2;
        OctalDigit _octalDigit3;

        public OctalDigit OctalDigit1
        {
            get { return _octalDigit1; }
            set { this.RaiseAndSetIfChanged(ref _octalDigit1, value); }
        }
        public OctalDigit OctalDigit2
        {
            get { return _octalDigit2; }
            set { this.RaiseAndSetIfChanged(ref _octalDigit2, value); }
        }
        public OctalDigit OctalDigit3
        {
            get { return _octalDigit3; }
            set { this.RaiseAndSetIfChanged(ref _octalDigit3, value); }
        }

        public OctalEscapeSequence()
        {
            this.OctalDigit1 = new OctalDigit();
            this.OctalDigit2 = new OctalDigit();
            this.OctalDigit3 = new OctalDigit();
        }
    }
}
