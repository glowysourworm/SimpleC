using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.LexicalElements
{
    [Grammar(Name = "token (base)",
             Description = "(base) token: (5 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public abstract class Token : GrammarBase
    {
        // One Sub-Class: keyword, identifier, constant, string-literal, punctuator
        public Token(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "token (variant 1)",
             Description = "token: keyword",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class Token_V1 : Token
    {
        Keyword Keyword;

        public Token_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "token (variant 2)",
             Description = "token: identifier",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class Token_V2 : Token
    {
        Identifier Identifier;

        public Token_V2(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "token (variant 3)",
             Description = "token: constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class Token_V3 : Token
    {
        Constant Constant;

        public Token_V3(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "token (variant 4)",
             Description = "token: string-literal",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class Token_V4 : Token
    {
        StringLiteral StringLiteral;

        public Token_V4(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "token (variant 5)",
             Description = "token: punctuator",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4)]
    public class Token_V5 : Token
    {
        Punctuator Punctuator;

        public Token_V5(CodeRefBase codeRef) : base(codeRef) { }
    }
}
