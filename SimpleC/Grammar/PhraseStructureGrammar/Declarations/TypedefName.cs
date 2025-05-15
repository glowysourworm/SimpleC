using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "typedef-name",
             Description = "typedef-name: identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_7)]
    public class TypedefName : GrammarBase
    {
        Identifier Identifier;

        public TypedefName(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
