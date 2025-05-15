using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "c-char (base)",
             Description = "c-char: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public abstract class CChar : GrammarBase
    {
        public CChar(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "c-char (variant 1)",
             Description = "c-char: any member of the source character set except the single-quote ', backslash \\, or new-line character",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CChar_V1 : CChar
    {
        public CChar_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "c-char (variant 2)",
             Description = "c-char: escape-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class CChar_V2 : CChar
    {
        EscapeSequence EscapeSequence;

        public CChar_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
