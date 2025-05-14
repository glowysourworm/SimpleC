using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class JumpStatement : Statement
    {
        public const string GotoStatement1 = GrammarCKeywords.Keyword_goto;
        Identifier _identifier1;
        public const char SemicolonSeparator1 = GrammarCConstants.Semicolon;

        public const string ContinueStatement2 = GrammarCKeywords.Keyword_continue;
        public const char SemicolonSeparator2 = GrammarCConstants.Semicolon;

        public const string BreakStatement3 = GrammarCKeywords.Keyword_break;
        public const char SemicolonSeparator3 = GrammarCConstants.Semicolon;

        public const string ReturnStatement4 = GrammarCKeywords.Keyword_return;
        Expression? _expression4;
        public const char SemicolonSeparator4 = GrammarCConstants.Semicolon;

        public Identifier Identifier1
        {
            get { return _identifier1; }
            set { this.RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public Expression? Expression4
        {
            get { return _expression4; }
            set { this.RaiseAndSetIfChanged(ref _expression4, value); }
        }

        public JumpStatement()
        {
            this.Identifier1 = new Identifier();
            this.Expression4 = null;
        }
    }
}
