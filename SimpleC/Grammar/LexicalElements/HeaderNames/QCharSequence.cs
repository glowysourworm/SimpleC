namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    public class QCharSequence : GrammarBase
    {
        QChar _qChar1;
        QCharSequence _qCharSequence2;
        QChar _qChar2;

        public QChar QChar1
        {
            get { return _qChar1; }
            set { this.RaiseAndSetIfChanged(ref _qChar1, value); }
        }
        public QCharSequence QCharSequence2
        {
            get { return _qCharSequence2; }
            set { this.RaiseAndSetIfChanged(ref _qCharSequence2, value); }
        }
        public QChar QChar2
        {
            get { return _qChar2; }
            set { this.RaiseAndSetIfChanged(ref _qChar2, value); }
        }

        public QCharSequence()
        {
            this.QChar1 = new QChar();
            this.QCharSequence2 = new QCharSequence();
            this.QChar2 = new QChar();
        }
    }
}
