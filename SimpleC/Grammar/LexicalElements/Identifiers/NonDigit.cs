using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Identifiers
{
    [Grammar(Name = "nondigit",
             Description = "nondigit: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_2_1)]
    public class NonDigit : GrammarConstant
    {
        public NonDigit(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
