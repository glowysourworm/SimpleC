using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "pointer (base)",
             Description = "pointer: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class Pointer : GrammarBase
    {
        protected Pointer(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pointer (variant 1)",
             Description = "pointer: * type-qualifier-list_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class Pointer_V1 : GrammarBase
    {
        public const char PointerAsterix = GrammarCConstants.Asterix;
        TypeQualifierList? TypeQualifierList;

        public Pointer_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pointer (variant 2)",
             Description = "pointer: * type-qualifier-list_opt pointer",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class Pointer_V2 : GrammarBase
    {
        public const char PointerAsterix = GrammarCConstants.Asterix;
        TypeQualifierList? TypeQualifierList;
        Pointer Pointer;

        public Pointer_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
