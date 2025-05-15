using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    [Grammar(Name = "header-name (base)",
             Description = "(base) header-name: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public abstract class HeaderName : PreprocessingToken
    {
        public HeaderName(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "header-name (variant 1)",
             Description = "header-name: < h-char-sequence >",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public abstract class HeaderName_V1 : HeaderName
    {
        public const char CaretLeftPrefix = GrammarCConstants.CaretLeft;
        HCharSequence HCharSequence;
        public const char CaretRightSuffix = GrammarCConstants.CaretRight;

        public HeaderName_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "header-name (variant 2)",
             Description = "header-name: \" q-char-sequence \"",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public abstract class HeaderName_V2 : HeaderName
    {
        public const char DoubleQuotePrefix = GrammarCConstants.DoubleQuote;
        QCharSequence QCharSequence;
        public const char DoubleQuoteSuffix = GrammarCConstants.DoubleQuote;

        public HeaderName_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
