using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "struct-declaration",
             Description = "struct-declaration: specifier-qualifier-list struct-declarator-list ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclaration : GrammarBase
    {
        SpecifierQualifierList SpecifierQualifierList;
        StructDeclaratorList StructDeclaratorList;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public StructDeclaration(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
