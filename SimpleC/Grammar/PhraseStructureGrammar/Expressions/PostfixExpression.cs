using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class PostfixExpression : GrammarBase
    {
        // Primary expression, with a choice of postfix-expressions (recursively) (see A.2.1 -> 6.5.2)
        PrimaryExpression _primaryExpression;

        // Recursive postfix-expression
        PostfixExpression _postfixExpression1;
        PostfixExpression _postfixExpression2;
        PostfixExpression _postfixExpression3;
        PostfixExpression _postfixExpression4;
        PostfixExpression _postfixExpression5;
        PostfixExpression _postfixExpression6;

        public const char BracketSquareLeft1 = GrammarCConstants.BracketSquareLeft;
        Expression _expression1;
        public const char BracketSquareRight1 = GrammarCConstants.BracketSquareRight;

        public const char BracketLeft2 = GrammarCConstants.BracketLeft;
        ArgumentExpressionList? _argumentExpressionList2;
        public const char BracketRight2 = GrammarCConstants.BracketRight;

        public const char PeriodAfterPostfix3 = GrammarCConstants.Period;
        Identifier _identifier3;

        public const string ArrowAfterPostfix4 = GrammarCOperators.Arrow;
        Identifier _identifier4;

        public const string IncrementPostfix5 = GrammarCOperators.Increment;
        public const string DecrementPostfix6 = GrammarCOperators.Decrement;

        public const char LeftBracketOption1 = GrammarCConstants.BracketLeft;
        TypeName _typeNameOption1;
        public const char RightBracketOption1 = GrammarCConstants.BracketRight;

        public const char LeftBracketCurlyOption1InitializerList = GrammarCConstants.BracketCurlyLeft;
        InitializerList _initializerListOption1;
        public const char RightBracketCurlyOption1InitializerList = GrammarCConstants.BracketCurlyRight;

        public const char LeftBracketOption2 = GrammarCConstants.BracketLeft;
        TypeName _typeNameOption2;
        public const char RightBracketOption2 = GrammarCConstants.BracketRight;

        public const char LeftBracketCurlyOption2InitializerList = GrammarCConstants.BracketCurlyLeft;
        InitializerList _initializerListOption2;
        public const char RightBracketCurlyOption2InitializerList = GrammarCConstants.BracketCurlyRight;
        public const char InitilizerListOption2Comma = GrammarCConstants.Comma;

        public PrimaryExpression PrimaryExpression
        {
            get { return _primaryExpression; }
            set { this.RaiseAndSetIfChanged(ref _primaryExpression, value); }
        }
        public PostfixExpression PostfixExpression1
        {
            get { return _postfixExpression1; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression1, value); }
        }
        public PostfixExpression PostfixExpression2
        {
            get { return _postfixExpression2; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression2, value); }
        }
        public PostfixExpression PostfixExpression3
        {
            get { return _postfixExpression3; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression3, value); }
        }
        public PostfixExpression PostfixExpression4
        {
            get { return _postfixExpression4; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression4, value); }
        }
        public PostfixExpression PostfixExpression5
        {
            get { return _postfixExpression5; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression5, value); }
        }
        public PostfixExpression PostfixExpression6
        {
            get { return _postfixExpression6; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression6, value); }
        }
        public Expression Expression1
        {
            get { return _expression1; }
            set { this.RaiseAndSetIfChanged(ref _expression1, value); }
        }
        public ArgumentExpressionList? ArgumentExpressionList2
        {
            get { return _argumentExpressionList2; }
            set { this.RaiseAndSetIfChanged(ref _argumentExpressionList2, value); }
        }
        public Identifier Identifier3
        {
            get { return _identifier3; }
            set { this.RaiseAndSetIfChanged(ref _identifier3, value); }
        }
        public Identifier Identifier4
        {
            get { return _identifier4; }
            set { this.RaiseAndSetIfChanged(ref _identifier4, value); }
        }
        public TypeName TypeNameOption1
        {
            get { return _typeNameOption1; }
            set { this.RaiseAndSetIfChanged(ref _typeNameOption1, value); }
        }
        public InitializerList InitializerListOption1
        {
            get { return _initializerListOption1; }
            set { this.RaiseAndSetIfChanged(ref _initializerListOption1, value); }
        }
        public TypeName TypeNameOption2
        {
            get { return _typeNameOption2; }
            set { this.RaiseAndSetIfChanged(ref _typeNameOption2, value); }
        }
        public InitializerList InitializerListOption2
        {
            get { return _initializerListOption2; }
            set { this.RaiseAndSetIfChanged(ref _initializerListOption2, value); }
        }

        public PostfixExpression()
        {
            this.ArgumentExpressionList2 = new ArgumentExpressionList();
            this.Expression1 = new Expression();
            this.Identifier3 = new Identifier();
            this.Identifier4 = new Identifier();
            this.InitializerListOption1 = new InitializerList();
            this.InitializerListOption2 = new InitializerList();
            this.PostfixExpression1 = new PostfixExpression();
            this.PostfixExpression2 = new PostfixExpression();
            this.PostfixExpression3 = new PostfixExpression();
            this.PostfixExpression4 = new PostfixExpression();
            this.PostfixExpression5 = new PostfixExpression();
            this.PostfixExpression6 = new PostfixExpression();
            this.PrimaryExpression = new PrimaryExpression();
            this.TypeNameOption1 = new TypeName();
            this.TypeNameOption2 = new TypeName();
        }
    }
}
