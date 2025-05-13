namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    public class SCharSequence : GrammarBase
    {
        SChar _schar1;
        SChar _schar2;
        SCharSequence _scharSequence2;

        public SChar SChar1
        {
            get { return _schar1; }
            set { this.RaiseAndSetIfChanged(ref _schar1, value); }
        }
        public SChar SChar2
        {
            get { return _schar2; }
            set { this.RaiseAndSetIfChanged(ref _schar2, value); }
        }
        public SCharSequence SCharSequence2
        {
            get { return _scharSequence2; }
            set { this.RaiseAndSetIfChanged(ref _scharSequence2, value); }
        }

        public SCharSequence()
        {
            this.SChar1 = new SChar();
            this.SChar2 = new SChar();
            this.SCharSequence2 = new SCharSequence();
        }
    }
}
