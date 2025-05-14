using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class ElifGroup : GrammarBase
    {
        public const char ElifGroupHashtag1 = GrammarCConstants.Hashtag;
        public const string ElifKeyword1 = GrammarCKeywords.Keyword_elif;
        ConstantExpression _constantExpression1;
        NewLine _newLine1;
        Group? _group1;

        public ConstantExpression ConstantExpression1
        {
            get { return _constantExpression1; }
            set { this.RaiseAndSetIfChanged(ref _constantExpression1, value); }
        }
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

        public ElifGroup()
        {
            this.ConstantExpression1 = new ConstantExpression();
            this.NewLine1 = new NewLine();
            this.Group1 = null;
        }
    }
}
