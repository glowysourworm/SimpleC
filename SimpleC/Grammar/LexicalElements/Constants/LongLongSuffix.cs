using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "long-long-suffix",
             Description = "long-long-suffix: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class LongLongSuffix : GrammarConstant
    {
        // ONE OF: ll LL
        public LongLongSuffix(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
