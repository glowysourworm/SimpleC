using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "pp-tokens (base)",
             Description = "pp-tokens: (2 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class PreprocessingTokens : GrammarBase
    {
        public PreprocessingTokens(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-tokens (variant 1)",
             Description = "pp-tokens: preprocessing-token",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class PreprocessingTokens_V1 : PreprocessingTokens
    {
        PreprocessingToken PreprocessingToken;

        public PreprocessingTokens_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-tokens (variant 2)",
             Description = "pp-tokens: pp-tokens preprocessing-token",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class PreprocessingTokens_V2 : PreprocessingTokens
    {
        PreprocessingTokens PreprocessingTokens;
        PreprocessingToken PreprocessingToken;

        public PreprocessingTokens_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
