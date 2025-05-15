using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "designator-list (base)",
             Description = "designator-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public abstract class DesignatorList : GrammarBase
    {
        protected DesignatorList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "designator-list (variant 1)",
             Description = "designator-list: designator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class DesignatorList_V1 : DesignatorList
    {
        Designator Designator;

        public DesignatorList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "designator-list (variant 2)",
             Description = "designator-list: designator-list designator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class DesignatorList_V2 : DesignatorList
    {
        DesignatorList DesignatorList;
        Designator Designator;

        public DesignatorList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
