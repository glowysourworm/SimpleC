using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "identifier-list (base)",
             Description = "identifier-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class IdentifierList : GrammarBase
    {
        public IdentifierList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "identifier-list (variant 1)",
             Description = "identifier-list: identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class IdentifierList_V1 : IdentifierList
    {
        Identifier Identifier;

        public IdentifierList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "identifier-list (variant 2)",
             Description = "identifier-list: identifier-list , identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class IdentifierList_V2 : IdentifierList
    {
        IdentifierList IdentifierList;
        public static char CommaSeparator = GrammarCConstants.Comma;
        Identifier Identifier;

        public IdentifierList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
