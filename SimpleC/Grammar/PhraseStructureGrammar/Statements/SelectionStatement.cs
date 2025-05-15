using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "selection-statement (base)",
             Description = "selection-statement: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_4)]
    public abstract class SelectionStatement : Statement
    {
        protected SelectionStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "selection-statement (variant 1)",
             Description = "selection-statement: if ( expression ) statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_4)]
    public class SelectionStatement_V1 : SelectionStatement
    {
        public const string IfKeyword = GrammarCKeywords.Keyword_if;
        public const char IfOpenBracket = GrammarCConstants.BracketLeft;
        Expression Expression;
        public const char IfCloseBracket = GrammarCConstants.BracketRight;
        Statement Statement;

        public SelectionStatement_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "selection-statement (variant 2)",
             Description = "selection-statement: if ( expression ) statement else statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_4)]
    public class SelectionStatement_V2 : SelectionStatement
    {
        public const string IfKeyword = GrammarCKeywords.Keyword_if;
        public const char IfOpenBracket = GrammarCConstants.BracketLeft;
        Expression Expression;
        public const char IfCloseBracket = GrammarCConstants.BracketRight;
        Statement IfStatement;
        public const string ElseKeyword = GrammarCKeywords.Keyword_else;
        Statement ElseStatement;

        public SelectionStatement_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "selection-statement (variant 3)",
             Description = "selection-statement: switch ( expression ) statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_4)]
    public class SelectionStatement_V3 : SelectionStatement
    {
        public const string SwitchKeyword = GrammarCKeywords.Keyword_switch;
        public const char IfOpenBracket = GrammarCConstants.BracketLeft;
        Expression Expression;
        public const char IfCloseBracket = GrammarCConstants.BracketRight;
        Statement Statement;

        public SelectionStatement_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
