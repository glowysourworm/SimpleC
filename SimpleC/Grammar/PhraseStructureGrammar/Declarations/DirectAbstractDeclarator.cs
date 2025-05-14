using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class DirectAbstractDeclarator : GrammarBase
    {
        public const char AbstractDeclaratorBracketOpen1 = GrammarCConstants.BracketLeft;
        AbstractDeclarator _abstractDeclarator1;
        public const char AbstractDeclaratorBracketClose1 = GrammarCConstants.BracketRight;

        DirectAbstractDeclarator? _directAbstractDeclarator2;
        public const char DeclaratorBracketOpen2 = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? _typeQualifierList2;
        AssignmentExpression? _assignmentExpression2;
        public const char DeclaratorBracketClose2 = GrammarCConstants.BracketSquareRight;

        DirectAbstractDeclarator? _directAbstractDeclarator3;
        public const char DeclaratorBracketOpen3 = GrammarCConstants.BracketSquareLeft;
        public const string StaticStorageClassSpecifier3 = GrammarCKeywords.Keyword_static;
        TypeQualifierList? _typeQualifierList3;
        AssignmentExpression _assignmentExpression3;
        public const char DeclaratorBracketClose3 = GrammarCConstants.BracketSquareRight;

        DirectAbstractDeclarator? _directAbstractDeclarator4;
        public const char DeclaratorBracketOpen4 = GrammarCConstants.BracketSquareLeft;
        public const char PointerOperator4 = GrammarCConstants.Asterix;
        public const char DeclaratorBracketClose4 = GrammarCConstants.BracketSquareRight;

        DirectAbstractDeclarator? _directAbstractDeclarator5;
        public const char DeclaratorBracketOpen5 = GrammarCConstants.BracketLeft;
        ParameterTypeList? _parameterTypeList5;
        public const char DeclaratorBracketClose5 = GrammarCConstants.BracketRight;

        public AbstractDeclarator AbstractDeclarator1
        {
            get { return _abstractDeclarator1; }
            set { this.RaiseAndSetIfChanged(ref _abstractDeclarator1, value); }
        }
        public DirectAbstractDeclarator? DirectAbstractDeclarator2
        {
            get { return _directAbstractDeclarator2; }
            set { this.RaiseAndSetIfChanged(ref _directAbstractDeclarator2, value); }
        }
        public TypeQualifierList? TypeQualifierList2
        {
            get { return _typeQualifierList2; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList2, value); }
        }
        public AssignmentExpression? AssignmentExpression2
        {
            get { return _assignmentExpression2; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression2, value); }
        }
        public DirectAbstractDeclarator? DirectAbstractDeclarator3
        {
            get { return _directAbstractDeclarator3; }
            set { this.RaiseAndSetIfChanged(ref _directAbstractDeclarator3, value); }
        }
        public TypeQualifierList? TypeQualifierList3
        {
            get { return _typeQualifierList3; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList3, value); }
        }
        public AssignmentExpression AssignmentExpression3
        {
            get { return _assignmentExpression3; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression3, value); }
        }
        public DirectAbstractDeclarator? DirectAbstractDeclarator4
        {
            get { return _directAbstractDeclarator4; }
            set { this.RaiseAndSetIfChanged(ref _directAbstractDeclarator4, value); }
        }
        public DirectAbstractDeclarator? DirectAbstractDeclarator5
        {
            get { return _directAbstractDeclarator5; }
            set { this.RaiseAndSetIfChanged(ref _directAbstractDeclarator5, value); }
        }
        public ParameterTypeList? ParameterTypeList5
        {
            get { return _parameterTypeList5; }
            set { this.RaiseAndSetIfChanged(ref _parameterTypeList5, value); }
        }

        public DirectAbstractDeclarator()
        {
            this.AbstractDeclarator1 = new AbstractDeclarator();
            this.AssignmentExpression2 = null;
            this.AssignmentExpression3 = new AssignmentExpression();
            this.DirectAbstractDeclarator2 = null;
            this.DirectAbstractDeclarator3 = null;
            this.DirectAbstractDeclarator4 = null;
            this.DirectAbstractDeclarator5 = null;
            this.TypeQualifierList2 = null;
            this.TypeQualifierList3 = null;
        }
    }
}
