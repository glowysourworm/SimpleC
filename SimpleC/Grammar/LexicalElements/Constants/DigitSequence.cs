using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "digit-sequence (base)",
             Description = "digit-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class DigitSequence : GrammarBase
    {
        protected DigitSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "digit-sequence (variant 1)",
             Description = "digit-sequence: digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class DigitSequence_V1 : DigitSequence
    {
        public Digit Digit;

        public DigitSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "digit-sequence (variant 2)",
             Description = "digit-sequence: digit-sequence digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class DigitSequence_V2 : DigitSequence
    {
        public DigitSequence DigitSequence;
        public Digit Digit;

        public DigitSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
