namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class CCharSequence : GrammarBase
    {
        CChar _cchar1;
        CCharSequence _ccharSequence2;
        CChar _cchar2;

        public CChar CChar1
        {
            get { return _cchar1; }
            set { this.RaiseAndSetIfChanged(ref _cchar1, value); }
        }
        public CCharSequence CCharSequence2
        {
            get { return _ccharSequence2; }
            set { this.RaiseAndSetIfChanged(ref _ccharSequence2, value); }
        }
        public CChar CChar2
        {
            get { return _cchar2; }
            set { this.RaiseAndSetIfChanged(ref _cchar2, value); }
        }

        public CCharSequence()
        {
            this.CChar1 = new CChar();
            this.CChar2 = new CChar();
            this.CCharSequence2 = new CCharSequence();
        }
    }
}
