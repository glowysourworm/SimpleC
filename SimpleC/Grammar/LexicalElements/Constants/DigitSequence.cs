using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class DigitSequence : GrammarBase
    {
        Digit _digit1;
        DigitSequence _digitSequence2;
        Digit _digit2;

        public Digit Digit1
        {
            get { return _digit1; }
            set { this.RaiseAndSetIfChanged(ref _digit1, value); }
        }
        public DigitSequence DigitSequence2
        {
            get { return _digitSequence2; }
            set { this.RaiseAndSetIfChanged(ref _digitSequence2, value); }
        }
        public Digit Digit2
        {
            get { return _digit2; }
            set { this.RaiseAndSetIfChanged(ref _digit2, value); }
        }


        public DigitSequence()
        {
            this.DigitSequence2 = new DigitSequence();
            this.Digit1 = new Digit();
            this.Digit2 = new Digit();
        }
    }
}
