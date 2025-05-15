using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;

namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    [Grammar(Name = "s-char (base)",
             Description = "s-char: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public abstract class SChar : GrammarBase
    {
        protected SChar(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "s-char (variant 1)",
             Description = "s-char: any member of the source character set except the double-quote \", backslash \\, or new-line character",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class SChar_V1 : GrammarBase
    {
        public SChar_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "s-char (variant 2)",
             Description = "s-char: escape-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class SChar_V2 : GrammarBase
    {
        EscapeSequence EscapeSequence;

        public SChar_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
