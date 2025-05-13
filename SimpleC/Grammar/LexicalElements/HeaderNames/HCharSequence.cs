namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    public class HCharSequence : GrammarBase
    {
        HChar _hChar1;
        HCharSequence _hCharSequence2;
        HChar _hChar2;

        public HChar HChar1
        {
            get { return _hChar1; }
            set { this.RaiseAndSetIfChanged(ref _hChar1, value); }
        }
        public HCharSequence HCharSequence2
        {
            get { return _hCharSequence2; }
            set { this.RaiseAndSetIfChanged(ref _hCharSequence2, value); }
        }
        public HChar HChar2
        {
            get { return _hChar2; }
            set { this.RaiseAndSetIfChanged(ref _hChar2, value); }
        }

        public HCharSequence()
        {
            this.HChar1 = new HChar();
            this.HChar2 = new HChar();
            this.HCharSequence2 = new HCharSequence();
        }
    }
}
