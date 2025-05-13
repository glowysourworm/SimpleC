namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class HexadecimalConstant : GrammarBase
    {
        HexadecimalPrefix _hexadecimalPrefix;
        HexadecimalDigit _hexadecimalDigit1;
        HexadecimalConstant _hexadecimalConstantChild;
        HexadecimalDigit _hexadecimalDigit2;

        public HexadecimalPrefix HexadecimalPrefix
        {
            get { return _hexadecimalPrefix; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalPrefix, value); }
        }
        public HexadecimalDigit HexadecimalDigit1
        {
            get { return _hexadecimalDigit1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit1, value); }
        }
        public HexadecimalConstant HexadecimalConstantChild
        {
            get { return _hexadecimalConstantChild; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalConstantChild, value); }
        }
        public HexadecimalDigit HexadecimalDigit2
        {
            get { return _hexadecimalDigit2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit2, value); }
        }

        public HexadecimalConstant()
        {
            this.HexadecimalPrefix = new HexadecimalPrefix();
            this.HexadecimalDigit1 = new HexadecimalDigit();
            this.HexadecimalDigit2 = new HexadecimalDigit();
            this.HexadecimalConstantChild = new HexadecimalConstant();
        }
    }
}
