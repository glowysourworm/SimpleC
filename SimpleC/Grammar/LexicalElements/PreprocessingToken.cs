using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.HeaderNames;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.LexicalElements
{
    [Grammar(Name = "preprocessing-token (base)",
             Description = "(base) preprocessing-token: (7 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public abstract class PreprocessingToken : GrammarBase
    {
        public PreprocessingToken(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 1)",
         Description = "preprocessing-token: header-name",
         Section = ISOCStandardAnnexSection.A_1,
         SubSection = ISOCStandardAnnexSubSection.A_1_1,
         SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V1 : PreprocessingToken
    {
        HeaderName HeaderName;

        public PreprocessingToken_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 2)",
             Description = "preprocessing-token: identifier",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V2 : PreprocessingToken
    {
        Identifier Identifier;

        public PreprocessingToken_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 3)",
             Description = "preprocessing-token: pp-number",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V3 : PreprocessingToken
    {
        PreprocessingNumber PreprocessingNumber;

        public PreprocessingToken_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 4)",
             Description = "preprocessing-token: character-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V4 : PreprocessingToken
    {
        CharacterConstant CharacterConstant;

        public PreprocessingToken_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 5)",
             Description = "preprocessing-token: string-literal",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V5 : PreprocessingToken
    {
        StringLiteral StringLiteral;

        public PreprocessingToken_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 6)",
             Description = "preprocessing-token: punctuator",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V6 : PreprocessingToken
    {
        Punctuator Punctuator;

        public PreprocessingToken_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "preprocessing-token (variant 7)",
             Description = "preprocessing-token: each non-white space character that cannot be one of the above",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class PreprocessingToken_V7 : PreprocessingToken
    {
        // ??? This may be part of the other variant(s) ???

        public PreprocessingToken_V7(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
