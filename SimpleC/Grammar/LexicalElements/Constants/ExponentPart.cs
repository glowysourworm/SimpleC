using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "exponent-part (base)",
             Description = "exponent-part: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class ExponentPart : GrammarBase
    {
        public ExponentPart(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "exponent-part (variant 1)",
             Description = "exponent-part: e sign_opt digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class ExponentPart_V1 : ExponentPart
    {
        const char PrefixLowerCase = GrammarCConstants.Letter_e;
        Sign? Sign;
        DigitSequence DigitSequence;

        public ExponentPart_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "exponent-part (variant 2)",
             Description = "exponent-part: E sign_opt digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class ExponentPart_V2 : ExponentPart
    {
        const char PrefixUpperCase = GrammarCConstants.Letter_E;
        Sign? Sign;
        DigitSequence DigitSequence;

        public ExponentPart_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
