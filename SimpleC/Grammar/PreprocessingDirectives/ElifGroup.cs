using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "elif-group",
             Description = "elif-group: # elif constant-expression new-line group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ElifGroup : GrammarBase
    {
        public const char ElifGroupHashtag = GrammarCConstants.Hashtag;
        public const string ElifKeyword = GrammarCKeywords.Keyword_elif;
        ConstantExpression ConstantExpression;
        NewLine NewLine;
        Group? Group;

        public ElifGroup(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
