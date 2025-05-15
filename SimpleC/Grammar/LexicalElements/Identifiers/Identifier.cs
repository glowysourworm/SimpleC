using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Identifiers
{
    [Grammar(Name = "identifier (base)",
             Description = "(base) identifier: (3 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public abstract class Identifier : GrammarBase
    {
        public Identifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "identifier (variant 1)",
             Description = "identifier: identifier-nondigit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class Identifier_V1 : Identifier
    {
        public IdentifierNonDigit IdentifierNonDigit;

        public Identifier_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "identifier (variant 2)",
             Description = "identifier: identifier identifier-nondigit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class Identifier_V2 : Identifier
    {
        public Identifier Identifier;
        public IdentifierNonDigit IdentifierNonDigit;

        public Identifier_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "identifier (variant 3)",
             Description = "identifier: identifier digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class Identifier_V3 : Identifier
    {
        public Identifier Identifier;
        public Digit Digit;

        public Identifier_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
