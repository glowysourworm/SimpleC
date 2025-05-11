using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.LexicalElements.Identifiers
{
    /// <summary>
    /// (See A.1.3 -> 6.4.2.1) identifier:
    /// </summary>
    public class Identifier : GrammarBase
    {
        IdentifierNonDigit _identifierNonDigit1;
        Identifier _identifier1;
        IdentifierNonDigit _identifierNonDigit2;
        Identifier _identifier2;
        Digit _digit;

        public IdentifierNonDigit IdentifierNonDigit1
        {
            get { return _identifierNonDigit1; }
            set { RaiseAndSetIfChanged(ref _identifierNonDigit1, value); }
        }
        public Identifier Identifier1
        {
            get { return _identifier1; }
            set { RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public IdentifierNonDigit IdentifierNonDigit2
        {
            get { return _identifierNonDigit2; }
            set { RaiseAndSetIfChanged(ref _identifierNonDigit2, value); }
        }
        public Identifier Identifier2
        {
            get { return _identifier2; }
            set { RaiseAndSetIfChanged(ref _identifier2, value); }
        }
        public Digit Digit
        {
            get { return _digit; }
            set { RaiseAndSetIfChanged(ref _digit, value); }
        }

        public Identifier()
        {
            this.IdentifierNonDigit1 = new IdentifierNonDigit();
            this.Identifier1 = new Identifier();
            this.IdentifierNonDigit2 = new IdentifierNonDigit();
            this.Identifier2 = new Identifier();
            this.Digit = new Digit();
        }
    }
}
