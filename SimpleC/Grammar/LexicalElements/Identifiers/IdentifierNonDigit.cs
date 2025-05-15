using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.UniversalCharacter;

namespace SimpleC.Grammar.LexicalElements.Identifiers
{
    [Grammar(Name = "identifier-nondigit (base)",
             Description = "(base) identifier-nondigit: (3 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public abstract class IdentifierNonDigit : GrammarBase
    {
        public IdentifierNonDigit(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "identifier-nondigit (variant 1)",
             Description = "identifier-nondigit: nondigit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class IdentifierNonDigit_V1 : IdentifierNonDigit
    {
        NonDigit NonDigit;

        public IdentifierNonDigit_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "identifier-nondigit (variant 2)",
             Description = "identifier-nondigit: universal-character-name",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class IdentifierNonDigit_V2 : IdentifierNonDigit
    {
        UniversalCharacterName UniversalCharacterName;

        public IdentifierNonDigit_V2(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "identifier-nondigit (variant 3)",
             Description = "identifier-nondigit: other implementation-defined characters",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class IdentifierNonDigit_V3 : IdentifierNonDigit
    {
        // ??? TODO ???

        public IdentifierNonDigit_V3(CodeRefBase codeRef) : base(codeRef) { }
    }
}
