namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class GroupPart : GrammarBase
    {
        IfSection _ifSection1;

        ControlLine _controlLine2;

        TextLine _textLine3;

        public const char HashtagNonDirective4 = GrammarCConstants.Hashtag;
        NonDirective _nonDirective4;

        public IfSection IfSection1
        {
            get { return _ifSection1; }
            set { this.RaiseAndSetIfChanged(ref _ifSection1, value); }
        }
        public ControlLine ControlLine2
        {
            get { return _controlLine2; }
            set { this.RaiseAndSetIfChanged(ref _controlLine2, value); }
        }
        public TextLine TextLine3
        {
            get { return _textLine3; }
            set { this.RaiseAndSetIfChanged(ref _textLine3, value); }
        }
        public NonDirective NonDirective4
        {
            get { return _nonDirective4; }
            set { this.RaiseAndSetIfChanged(ref _nonDirective4, value); }
        }

        public GroupPart()
        {
            this.IfSection1 = new IfSection();
            this.ControlLine2 = new ControlLine();
            this.TextLine3 = new TextLine();
            this.NonDirective4 = new NonDirective();
        }
    }
}
