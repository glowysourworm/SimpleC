namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class IntegerSuffix : GrammarBase
    {
        UnsignedSuffix _unsignedSuffix1;
        LongSuffix _longSuffix1;

        UnsignedSuffix _unsignedSuffix2;
        LongLongSuffix _longLongSuffix2;

        LongSuffix _longSuffix3;
        UnsignedSuffix _unsignedSuffix3;

        LongLongSuffix _longLongSuffix4;
        UnsignedSuffix _unsignedSuffix4;

        public UnsignedSuffix UnsignedSuffix1
        {
            get { return _unsignedSuffix1; }
            set { this.RaiseAndSetIfChanged(ref _unsignedSuffix1, value); }
        }
        public LongSuffix LongSuffix1
        {
            get { return _longSuffix1; }
            set { this.RaiseAndSetIfChanged(ref _longSuffix1, value); }
        }
        public UnsignedSuffix UnsignedSuffix2
        {
            get { return _unsignedSuffix2; }
            set { this.RaiseAndSetIfChanged(ref _unsignedSuffix2, value); }
        }
        public LongLongSuffix LongLongSuffix2
        {
            get { return _longLongSuffix2; }
            set { this.RaiseAndSetIfChanged(ref _longLongSuffix2, value); }
        }
        public LongSuffix LongSuffix3
        {
            get { return _longSuffix3; }
            set { this.RaiseAndSetIfChanged(ref _longSuffix3, value); }
        }
        public UnsignedSuffix UnsignedSuffix3
        {
            get { return _unsignedSuffix3; }
            set { this.RaiseAndSetIfChanged(ref _unsignedSuffix3, value); }
        }
        public LongLongSuffix LongLongSuffix4
        {
            get { return _longLongSuffix4; }
            set { this.RaiseAndSetIfChanged(ref _longLongSuffix4, value); }
        }
        public UnsignedSuffix UnsignedSuffix4
        {
            get { return _unsignedSuffix4; }
            set { this.RaiseAndSetIfChanged(ref _unsignedSuffix4, value); }
        }

        public IntegerSuffix()
        {
            this.UnsignedSuffix1 = new UnsignedSuffix();
            this.UnsignedSuffix2 = new UnsignedSuffix();
            this.UnsignedSuffix3 = new UnsignedSuffix();
            this.UnsignedSuffix4 = new UnsignedSuffix();
            this.LongSuffix1 = new LongSuffix();
            this.LongLongSuffix2 = new LongLongSuffix();
            this.LongSuffix3 = new LongSuffix();
            this.LongLongSuffix4 = new LongLongSuffix();
        }
    }
}
