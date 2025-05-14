namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class ElseGroup : GrammarBase
    {
        public const char ElseGroupHashtag1 = GrammarCConstants.Hashtag;
        public const string ElseKeyword1 = GrammarCKeywords.Keyword_else;
        NewLine _newLine1;
        Group? _group1;

        public NewLine NewLine1
        {
            get { return _newLine1; }
            set { this.RaiseAndSetIfChanged(ref _newLine1, value); }
        }
        public Group? Group1
        {
            get { return _group1; }
            set { this.RaiseAndSetIfChanged(ref _group1, value); }
        }

        public ElseGroup()
        {
            this.NewLine1 = new NewLine();
            this.Group1 = null;
        }
    }
}
