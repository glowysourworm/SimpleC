namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class ElifGroups : GrammarBase
    {
        ElifGroup _elifGroup1;

        ElifGroups _elifGroups2;
        ElifGroup _elifGroup2;

        public ElifGroup ElifGroup1
        {
            get { return _elifGroup1; }
            set { this.RaiseAndSetIfChanged(ref _elifGroup1, value); }
        }
        public ElifGroups ElifGroups2
        {
            get { return _elifGroups2; }
            set { this.RaiseAndSetIfChanged(ref _elifGroups2, value); }
        }
        public ElifGroup ElifGroup2
        {
            get { return _elifGroup2; }
            set { this.RaiseAndSetIfChanged(ref _elifGroup2, value); }
        }

        public ElifGroups()
        {
            this.ElifGroup1 = new ElifGroup();
            this.ElifGroup2 = new ElifGroup();
            this.ElifGroups2 = new ElifGroups();
        }
    }
}
