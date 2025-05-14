using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class SelectionStatement : Statement
    {
        public const string IfStatement1 = GrammarCKeywords.Keyword_if;
        public const char IfStatementOpenBracket1 = GrammarCConstants.BracketLeft;
        Expression _expression1;
        public const char IfStatementCloseBracket1 = GrammarCConstants.BracketRight;
        Statement _statement1;

        public const string IfStatement2 = GrammarCKeywords.Keyword_if;
        public const char IfStatementOpenBracket2 = GrammarCConstants.BracketLeft;
        Expression _expression2;
        public const char IfStatementCloseBracket2 = GrammarCConstants.BracketRight;
        Statement _statement2a;
        public const string ElseStatement2 = GrammarCKeywords.Keyword_else;
        Statement _statement2b;

        public const string SwitchStatement3 = GrammarCKeywords.Keyword_switch;
        public const char IfStatementOpenBracket3 = GrammarCConstants.BracketLeft;
        Expression _expression3;
        public const char IfStatementCloseBracket3 = GrammarCConstants.BracketRight;
        Statement _statement3;

        public Expression Expression1
        {
            get { return _expression1; }
            set { this.RaiseAndSetIfChanged(ref _expression1, value); }
        }
        public Statement Statement1
        {
            get { return _statement1; }
            set { this.RaiseAndSetIfChanged(ref _statement1, value); }
        }
        public Expression Expression2
        {
            get { return _expression2; }
            set { this.RaiseAndSetIfChanged(ref _expression2, value); }
        }
        public Statement Statement2a
        {
            get { return _statement2a; }
            set { this.RaiseAndSetIfChanged(ref _statement2a, value); }
        }
        public Statement Statement2b
        {
            get { return _statement2b; }
            set { this.RaiseAndSetIfChanged(ref _statement2b, value); }
        }
        public Expression Expression3
        {
            get { return _expression3; }
            set { this.RaiseAndSetIfChanged(ref _expression3, value); }
        }
        public Statement Statement3
        {
            get { return _statement3; }
            set { this.RaiseAndSetIfChanged(ref _statement3, value); }
        }

        public SelectionStatement()
        {
            this.Expression1 = new Expression();
            this.Expression2 = new Expression();
            this.Expression3 = new Expression();
            this.Statement1 = new Statement();
            this.Statement2a = new Statement();
            this.Statement2b = new Statement();
            this.Statement3 = new Statement();
        }
    }
}
