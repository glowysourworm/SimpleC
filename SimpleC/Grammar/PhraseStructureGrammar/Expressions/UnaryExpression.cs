using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class UnaryExpression : GrammarConstant
    {
        PostfixExpression _postfixExpression1;

        public const string PrefixIncrement2 = GrammarCOperators.Increment;
        UnaryExpression _unaryExpression2;

        public const string PrefixDecrement3 = GrammarCOperators.Decrement;
        UnaryExpression _unaryExpression3;

        UnaryOperator _unaryOperator4;
        CastExpression _castExpression4;

        public const string PrefixSizeofKeyword5 = GrammarCKeywords.Keyword_sizeof;
        UnaryExpression _unaryExpression5;

        public const string PrefixSizeofKeyword6 = GrammarCKeywords.Keyword_sizeof;
        public const char BracketLeftOpen6 = GrammarCConstants.BracketLeft;
        TypeName _typeName6;
        public const char BracketRightClose6 = GrammarCConstants.BracketRight;

        public PostfixExpression PostfixExpression1
        {
            get { return _postfixExpression1; }
            set { this.RaiseAndSetIfChanged(ref _postfixExpression1, value); }
        }
        public UnaryExpression UnaryExpression2
        {
            get { return _unaryExpression2; }
            set { this.RaiseAndSetIfChanged(ref _unaryExpression2, value); }
        }
        public UnaryExpression UnaryExpression3
        {
            get { return _unaryExpression3; }
            set { this.RaiseAndSetIfChanged(ref _unaryExpression3, value); }
        }
        public UnaryOperator UnaryOperator4
        {
            get { return _unaryOperator4; }
            set { this.RaiseAndSetIfChanged(ref _unaryOperator4, value); }
        }
        public CastExpression CastExpression4
        {
            get { return _castExpression4; }
            set { this.RaiseAndSetIfChanged(ref _castExpression4, value); }
        }
        public UnaryExpression UnaryExpression5
        {
            get { return _unaryExpression5; }
            set { this.RaiseAndSetIfChanged(ref _unaryExpression5, value); }
        }
        public TypeName TypeName6
        {
            get { return _typeName6; }
            set { this.RaiseAndSetIfChanged(ref _typeName6, value); }
        }

        public UnaryExpression()
        {
            this.CastExpression4 = new CastExpression();
            this.PostfixExpression1 = new PostfixExpression();
            this.TypeName6 = new TypeName();
            this.UnaryExpression2 = new UnaryExpression();
            this.UnaryExpression3 = new UnaryExpression();
            this.UnaryExpression5 = new UnaryExpression();
            this.UnaryOperator4 = new UnaryOperator();
        }
    }
}
