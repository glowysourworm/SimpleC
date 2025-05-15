using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "integer-suffix (base)",
             Description = "(base) integer-suffix: (4 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public abstract class IntegerSuffix : GrammarBase
    {
        protected IntegerSuffix(CodeRefBase codeRef) : base(codeRef) {}
    }

    [Grammar(Name = "integer-suffix (variant 1)",
             Description = "integer-suffix: unsigned-suffix long-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerSuffix_V1 : IntegerSuffix
    {
        public UnsignedSuffix UnsignedSuffix;
        public LongSuffix? LongSuffix;

        public IntegerSuffix_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-suffix (variant 2)",
             Description = "integer-suffix: unsigned-suffix long-long-suffix",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerSuffix_V2 : IntegerSuffix
    {
        public UnsignedSuffix UnsignedSuffix;
        public LongLongSuffix LongLongSuffix;

        public IntegerSuffix_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-suffix (variant 3)",
             Description = "integer-suffix: long-suffix unsigned-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerSuffix_V3 : IntegerSuffix
    {
        public LongSuffix LongSuffix;
        public UnsignedSuffix? UnsignedSuffix;

        public IntegerSuffix_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "integer-suffix (variant 4)",
             Description = "integer-suffix: long-long-suffix unsigned-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class IntegerSuffix_V4 : IntegerSuffix
    {
        public LongLongSuffix LongSuffix;
        public UnsignedSuffix? UnsignedSuffix;

        public IntegerSuffix_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
