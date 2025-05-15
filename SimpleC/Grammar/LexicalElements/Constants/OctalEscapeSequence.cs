using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "octal-escape-sequence (base)",
             Description = "octal-escape-sequence: (3 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public abstract class OctalEscapeSequence : GrammarBase
    {
        public const char BackslashPrefix = GrammarCConstants.Backslash;
        OctalDigit _octalDigit1;

        protected OctalEscapeSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "octal-escape-sequence (variant 1)",
             Description = "octal-escape-sequence: \\ octal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class OctalEscapeSequence_V1 : GrammarBase
    {
        public const char BackslashPrefix = GrammarCConstants.Backslash;
        OctalDigit OctalDigit;

        protected OctalEscapeSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "octal-escape-sequence (variant 2)",
             Description = "octal-escape-sequence: \\ octal-digit octal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class OctalEscapeSequence_V2 : GrammarBase
    {
        public const char BackslashPrefix = GrammarCConstants.Backslash;
        OctalDigit OctalDigit1;
        OctalDigit OctalDigit2;

        protected OctalEscapeSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "octal-escape-sequence (variant 3)",
             Description = "octal-escape-sequence: \\ octal-digit octal-digit octal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class OctalEscapeSequence_V3 : GrammarBase
    {
        public const char BackslashPrefix = GrammarCConstants.Backslash;
        OctalDigit OctalDigit1;
        OctalDigit OctalDigit2;
        OctalDigit OctalDigit3;

        protected OctalEscapeSequence_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
