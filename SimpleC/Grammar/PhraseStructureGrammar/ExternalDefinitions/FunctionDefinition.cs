using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;
using SimpleC.Grammar.PhraseStructureGrammar.Statements;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    [Grammar(Name = "function-definition",
             Description = "function-definition: declaration-specifiers declarator declaration-list_opt compound-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9_1)]
    public class FunctionDefinition : GrammarBase
    {
        DeclarationSpecifiers DeclarationSpecifiers;
        Declarator Declarator;
        DeclarationList? DeclarationList;
        CompoundStatement CompoundStatement;

        public FunctionDefinition(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
