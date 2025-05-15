using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "init-declarator-list (base)",
             Description = "init-declarator-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public abstract class InitDeclaratorList : GrammarBase
    {
        protected InitDeclaratorList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "init-declarator-list (variant 1)",
             Description = "init-declarator-list: init-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class InitDeclaratorList_V1 : InitDeclaratorList
    {
        InitDeclarator InitDeclarator;

        public InitDeclaratorList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "init-declarator-list (variant 2)",
             Description = "init-declarator-list: init-declarator-list , init-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class InitDeclaratorList_V2 : InitDeclaratorList
    {
        InitDeclaratorList InitDeclaratorList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        InitDeclarator InitDeclarator;

        public InitDeclaratorList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
