using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    [Grammar(Name = "h-char-sequence (base)",
             Description = "h-char-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public abstract class HCharSequence : GrammarBase
    {
        protected HCharSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "h-char-sequence (variant 1)",
             Description = "h-char-sequence: h-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public class HCharSequence_V1 : HCharSequence
    {
        HChar HChar;

        public HCharSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "h-char-sequence (variant 2)",
             Description = "h-char-sequence: h-char-sequence h-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public class HCharSequence_V2 : HCharSequence
    {
        HCharSequence HCharSequence;
        HChar HChar;

        public HCharSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
