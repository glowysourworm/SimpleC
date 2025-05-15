using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "endif-line",
             Description = "endif-line: # endif new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class EndifLine : GrammarBase
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string EndifKeyword = GrammarCKeywords.Keyword_endif;
        NewLine NewLine;

        public EndifLine(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
