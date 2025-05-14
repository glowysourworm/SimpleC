namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class Group : GrammarBase
    {
        GroupPart _groupPart1;

        Group _group2;
        GroupPart _groupPart2;

        public GroupPart GroupPart1
        {
            get { return _groupPart1; }
            set { this.RaiseAndSetIfChanged(ref _groupPart1, value); }
        }
        public Group Group2
        {
            get { return _group2; }
            set { this.RaiseAndSetIfChanged(ref _group2, value); }
        }
        public GroupPart GroupPart2
        {
            get { return _groupPart2; }
            set { this.RaiseAndSetIfChanged(ref _groupPart2, value); }
        }

        public Group()
        {
            this.GroupPart1 = new GroupPart();
            this.GroupPart2 = new GroupPart();
            this.Group2 = new Group();
        }
    }
}
