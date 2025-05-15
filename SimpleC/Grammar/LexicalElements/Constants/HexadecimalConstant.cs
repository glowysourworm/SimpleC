using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-constant (base)",
             Description = "(base) hexadecimal-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public abstract class HexadecimalConstant : GrammarBase
    {
        public HexadecimalConstant(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "hexadecimal-constant (variant 1)",
             Description = "hexadecimal-constant: hexadecimal-prefix hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class HexadecimalConstant_V1 : HexadecimalConstant
    {
        public HexadecimalPrefix HexadecimalPrefix;
        public HexadecimalDigit HexadecimalDigit;

        public HexadecimalConstant_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "hexadecimal-constant (variant 2)",
             Description = "hexadecimal-constant: hexadecimal-constant hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class HexadecimalConstant_V2 : HexadecimalConstant
    {
        public HexadecimalConstant HexadecimalConstant;
        public HexadecimalDigit HexadecimalDigit;

        public HexadecimalConstant_V2(CodeRefBase codeRef) : base(codeRef) { }
    }
}
