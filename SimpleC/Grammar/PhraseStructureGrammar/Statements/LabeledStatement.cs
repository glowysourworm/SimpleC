using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class LabeledStatement : Statement
    {
        Identifier _identifier1;
        public const char ColonSeparator1 = GrammarCConstants.Colon;
        Statement _statement1;

        public const string CaseStatement2 = GrammarCKeywords.Keyword_case;
        ConstantExpression _constantExpression2;
        public const char ColonSeparator2 = GrammarCConstants.Colon;
        Statement _statement2;

        public const string DefaultStatement3 = GrammarCKeywords.Keyword_default;
        public const char ColonSeparator3 = GrammarCConstants.Colon;
        Statement _statement3;

        public Identifier Identifier1
        {
            get { return _identifier1; }
            set { this.RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public Statement Statement1
        {
            get { return _statement1; }
            set { this.RaiseAndSetIfChanged(ref _statement1, value); }
        }
        public ConstantExpression ConstantExpression2
        {
            get { return _constantExpression2; }
            set { this.RaiseAndSetIfChanged(ref _constantExpression2, value); }
        }
        public Statement Statement2
        {
            get { return _statement2; }
            set { this.RaiseAndSetIfChanged(ref _statement2, value); }
        }
        public Statement Statement3
        {
            get { return _statement3; }
            set { this.RaiseAndSetIfChanged(ref _statement3, value); }
        }

        public LabeledStatement()
        {
            this.Identifier1 = new Identifier();
            this.ConstantExpression2 = new ConstantExpression();
            this.Statement1 = new Statement();
            this.Statement2 = new Statement();
            this.Statement3 = new Statement();
        }
    }
}
