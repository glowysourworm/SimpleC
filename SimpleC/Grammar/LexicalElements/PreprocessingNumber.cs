using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements
{
    [Grammar(Name = "pp-number (base)",
             Description = "pp-number: (9 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public abstract class PreprocessingNumber : GrammarBase
    {
        protected PreprocessingNumber(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 1)",
             Description = "pp-number: digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V1 : GrammarBase
    {
        Digit Digit;

        public PreprocessingNumber_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 2)",
             Description = "pp-number: . digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V2 : GrammarBase
    {
        public const char PeriodPrefix = GrammarCConstants.Period;
        Digit Digit;

        public PreprocessingNumber_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 3)",
             Description = "pp-number: pp-number digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V3 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        Digit Digit;

        public PreprocessingNumber_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 4)",
             Description = "pp-number: pp-number identifier-nondigit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V4 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        IdentifierNonDigit IdentifierNonDigit;

        public PreprocessingNumber_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 5)",
             Description = "pp-number: pp-number e sign",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V5 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        public const char eConstant = GrammarCConstants.Letter_e;           // TODO: Not sure what this is used for, or what it's called
        Sign Sign;

        public PreprocessingNumber_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 6)",
             Description = "pp-number: pp-number E sign",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V6 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        public const char EConstant = GrammarCConstants.Letter_E;           // TODO: Not sure what this is used for, or what it's called
        Sign Sign;

        public PreprocessingNumber_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 7)",
             Description = "pp-number: pp-number p sign",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V7 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        public const char pConstant = GrammarCConstants.Letter_p;           // TODO: Not sure what this is used for, or what it's called
        Sign Sign;

        public PreprocessingNumber_V7(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 8)",
             Description = "pp-number: pp-number P sign",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V8 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        public const char PConstant = GrammarCConstants.Letter_P;           // TODO: Not sure what this is used for, or what it's called
        Sign Sign;

        public PreprocessingNumber_V8(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "pp-number (variant 9)",
             Description = "pp-number: pp-number .",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_9,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_8)]
    public class PreprocessingNumber_V9 : GrammarBase
    {
        PreprocessingNumber PreprocessingNumber;
        public const char Dot = GrammarCConstants.Period;

        public PreprocessingNumber_V9(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
