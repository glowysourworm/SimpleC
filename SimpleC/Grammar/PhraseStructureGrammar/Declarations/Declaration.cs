using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "declaration",
             Description = "declaration: declaration-specifiers init-declarator-list_opt ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class Declaration : GrammarBase
    {
        DeclarationSpecifiers DeclarationSpecifiers;
        InitDeclaratorList? InitDeclaratorList;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public Declaration(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
