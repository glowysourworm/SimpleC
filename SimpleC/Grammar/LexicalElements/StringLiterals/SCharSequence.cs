using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    [Grammar(Name = "s-char-sequence (base)",
             Description = "s-char-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public abstract class SCharSequence : GrammarBase
    {
        protected SCharSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "s-char-sequence (variant 1)",
             Description = "s-char-sequence: s-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class SCharSequence_V1 : GrammarBase
    {
        SChar SChar;

        public SCharSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "s-char-sequence (variant 2)",
             Description = "s-char-sequence: s-char-sequence s-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class SCharSequence_V2 : GrammarBase
    {
        SCharSequence SCharSequence;
        SChar SChar;

        public SCharSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
