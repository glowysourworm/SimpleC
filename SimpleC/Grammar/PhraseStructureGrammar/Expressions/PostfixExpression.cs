using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "postfix-expression (base)",
             Description = "postfix-expression: (9 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public abstract class PostfixExpression : GrammarBase
    {
        protected PostfixExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 1)",
             Description = "postfix-expression: primary-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V1 : PostfixExpression
    {
        public PrimaryExpression PrimaryExpression;

        public PostfixExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 2)",
             Description = "postfix-expression: postfix-expression [ expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V2 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;

        public const char ExpressionOpenBracket = GrammarCConstants.BracketSquareLeft;
        public Expression Expression;
        public const char ExpressionCloseBracket = GrammarCConstants.BracketSquareRight;

        public PostfixExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 3)",
             Description = "postfix-expression: postfix-expression ( argument-expression-list_opt )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V3 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;

        public const char ExpressionOpenBracket = GrammarCConstants.BracketLeft;
        public ArgumentExpressionList? ArgumentExpressionList;
        public const char ExpressionCloseBracket = GrammarCConstants.BracketRight;

        public PostfixExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 4)",
             Description = "postfix-expression: postfix-expression . identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V4 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;
        public const char PeriodPunctuator = GrammarCConstants.Period;
        public Identifier Identifier;

        public PostfixExpression_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 5)",
             Description = "postfix-expression: postfix-expression -> identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V5 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;
        public const string ArrowOperator = GrammarCOperators.Arrow;
        public Identifier Identifier;

        public PostfixExpression_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 6)",
             Description = "postfix-expression: postfix-expression ++",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V6 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;
        public const string IncrementOperator = GrammarCOperators.Increment;

        public PostfixExpression_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 7)",
             Description = "postfix-expression: postfix-expression --",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V7 : PostfixExpression
    {
        public PostfixExpression PostfixExpression;
        public const string DecrementOperator = GrammarCOperators.Increment;

        public PostfixExpression_V7(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 8)",
             Description = "postfix-expression: ( type-name ) { initializer-list }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V8 : PostfixExpression
    {
        public const char TypeNameOpenBracket = GrammarCConstants.BracketLeft;
        public TypeName TypeName;
        public const char TypeNameCloseBracket = GrammarCConstants.BracketRight;

        public const char InitializerListOpenBracket = GrammarCConstants.BracketCurlyLeft;
        public InitializerList InitializerList;
        public const char InitializerListCloseBracket = GrammarCConstants.BracketCurlyRight;

        public PostfixExpression_V8(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "postfix-expression (variant 9)",
             Description = "postfix-expression: ( type-name ) { initializer-list , }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class PostfixExpression_V9 : PostfixExpression
    {
        public const char TypeNameOpenBracket = GrammarCConstants.BracketLeft;
        public TypeName TypeName;
        public const char TypeNameCloseBracket = GrammarCConstants.BracketRight;

        public const char InitializerListOpenBracket = GrammarCConstants.BracketCurlyLeft;
        public InitializerList InitializerList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        public const char InitializerListCloseBracket = GrammarCConstants.BracketCurlyRight;

        public PostfixExpression_V9(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
