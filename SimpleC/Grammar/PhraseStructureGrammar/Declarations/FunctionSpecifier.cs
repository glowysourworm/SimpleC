using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "function-specifier",
             Description = "function-specifier: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_4)]
    public class FunctionSpecifier : GrammarBase
    {
        // One of: inline
        public FunctionSpecifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
