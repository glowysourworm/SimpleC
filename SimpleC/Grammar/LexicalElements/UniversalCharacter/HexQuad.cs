using SimpleC.Grammar.LexicalElements.Constants;

namespace SimpleC.Grammar.LexicalElements.UniversalCharacter
{
    public class HexQuad : HexadecimalDigit
    {
        HexadecimalDigit _hexadecimalDigit1;
        HexadecimalDigit _hexadecimalDigit2;
        HexadecimalDigit _hexadecimalDigit3;
        HexadecimalDigit _hexadecimalDigit4;

        public HexadecimalDigit HexadecimalDigit1
        {
            get { return _hexadecimalDigit1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit1, value); }
        }
        public HexadecimalDigit HexadecimalDigit2
        {
            get { return _hexadecimalDigit2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit2, value); }
        }
        public HexadecimalDigit HexadecimalDigit3
        {
            get { return _hexadecimalDigit3; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit3, value); }
        }
        public HexadecimalDigit HexadecimalDigit4
        {
            get { return _hexadecimalDigit4; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit4, value); }
        }

        public HexQuad()
        {
            this.HexadecimalDigit1 = new HexadecimalDigit();
            this.HexadecimalDigit2 = new HexadecimalDigit();
            this.HexadecimalDigit3 = new HexadecimalDigit();
            this.HexadecimalDigit4 = new HexadecimalDigit();
        }
    }
}
