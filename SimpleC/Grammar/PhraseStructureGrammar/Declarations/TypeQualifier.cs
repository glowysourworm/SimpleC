using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "type-qualifier",
             Description = "type-qualifier: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_3)]
    public class TypeQualifier : GrammarBase
    {
        // One of: const, restrict, volatile
        public TypeQualifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
