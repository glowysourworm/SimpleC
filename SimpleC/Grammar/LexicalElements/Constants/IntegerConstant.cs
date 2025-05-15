using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "integer-constant (base)",
             Description = "integer-constant: (3 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public abstract class IntegerConstant : GrammarBase
    {
        public IntegerConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-constant (variant 1)",
             Description = "integer-constant: decimal-constant integer-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerConstant_V1 : IntegerConstant
    {
        DecimalConstant DecimalConstant;
        IntegerSuffix? IntegerSuffix;

        public IntegerConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-constant (variant 2)",
             Description = "integer-constant: octal-constant integer-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerConstant_V2 : IntegerConstant
    {
        OctalConstant OctalConstant;
        IntegerSuffix? IntegerSuffix;

        public IntegerConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-constant (variant 3)",
             Description = "integer-constant: hexadecimal-constant integer-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerConstant_V3 : IntegerConstant
    {
        HexadecimalConstant HexadecimalConstant;
        IntegerSuffix? IntegerSuffix;

        public IntegerConstant_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
