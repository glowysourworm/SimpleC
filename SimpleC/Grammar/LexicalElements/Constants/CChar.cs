using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class CChar : GrammarBase
    {
        // "Any member of the source character set except the single-quote ', backslash \, or new-line character"
        char _char;
        EscapeSequence _escapeSequence;

        public char Char
        {
            get { return _char; }
            set { this.RaiseAndSetIfChanged(ref _char, value); }
        }
        public EscapeSequence EscapeSequence
        {
            get { return _escapeSequence; }
            set { this.RaiseAndSetIfChanged(ref _escapeSequence, value); }
        }


        public CChar()
        {
            this.Char = GrammarCConstants.SingleQuote;
            this.EscapeSequence = new EscapeSequence();
        }
    }
}
