using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "enum-specifier (base)",
             Description = "enum-specifier: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public abstract class EnumSpecifier : GrammarBase
    {
        public EnumSpecifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enum-specifier (variant 1)",
             Description = "enum-specifier: enum identifier_opt { enumerator-list }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class EnumSpecifier_V1 : EnumSpecifier
    {
        public const string EnumKeyword = GrammarCKeywords.Keyword_enum;
        Identifier? Identifier;
        public const char EnumeratorListBracketCurlyLeft = GrammarCConstants.BracketCurlyLeft;
        EnumeratorList EnumeratorList;
        public const char EnumeratorListBracketCurlyRight = GrammarCConstants.BracketCurlyRight;

        public EnumSpecifier_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enum-specifier (variant 2)",
             Description = "enum-specifier: enum identifier_opt { enumerator-list , }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class EnumSpecifier_V2 : EnumSpecifier
    {
        public const string EnumKeyword = GrammarCKeywords.Keyword_enum;
        Identifier? Identifier;
        public const char EnumeratorListBracketCurlyLeft = GrammarCConstants.BracketCurlyLeft;
        EnumeratorList EnumeratorList;
        public const char EnumeratorListBracketCurlyRight = GrammarCConstants.BracketCurlyRight;
        public const char EnumeratorListCommaSeparator = GrammarCConstants.Comma;

        public EnumSpecifier_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enum-specifier (variant 3)",
             Description = "enum-specifier: enum identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class EnumSpecifier_V3 : EnumSpecifier
    {
        public const string EnumKeyword = GrammarCKeywords.Keyword_enum;
        Identifier Identifier;

        public EnumSpecifier_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
