using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "specifier-qualifier-list (base)",
             Description = "specifier-qualifier-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public abstract class SpecifierQualifierList : GrammarBase
    {
        public SpecifierQualifierList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "specifier-qualifier-list (variant 1)",
             Description = "specifier-qualifier-list: type-specifier specifier-qualifier-list_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class SpecifierQualifierList_V1 : SpecifierQualifierList
    {
        TypeSpecifier TypeSpecifier;
        SpecifierQualifierList? SpecifierQualifierList;

        public SpecifierQualifierList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "specifier-qualifier-list (variant 2)",
             Description = "specifier-qualifier-list: type-qualifier specifier-qualifier-list_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class SpecifierQualifierList_V2 : SpecifierQualifierList
    {
        TypeQualifier TypeQualifier;
        SpecifierQualifierList? SpecifierQualifierList;

        public SpecifierQualifierList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
