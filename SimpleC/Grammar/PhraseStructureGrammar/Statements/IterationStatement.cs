using SimpleC.Grammar.PhraseStructureGrammar.Declarations;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class IterationStatement : Statement
    {
        public const string WhileStatement1 = GrammarCKeywords.Keyword_while;
        public const char WhileStatementOpenBracket1 = GrammarCConstants.BracketLeft;
        Expression _expression1;
        public const char WhileStatementCloseBracket1 = GrammarCConstants.BracketRight;
        Statement _statement1;

        public const string DoStatement2 = GrammarCKeywords.Keyword_do;
        Statement _statement2;
        public const string WhileStatement2 = GrammarCKeywords.Keyword_while;
        public const char WhileStatementOpenBracket2 = GrammarCConstants.BracketLeft;
        Expression _expression2;
        public const char WhileStatementCloseBracket2 = GrammarCConstants.BracketRight;
        public const char WhileSeparator2 = GrammarCConstants.Semicolon;

        public const string ForStatement3 = GrammarCKeywords.Keyword_for;
        public const char ForStatementOpenBracket3 = GrammarCConstants.BracketLeft;
        Expression? _expression3a;
        public const char ForSeparator3a = GrammarCConstants.Semicolon;
        Expression? _expression3b;
        public const char ForSeparator3b = GrammarCConstants.Semicolon;
        Expression? _expression3c;
        public const char ForStatementCloseBracket3 = GrammarCConstants.BracketRight;
        Statement _statement3;

        public const string ForStatement4 = GrammarCKeywords.Keyword_for;
        public const char ForStatementOpenBracket4 = GrammarCConstants.BracketLeft;
        Declaration _declaration4;
        Expression? _expression4a;
        public const char ForSeparator4 = GrammarCConstants.Semicolon;
        Expression? _expression4b;
        public const char ForStatementCloseBracket4 = GrammarCConstants.BracketRight;
        Statement _statement4;

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
        public Statement Statement2
        {
            get { return _statement2; }
            set { this.RaiseAndSetIfChanged(ref _statement2, value); }
        }
        public Expression Expression2
        {
            get { return _expression2; }
            set { this.RaiseAndSetIfChanged(ref _expression2, value); }
        }
        public Expression? Expression3a
        {
            get { return _expression3a; }
            set { this.RaiseAndSetIfChanged(ref _expression3a, value); }
        }
        public Expression? Expression3b
        {
            get { return _expression3b; }
            set { this.RaiseAndSetIfChanged(ref _expression3b, value); }
        }
        public Expression? Expression3c
        {
            get { return _expression3c; }
            set { this.RaiseAndSetIfChanged(ref _expression3c, value); }
        }
        public Statement Statement3
        {
            get { return _statement3; }
            set { this.RaiseAndSetIfChanged(ref _statement3, value); }
        }
        public Declaration Declaration4
        {
            get { return _declaration4; }
            set { this.RaiseAndSetIfChanged(ref _declaration4, value); }
        }
        public Expression? Expression4a
        {
            get { return _expression4a; }
            set { this.RaiseAndSetIfChanged(ref _expression4a, value); }
        }
        public Expression? Expression4b
        {
            get { return _expression4b; }
            set { this.RaiseAndSetIfChanged(ref _expression4b, value); }
        }
        public Statement Statement4
        {
            get { return _statement4; }
            set { this.RaiseAndSetIfChanged(ref _statement4, value); }
        }

        public IterationStatement()
        {
            this.Declaration4 = new Declaration();
            this.Expression1 = new Expression();
            this.Expression2 = new Expression();
            this.Expression3a = new Expression();
            this.Expression3b = new Expression();
            this.Expression3c = new Expression();
            this.Expression4a = new Expression();
            this.Expression4b = new Expression();
            this.Statement1 = new Statement();
            this.Statement2 = new Statement();
            this.Statement3 = new Statement();
            this.Statement4 = new Statement();
        }
    }
}
