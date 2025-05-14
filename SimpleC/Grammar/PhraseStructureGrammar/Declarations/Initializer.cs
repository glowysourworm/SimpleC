using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Initializer : GrammarBase
    {
        AssignmentExpression _assignmentExpression1;

        public const char InitializerListBracketOpen2 = GrammarCConstants.BracketCurlyLeft;
        InitializerList _initializerList2;
        public const char InitializerListBracketClose2 = GrammarCConstants.BracketCurlyRight;

        public const char InitializerListBracketOpen3 = GrammarCConstants.BracketCurlyLeft;
        InitializerList _initializerList3;
        public const char InitializerListCommaSeparator3 = GrammarCConstants.Comma;
        public const char InitializerListBracketClose3 = GrammarCConstants.BracketCurlyRight;

        public AssignmentExpression AssignmentExpression1
        {
            get { return _assignmentExpression1; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression1, value); }
        }
        public InitializerList InitializerList2
        {
            get { return _initializerList2; }
            set { this.RaiseAndSetIfChanged(ref _initializerList2, value); }
        }
        public InitializerList InitializerList3
        {
            get { return _initializerList3; }
            set { this.RaiseAndSetIfChanged(ref _initializerList3, value); }
        }

        public Initializer()
        {
            this.InitializerList2 = new InitializerList();
            this.InitializerList3 = new InitializerList();
            this.AssignmentExpression1 = new AssignmentExpression();
        }
    }
}
