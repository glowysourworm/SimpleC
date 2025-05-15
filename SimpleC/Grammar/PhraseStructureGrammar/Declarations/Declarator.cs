using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "declarator",
             Description = "declarator: pointer_opt direct-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class Declarator : GrammarBase
    {
        Pointer? Pointer;
        DirectDeclarator DirectDeclarator;

        public Declarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
