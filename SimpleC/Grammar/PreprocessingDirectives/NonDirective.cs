using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "non-directive",
             Description = "non-directive: pp-tokens new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class NonDirective : GrammarBase
    {
        public PreprocessingTokens PreprocessingTokens;
        public NewLine NewLine;

        public NonDirective(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
