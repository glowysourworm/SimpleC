using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "type-qualifier-list (base)",
             Description = "type-qualifier-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class TypeQualifierList : GrammarBase
    {
        protected TypeQualifierList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-qualifier-list (variant 1)",
             Description = "type-qualifier-list: type-qualifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class TypeQualifierList_V1 : TypeQualifierList
    {
        TypeQualifier TypeQualifier;

        public TypeQualifierList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-qualifier-list (variant 2)",
             Description = "type-qualifier-list: type-qualifier-list type-qualifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class TypeQualifierList_V2 : TypeQualifierList
    {
        TypeQualifierList TypeQualifierList;
        TypeQualifier TypeQualifier;

        public TypeQualifierList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
