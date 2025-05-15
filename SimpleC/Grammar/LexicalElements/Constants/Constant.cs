using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "constant (base)",
             Description = "(base) constant: (4 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4)]
    public abstract class Constant : GrammarBase
    {
        public Constant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "constant (variant 1)",
             Description = "constant: integer-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4)]
    public class Constant_V1 : Constant
    {
        IntegerConstant IntegerConstant;

        public Constant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "constant (variant 2)",
             Description = "constant: floating-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4)]
    public class Constant_V2 : Constant
    {
        FloatingConstant FloatingConstant;

        public Constant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "constant (variant 3)",
             Description = "constant: enumeration-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4)]
    public class Constant_V3 : Constant
    {
        EnumerationConstant EnumerationConstant;

        public Constant_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "constant (variant 4)",
             Description = "constant: character-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4)]
    public class Constant_V4 : Constant
    {
        CharacterConstant CharacterConstant;

        public Constant_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
