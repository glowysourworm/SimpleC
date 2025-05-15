using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "initializer-list (base)",
             Description = "initializer-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public abstract class InitializerList : GrammarBase
    {
        protected InitializerList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "initializer-list (variant 1)",
             Description = "initializer-list: designation_opt initializer",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class InitializerList_V1 : InitializerList
    {
        Designation? Designation;
        Initializer Initializer;

        public InitializerList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "initializer-list (variant 2)",
             Description = "initializer-list: initializer-list , designation_opt initializer",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class InitializerList_V2 : InitializerList
    {
        InitializerList InitializerList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        Designation? Designation;
        Initializer Initializer;

        public InitializerList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
