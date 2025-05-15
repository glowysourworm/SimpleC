using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    [Grammar(Name = "declaration-list (base)",
             Description = "declaration-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9_1)]
    public abstract class DeclarationList : GrammarBase
    {
        protected DeclarationList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-list (variant 1)",
             Description = "declaration-list: declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9_1)]
    public class DeclarationList_V1 : DeclarationList
    {
        Declaration Declaration;

        public DeclarationList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-list (variant 2)",
             Description = "declaration-list: declaration-list declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9_1)]
    public class DeclarationList_V2 : DeclarationList
    {
        DeclarationList DeclarationList;
        Declaration Declaration;

        public DeclarationList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
