using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "cast-expression (base)",
             Description = "cast-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_4)]
    public abstract class CastExpression : GrammarBase
    {
        protected CastExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "cast-expression (variant 1)",
             Description = "cast-expression: unary-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_4)]
    public class CastExpression_V1 : CastExpression
    {
        UnaryExpression UnaryExpression;

        public CastExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "cast-expression (variant 2)",
             Description = "cast-expression: ( type-name ) cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_4)]
    public class CastExpression_V2 : CastExpression
    {
        public const char TypeNameOpenBracket = GrammarCConstants.BracketLeft;
        TypeName TypeName;
        public const char TypeNameCloseBracket = GrammarCConstants.BracketRight;

        CastExpression CastExpression;

        public CastExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
