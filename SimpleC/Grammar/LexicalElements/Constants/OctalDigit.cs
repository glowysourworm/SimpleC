using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "octal-digit",
             Description = "octal-digit: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class OctalDigit : GrammarConstant
    {
        // ONE OF:  0 1 2 3 4 5 6 7
        public OctalDigit(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
