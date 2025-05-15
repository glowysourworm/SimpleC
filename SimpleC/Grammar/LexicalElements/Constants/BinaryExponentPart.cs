using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "binary-exponent-part (base)",
             Description = "binary-exponent-part: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class BinaryExponentPart : GrammarBase
    {
        protected BinaryExponentPart(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "binary-exponent-part (variant 1)",
             Description = "binary-exponent-part: p sign_opt digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class BinaryExponentPart_V1 : BinaryExponentPart
    {
        public const char PrefixLowerCase = GrammarCConstants.Letter_p;
        public Sign? Sign;
        public DigitSequence DigitSequence;

        public BinaryExponentPart_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "binary-exponent-part (variant 2)",
             Description = "binary-exponent-part: P sign_opt digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class BinaryExponentPart_V2 : BinaryExponentPart
    {
        public const char PrefixLowerCase = GrammarCConstants.Letter_P;
        public Sign? Sign;
        public DigitSequence DigitSequence;

        public BinaryExponentPart_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
