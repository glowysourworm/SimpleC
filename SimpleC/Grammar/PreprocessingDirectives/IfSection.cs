namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class IfSection : GrammarBase
    {
        IfGroup _ifGroup1;
        ElifGroups? _elifGroups1;
        ElseGroup? _elseGroup1;
        EndifLine _endifLine;

        public IfGroup IfGroup1
        {
            get { return _ifGroup1; }
            set { this.RaiseAndSetIfChanged(ref _ifGroup1, value); }
        }
        public ElifGroups? ElifGroups1
        {
            get { return _elifGroups1; }
            set { this.RaiseAndSetIfChanged(ref _elifGroups1, value); }
        }
        public ElseGroup? ElseGroup1
        {
            get { return _elseGroup1; }
            set { this.RaiseAndSetIfChanged(ref _elseGroup1, value); }
        }
        public EndifLine EndifLine
        {
            get { return _endifLine; }
            set { this.RaiseAndSetIfChanged(ref _endifLine, value); }
        }

        public IfSection()
        {
            this.IfGroup1 = new IfGroup();
            this.ElifGroups1 = null;
            this.ElseGroup1 = null;
            this.EndifLine = new EndifLine();
        }
    }
}
