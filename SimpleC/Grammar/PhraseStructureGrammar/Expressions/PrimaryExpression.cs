using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "primary-expression (base)",
             Description = "primary-expression: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_1)]
    public abstract class PrimaryExpression : GrammarBase
    {
        protected PrimaryExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "primary-expression (variant 1)",
             Description = "primary-expression: identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_1)]
    public class PrimaryExpression_V1 : GrammarBase
    {
        Identifier Identifier;

        public PrimaryExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "primary-expression (variant 2)",
             Description = "primary-expression: constant",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_1)]
    public class PrimaryExpression_V2 : GrammarBase
    {
        Constant Constant;

        protected PrimaryExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "primary-expression (variant 3)",
             Description = "primary-expression: string-literal",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_1)]
    public class PrimaryExpression_V3 : GrammarBase
    {
        StringLiteral StringLiteral;

        protected PrimaryExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "primary-expression (variant 4)",
             Description = "primary-expression: ( expression )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_1)]
    public class PrimaryExpression_V4 : GrammarBase
    {
        public const char OpenBracket = GrammarCConstants.BracketLeft;
        public Expression Expression;
        public const char CloseBracket = GrammarCConstants.BracketRight;

        protected PrimaryExpression_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
