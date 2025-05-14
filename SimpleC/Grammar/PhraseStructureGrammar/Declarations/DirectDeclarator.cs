using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class DirectDeclarator : GrammarBase
    {
        Identifier _identifier1;

        public const char DeclaratorBracketOpen2 = GrammarCConstants.BracketLeft;
        Declarator _declarator2;
        public const char DeclaratorBracketClose2 = GrammarCConstants.BracketRight;

        DirectDeclarator _directDeclarator3;
        public const char DeclaratorBracketSquareOpen3 = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? _typeQualifierList3;
        AssignmentExpression? _assignmentExpression3;
        public const char DeclaratorBracketSquareClose3 = GrammarCConstants.BracketSquareRight;

        DirectDeclarator _directDeclarator4;
        public const char DeclaratorBracketSquareOpen4 = GrammarCConstants.BracketSquareLeft;
        public const string StaticStorageClassSpecifier4 = GrammarCKeywords.Keyword_static;
        TypeQualifierList? _typeQualifierList4;
        AssignmentExpression? _assignmentExpression4;
        public const char DeclaratorBracketSquareClose4 = GrammarCConstants.BracketSquareRight;

        DirectDeclarator _directDeclarator5;
        public const char DeclaratorBracketSquareOpen5 = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList _typeQualifierList5;
        public const string StaticStorageClassSpecifier5 = GrammarCKeywords.Keyword_static;
        AssignmentExpression _assignmentExpression5;
        public const char DeclaratorBracketSquareClose5 = GrammarCConstants.BracketSquareRight;

        DirectDeclarator _directDeclarator6;
        public const char DeclaratorBracketSquareOpen6 = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? _typeQualifierList6;
        public const char PointerSpecifier6 = GrammarCConstants.Asterix;
        public const char DeclaratorBracketSquareClose6 = GrammarCConstants.BracketSquareRight;

        DirectDeclarator _directDeclarator7;
        public const char DeclaratorBracketOpen7 = GrammarCConstants.BracketLeft;
        ParameterTypeList _parameterTypeList7;
        public const char DeclaratorBracketClose7 = GrammarCConstants.BracketRight;

        DirectDeclarator _directDeclarator8;
        public const char DeclaratorBracketOpen8 = GrammarCConstants.BracketLeft;
        IdentifierList? _identifierList8;
        public const char DeclaratorBracketClose8 = GrammarCConstants.BracketRight;

        public Identifier Identifier1
        {
            get { return _identifier1; }
            set { this.RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public Declarator Declarator2
        {
            get { return _declarator2; }
            set { this.RaiseAndSetIfChanged(ref _declarator2, value); }
        }
        public DirectDeclarator DirectDeclarator3
        {
            get { return _directDeclarator3; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator3, value); }
        }
        public TypeQualifierList? TypeQualifierList3
        {
            get { return _typeQualifierList3; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList3, value); }
        }
        public AssignmentExpression? AssignmentExpression3
        {
            get { return _assignmentExpression3; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression3, value); }
        }
        public DirectDeclarator DirectDeclarator4
        {
            get { return _directDeclarator4; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator4, value); }
        }
        public TypeQualifierList? TypeQualifierList4
        {
            get { return _typeQualifierList4; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList4, value); }
        }
        public AssignmentExpression? AssignmentExpression4
        {
            get { return _assignmentExpression4; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression4, value); }
        }
        public DirectDeclarator DirectDeclarator5
        {
            get { return _directDeclarator5; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator5, value); }
        }
        public TypeQualifierList TypeQualifierList5
        {
            get { return _typeQualifierList5; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList5, value); }
        }
        public AssignmentExpression AssignmentExpression5
        {
            get { return _assignmentExpression5; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression5, value); }
        }
        public DirectDeclarator DirectDeclarator6
        {
            get { return _directDeclarator6; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator6, value); }
        }
        public TypeQualifierList? TypeQualifierList6
        {
            get { return _typeQualifierList6; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList6, value); }
        }
        public DirectDeclarator DirectDeclarator7
        {
            get { return _directDeclarator7; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator7, value); }
        }
        public ParameterTypeList ParameterTypeList7
        {
            get { return _parameterTypeList7; }
            set { this.RaiseAndSetIfChanged(ref _parameterTypeList7, value); }
        }
        public DirectDeclarator DirectDeclarator8
        {
            get { return _directDeclarator8; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator8, value); }
        }
        public IdentifierList? IdentifierList8
        {
            get { return _identifierList8; }
            set { this.RaiseAndSetIfChanged(ref _identifierList8, value); }
        }

        public DirectDeclarator()
        {
            this.AssignmentExpression3 = null;
            this.AssignmentExpression4 = null;
            this.AssignmentExpression5 = new AssignmentExpression();
            this.Declarator2 = new Declarator();
            this.DirectDeclarator3 = new DirectDeclarator();
            this.DirectDeclarator4 = new DirectDeclarator();    
            this.DirectDeclarator5 = new DirectDeclarator();
            this.DirectDeclarator6 = new DirectDeclarator();
            this.DirectDeclarator7 = new DirectDeclarator();
            this.DirectDeclarator8 = new DirectDeclarator();
            this.Identifier1 = new Identifier();
            this.IdentifierList8 = new IdentifierList();
            this.ParameterTypeList7 = new ParameterTypeList();
            this.TypeQualifierList3 = new TypeQualifierList();
            this.TypeQualifierList4 = new TypeQualifierList();
            this.TypeQualifierList5 = new TypeQualifierList();
            this.TypeQualifierList6 = new TypeQualifierList();
        }
    }
}
