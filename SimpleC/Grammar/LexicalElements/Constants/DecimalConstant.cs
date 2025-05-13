using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class DecimalConstant : GrammarBase
    {
        NonZeroDigit _nonZeroDigit;
        DecimalConstant _decimalConstantChild;
        Digit _digit;

        public NonZeroDigit NonZeroDigit
        {
            get { return _nonZeroDigit; }
            set { this.RaiseAndSetIfChanged(ref _nonZeroDigit, value); }
        }
        public DecimalConstant DecimalConstantChild
        {
            get { return _decimalConstantChild; }
            set { this.RaiseAndSetIfChanged(ref _decimalConstantChild, value); }
        }
        public Digit Digit
        {
            get { return _digit; }
            set { this.RaiseAndSetIfChanged(ref _digit, value); }
        }

        public DecimalConstant()
        {
            this.NonZeroDigit = new NonZeroDigit();
            this.Digit = new Digit();
            this.DecimalConstantChild = new DecimalConstant();
        }
    }
}
