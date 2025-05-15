using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "enumeration-constant",
             Description = "enumeration-constant: identifier",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_3)]
    public class EnumerationConstant : GrammarBase
    {
        public Identifier Identifier;

        public EnumerationConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
