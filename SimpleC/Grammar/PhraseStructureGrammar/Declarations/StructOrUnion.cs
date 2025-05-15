using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "struct-or-union",
             Description = "struct-or-union: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructOrUnion : GrammarBase
    {
        Keyword Keyword;

        // One of:  struct, union
        public StructOrUnion(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
