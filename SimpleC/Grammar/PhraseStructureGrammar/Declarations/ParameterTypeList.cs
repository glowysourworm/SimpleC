using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "parameter-type-list (base)",
             Description = "parameter-type-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class ParameterTypeList : GrammarBase
    {
        protected ParameterTypeList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-type-list (variant 1)",
             Description = "parameter-type-list: parameter-list",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterTypeList_V1 : ParameterTypeList
    {
        ParameterList ParameterList;

        public ParameterTypeList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-type-list (variant 2)",
             Description = "parameter-type-list: parameter-list , ...",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterTypeList_V2 : ParameterTypeList
    {
        ParameterList ParameterList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        public const string VariadicParameterPack = GrammarCOperators.VariadicParameterPack;

        public ParameterTypeList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
