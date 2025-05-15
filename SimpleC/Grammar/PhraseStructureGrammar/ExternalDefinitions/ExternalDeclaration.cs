using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    [Grammar(Name = "external-declaration (base)",
             Description = "external-declaration: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public abstract class ExternalDeclaration : GrammarBase
    {
        protected ExternalDeclaration(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "external-declaration (variant 1)",
             Description = "external-declaration: function-definition",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public class ExternalDeclaration_V1 : ExternalDeclaration
    {
        FunctionDefinition FunctionDefinition;

        public ExternalDeclaration_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "external-declaration (variant 2)",
             Description = "external-declaration: declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public class ExternalDeclaration_V2 : ExternalDeclaration
    {
        Declaration Declaration;

        public ExternalDeclaration_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
