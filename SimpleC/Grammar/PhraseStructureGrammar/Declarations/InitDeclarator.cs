using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "init-declarator (base)",
             Description = "init-declarator: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public abstract class InitDeclarator : GrammarBase
    {
        protected InitDeclarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "init-declarator (variant 1)",
             Description = "init-declarator: declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class InitDeclarator_V1 : InitDeclarator
    {
        Declarator Declarator;

        public InitDeclarator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "init-declarator (variant 2)",
             Description = "init-declarator: declarator = initializer",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class InitDeclarator_V2 : InitDeclarator
    {
        Declarator Declarator;
        public const string AssignmentOperator = GrammarCOperators.Assignment;
        Initializer Initializer;

        public InitDeclarator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
