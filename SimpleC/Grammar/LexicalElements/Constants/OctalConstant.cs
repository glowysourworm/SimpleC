using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "octal-constant (base)",
             Description = "(base) octal-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public abstract class OctalConstant : GrammarBase
    {
        public OctalConstant(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "octal-constant (variant 1)",
             Description = "octal-constant: 0 (the constant char for zero)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class OctalConstant_V1 : OctalConstant
    {
        public const char ZERO = GrammarCConstants.Number0;

        public OctalConstant_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "octal-constant (variant 2)",
             Description = "octal-constant: octal-constant octal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class OctalConstant_V2 : OctalConstant
    {
        OctalConstant OctalConstant;
        OctalDigit OctalDigit;

        public OctalConstant_V2(CodeRefBase codeRef) : base(codeRef) { }
    }
}
