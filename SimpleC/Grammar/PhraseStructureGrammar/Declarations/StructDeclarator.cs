using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "struct-declarator (base)",
             Description = "struct-declarator: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public abstract class StructDeclarator : GrammarBase
    {
        protected StructDeclarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-declarator (variant 1)",
             Description = "struct-declarator: declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclarator_V1 : StructDeclarator
    {
        Declarator Declarator;

        public StructDeclarator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-declarator (variant 2)",
             Description = "struct-declarator: declarator_opt : constant-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclarator_V2 : StructDeclarator
    {
        Declarator? Declarator;
        public const char ColonSeparator = GrammarCConstants.Colon;
        ConstantExpression ConstantExpression;

        public StructDeclarator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
