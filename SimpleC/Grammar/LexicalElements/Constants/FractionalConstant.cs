using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "fractional-constant (base)",
             Description = "fractional-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class FractionalConstant : GrammarBase
    {
        public FractionalConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "fractional-constant (variant 1)",
             Description = "fractional-constant: digit-sequence_opt . digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class FractionalConstant_V1 : FractionalConstant
    {
        DigitSequence DigitSequence1;
        const char DotSeparator = GrammarCConstants.Period;
        DigitSequence DigitSequence2;

        public FractionalConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "fractional-constant (variant 2)",
             Description = "fractional-constant: digit-sequence .",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class FractionalConstant_V2 : FractionalConstant
    {
        DigitSequence DigitSequence;
        const char Dot = GrammarCConstants.Period;

        public FractionalConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
