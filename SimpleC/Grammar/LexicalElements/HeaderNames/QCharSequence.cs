using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    [Grammar(Name = "q-char-sequence (base)",
             Description = "q-char-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public abstract class QCharSequence : GrammarBase
    {
        protected QCharSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "q-char-sequence (variant 1)",
             Description = "q-char-sequence: q-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public class QCharSequence_V1 : GrammarBase
    {
        QChar QChar;

        public QCharSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "q-char-sequence (variant 2)",
             Description = "q-char-sequence: q-char-sequence q-char",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public class QCharSequence_V2 : GrammarBase
    {
        QCharSequence QCharSequence;
        QChar QChar;

        public QCharSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
