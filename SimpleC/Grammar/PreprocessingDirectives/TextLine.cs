using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "text-line",
             Description = "text-line: pp-tokens_opt new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class TextLine : GrammarBase
    {
        public PreprocessingTokens? PreprocessingTokens;
        public NewLine NewLine;
     
        public TextLine(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
