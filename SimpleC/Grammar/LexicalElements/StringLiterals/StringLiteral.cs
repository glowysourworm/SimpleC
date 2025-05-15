using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    [Grammar(Name = "string-literal (base)",
             Description = "string-literal (base): (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public abstract class StringLiteral : Token
    {
        public StringLiteral(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "string-literal (variant 1)",
             Description = "string-literal: \" s-char-sequence_opt \"",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class StringLiteral_V1 : StringLiteral
    {
        public const char PrefixDoubleQuote1 = GrammarCConstants.DoubleQuote;
        public SCharSequence? SCharSequence;
        public const char SuffixDoubleQuote1 = GrammarCConstants.DoubleQuote;

        public StringLiteral_V1(CodeRefBase codeRef) : base(codeRef)
        {

        }
    }

    [Grammar(Name = "string-literal (variant 2)",
             Description = "string-literal: L\" s-char-sequence_opt \"",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_6,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_5)]
    public class StringLiteral_V2 : StringLiteral
    {
        public const char PrefixLiteralConstant2 = GrammarCConstants.Letter_L;
        public const char PrefixDoubleQuote2 = GrammarCConstants.DoubleQuote;
        public SCharSequence? SCharSequence;
        public const char SuffixDoubleQuote2 = GrammarCConstants.DoubleQuote;

        public StringLiteral_V2(CodeRefBase codeRef) : base(codeRef)
        {

        }
    }
}
