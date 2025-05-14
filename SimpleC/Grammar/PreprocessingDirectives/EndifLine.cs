namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class EndifLine : GrammarBase
    {
        public const char EndifGroupHashtag1 = GrammarCConstants.Hashtag;
        public const string EndifKeyword1 = GrammarCKeywords.Keyword_else;
        NewLine _newLine1;

        public NewLine NewLine1
        {
            get { return _newLine1; }
            set { this.RaiseAndSetIfChanged(ref _newLine1, value); }
        }

        public EndifLine()
        {
            this.NewLine1 = new NewLine();
        }
    }
}
