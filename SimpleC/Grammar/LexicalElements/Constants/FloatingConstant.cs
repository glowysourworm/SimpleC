namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class FloatingConstant : GrammarBase
    {
        DecimalFloatingConstant _decimalFloatingConstant;

        public DecimalFloatingConstant DecimalFloatingConstant
        {
            get { return _decimalFloatingConstant; }
            set { this.RaiseAndSetIfChanged(ref _decimalFloatingConstant, value); }
        }

        public FloatingConstant()
        {
            this.DecimalFloatingConstant = new DecimalFloatingConstant();
        }
    }
}
