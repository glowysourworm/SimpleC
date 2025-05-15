using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "struct-declaration-list (base)",
             Description = "struct-declaration-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public abstract class StructDeclarationList : GrammarBase
    {
        protected StructDeclarationList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-declaration-list (variant 1)",
             Description = "struct-declaration-list: struct-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclarationList_V1 : StructDeclarationList
    {
        StructDeclaration StructDeclaration;

        public StructDeclarationList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-declaration-list (variant 2)",
             Description = "struct-declaration-list: struct-declaration-list struct-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclarationList_V2 : StructDeclarationList
    {
        StructDeclarationList StructDeclarationList;
        StructDeclaration StructDeclaration;

        public StructDeclarationList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
