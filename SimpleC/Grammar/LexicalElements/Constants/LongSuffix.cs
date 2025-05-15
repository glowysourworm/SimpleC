using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "long-suffix",
             Description = "long-suffix: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class LongSuffix : GrammarConstant
    {
        // ONE OF:  l L
        public LongSuffix(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
