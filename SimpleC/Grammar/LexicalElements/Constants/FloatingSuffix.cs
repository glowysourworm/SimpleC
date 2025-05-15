using SimpleC.Base.Exception;
using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "floating-suffix",
             Description = "floating-suffix: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class FloatingSuffix : GrammarConstant
    {
        // ONE OF: f l F L
        public FloatingSuffix(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
