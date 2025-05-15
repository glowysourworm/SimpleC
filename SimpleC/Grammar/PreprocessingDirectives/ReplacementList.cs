using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{

    [Grammar(Name = "replacement-list",
             Description = "replacement-list: pp-tokens_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ReplacementList : GrammarBase
    {
        public PreprocessingTokens? PreprocessingTokens;

        public ReplacementList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
