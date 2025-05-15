using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "parameter-declaration (base)",
             Description = "parameter-declaration: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class ParameterDeclaration : GrammarBase
    {
        protected ParameterDeclaration(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-declaration (variant 1)",
             Description = "parameter-declaration: declaration-specifiers declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterDeclaration_V1 : ParameterDeclaration
    {
        DeclarationSpecifiers DeclarationSpecifiers;
        Declarator Declarator;

        public ParameterDeclaration_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "parameter-declaration (variant 2)",
             Description = "parameter-declaration: declaration-specifiers abstract-declarator_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class ParameterDeclaration_V2 : ParameterDeclaration
    {
        DeclarationSpecifiers DeclarationSpecifiers;
        AbstractDeclarator? AbstractDeclarator;

        public ParameterDeclaration_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
