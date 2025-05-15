using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "parameter-list (base)",
             Description = "parameter-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class ParameterList : GrammarBase
    {
        protected ParameterList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-list (variant 1)",
             Description = "parameter-list: parameter-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterList_V1 : ParameterList
    {
        ParameterDeclaration ParameterDeclaration;

        public ParameterList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-list (variant 2)",
             Description = "parameter-list: parameter-list , parameter-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterList_V2 : ParameterList
    {
        ParameterList ParameterList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        ParameterDeclaration ParameterDeclaration;

        public ParameterList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
