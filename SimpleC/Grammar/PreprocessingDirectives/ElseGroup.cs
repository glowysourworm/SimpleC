using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "else-group",
             Description = "else-group: # else new-line group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ElseGroup : GrammarBase
    {
        public const char ElseGroupHashtag = GrammarCConstants.Hashtag;
        public const string ElseKeyword = GrammarCKeywords.Keyword_else;
        NewLine NewLine;
        Group? Group;

        public ElseGroup(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
