using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "lparen",
             Description = "lparen: a ( character not immediately preceded by white-space",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class LParen : GrammarBase
    {
        public const char LeftParen = GrammarCConstants.BracketLeft;

        public LParen(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
