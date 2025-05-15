using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "unsigned-suffix",
             Description = "unsigned-suffix: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class UnsignedSuffix : GrammarConstant
    {
        // ONE OF: u U
        public UnsignedSuffix(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
