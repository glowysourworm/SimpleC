using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "c-char-sequence (base)",
             Description = "c-char-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public abstract class CCharSequence : GrammarBase
    {
        protected CCharSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "c-char-sequence (variant 1)",
             Description = "c-char-sequence: c-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CCharSequence_V1 : CCharSequence
    {
        CChar CChar;

        protected CCharSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "c-char-sequence (variant 2)",
             Description = "c-char-sequence: c-char-sequence c-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CCharSequence_V2 : CCharSequence
    {
        CCharSequence CCharSequence;
        CChar CChar;

        protected CCharSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
