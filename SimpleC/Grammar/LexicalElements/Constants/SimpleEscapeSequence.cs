using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "simple-escape-sequence",
             Description = "simple-escape-sequence: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class SimpleEscapeSequence : GrammarConstant
    {
        // ONE OF:  \' \" \? \\ \a \b \f \n \r \t \v
        public SimpleEscapeSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
