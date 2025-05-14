using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class IfGroup : GrammarBase
    {
        public const char IfHashtag1 = GrammarCConstants.Hashtag;
        public const string IfKeyword1 = GrammarCKeywords.Keyword_if;
        ConstantExpression _constantExpression1;
        NewLine _newLine1;
        Group? _group1;

        public const char IfdefHashtag2 = GrammarCConstants.Hashtag;
        public const string IfdefKeyword2 = GrammarCKeywords.Keyword_ifdef;
        Identifier _identifier2;
        NewLine _newLine2;
        Group? _group2;

        public const char IfndefHashtag3 = GrammarCConstants.Hashtag;
        public const string IfndefKeyword3 = GrammarCKeywords.Keyword_ifndef;
        Identifier _identifier3;
        NewLine _newLine3;
        Group? _group3;

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
        public Identifier Identifier2
        {
            get { return _identifier2; }
            set { this.RaiseAndSetIfChanged(ref _identifier2, value); }
        }
        public NewLine NewLine2
        {
            get { return _newLine2; }
            set { this.RaiseAndSetIfChanged(ref _newLine2, value); }
        }
        public Group? Group2
        {
            get { return _group2; }
            set { this.RaiseAndSetIfChanged(ref _group2, value); }
        }
        public Identifier Identifier3
        {
            get { return _identifier3; }
            set { this.RaiseAndSetIfChanged(ref _identifier3, value); }
        }
        public NewLine NewLine3
        {
            get { return _newLine3; }
            set { this.RaiseAndSetIfChanged(ref _newLine3, value); }
        }
        public Group? Group3
        {
            get { return _group3; }
            set { this.RaiseAndSetIfChanged(ref _group3, value); }
        }

        public IfGroup()
        {
            this.ConstantExpression1 = new ConstantExpression();
            this.NewLine1 = new NewLine();
            this.NewLine2 = new NewLine();
            this.NewLine3 = new NewLine();
            this.Group1 = null;
            this.Group2 = null;
            this.Group3 = null;
            this.Identifier2 = new Identifier();
            this.Identifier3 = new Identifier();
        }
    }
}
