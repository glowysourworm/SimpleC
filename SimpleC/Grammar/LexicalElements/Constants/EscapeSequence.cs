using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.UniversalCharacter;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "escape-sequence (base)",
             Description = "escape-sequence: (4 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public abstract class EscapeSequence : GrammarBase
    {
        protected EscapeSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "escape-sequence (variant 1)",
         Description = "escape-sequence: simple-escape-sequence",
         Section = ISOCStandardAnnexSection.A_1,
         SubSection = ISOCStandardAnnexSubSection.A_1_5,
         SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class EscapeSequence_V1 : EscapeSequence
    {
        SimpleEscapeSequence SimpleEscapeSequence;

        public EscapeSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "escape-sequence (variant 2)",
             Description = "escape-sequence: octal-escape-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class EscapeSequence_V2 : EscapeSequence
    {
        OctalEscapeSequence OctalEscapeSequence;

        public EscapeSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "escape-sequence (variant 3)",
             Description = "escape-sequence: hexadecimal-escape-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class EscapeSequence_V3 : EscapeSequence
    {
        HexadecimalEscapeSequence HexadecimalEscapeSequence;

        public EscapeSequence_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "escape-sequence (variant 4)",
             Description = "escape-sequence: universal-character-name",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class EscapeSequence_V4 : EscapeSequence
    {
        UniversalCharacterName UniversalCharacterName;

        public EscapeSequence_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
