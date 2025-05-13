namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class HexadecimalFloatingConstant : GrammarBase
    {
        HexadecimalPrefix _hexadecimalPrefix1;
        HexadecimalFractionalConstant _hexadecimalFractionalConstant1;
        BinaryExponentPart _binaryExponentPart1;
        FloatingSuffix _floatingSuffix1;

        HexadecimalPrefix _hexadecimalPrefix2;
        HexadecimalDigitSequence _hexadecimalDigitSequence2;
        BinaryExponentPart _binaryExponentPart2;
        FloatingSuffix _floatingSuffix2;

        public HexadecimalPrefix HexadecimalPrefix1
        {
            get { return _hexadecimalPrefix1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalPrefix1, value); }
        }
        public HexadecimalFractionalConstant HexadecimalFractionalConstant1
        {
            get { return _hexadecimalFractionalConstant1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalFractionalConstant1, value); }
        }
        public BinaryExponentPart BinaryExponentPart1
        {
            get { return _binaryExponentPart1; }
            set { this.RaiseAndSetIfChanged(ref _binaryExponentPart1, value); }
        }
        public FloatingSuffix FloatingSuffix1
        {
            get { return _floatingSuffix1; }
            set { this.RaiseAndSetIfChanged(ref _floatingSuffix1, value); }
        }
        public HexadecimalPrefix HexadecimalPrefix2
        {
            get { return _hexadecimalPrefix2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalPrefix2, value); }
        }
        public HexadecimalDigitSequence HexadecimalDigitSequence2
        {
            get { return _hexadecimalDigitSequence2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigitSequence2, value); }
        }
        public BinaryExponentPart BinaryExponentPart2
        {
            get { return _binaryExponentPart2; }
            set { this.RaiseAndSetIfChanged(ref _binaryExponentPart2, value); }
        }
        public FloatingSuffix FloatingSuffix2
        {
            get { return _floatingSuffix2; }
            set { this.RaiseAndSetIfChanged(ref _floatingSuffix2, value); }
        }

        public HexadecimalFloatingConstant()
        { 
            this.FloatingSuffix1 = new FloatingSuffix();
            this.BinaryExponentPart1 = new BinaryExponentPart();
            this.HexadecimalFractionalConstant1 = new HexadecimalFractionalConstant();
            this.HexadecimalPrefix1 = new HexadecimalPrefix();  

            this.HexadecimalPrefix2 = new HexadecimalPrefix();
            this.HexadecimalDigitSequence2 = new HexadecimalDigitSequence();
            this.BinaryExponentPart2 = new BinaryExponentPart();
            this.FloatingSuffix2 = new FloatingSuffix();
        }
    }
}
