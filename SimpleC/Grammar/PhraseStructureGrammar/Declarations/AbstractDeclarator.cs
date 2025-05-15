using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "abstract-declarator (base)",
             Description = "abstract-declarator: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public abstract class AbstractDeclarator : GrammarBase
    {
        protected AbstractDeclarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "abstract-declarator (variant 1)",
             Description = "abstract-declarator: pointer",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class AbstractDeclarator_V1 : AbstractDeclarator
    {
        Pointer Pointer;

        public AbstractDeclarator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "abstract-declarator (variant 2)",
             Description = "abstract-declarator: pointer_opt direct-abstract-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class AbstractDeclarator_V2 : AbstractDeclarator
    {
        Pointer? Pointer;
        DirectAbstractDeclarator DirectAbstractDeclarator;

        public AbstractDeclarator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
