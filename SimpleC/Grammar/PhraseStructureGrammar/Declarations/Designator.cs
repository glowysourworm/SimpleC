using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "designator (base)",
             Description = "designator: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public abstract class Designator : GrammarBase
    {
        protected Designator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "designator (variant 1)",
             Description = "designator: [ constant-expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Designator_V1 : Designator
    {
        public const char DesignatorBracketOpen = GrammarCConstants.BracketSquareLeft;
        ConstantExpression ConstantExpression;
        public const char DesignatorBracketClose = GrammarCConstants.BracketSquareRight;

        public Designator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "designator (variant 2)",
             Description = "designator: . identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Designator_V2 : Designator
    {
        public const char DesignatorPeriodPunctuator = GrammarCConstants.Period;
        Identifier Identifier;

        public Designator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
