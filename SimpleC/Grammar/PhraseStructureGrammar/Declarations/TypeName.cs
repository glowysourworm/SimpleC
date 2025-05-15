using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "type-name",
             Description = "type-name: specifier-qualifier-list abstract-declarator_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class TypeName : GrammarBase
    {
        SpecifierQualifierList SpecifierQualifierList;
        AbstractDeclarator? AbstractDeclarator;

        public TypeName(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
