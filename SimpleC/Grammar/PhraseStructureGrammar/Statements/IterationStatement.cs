using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "iteration-statement (base)",
             Description = "iteration-statement: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_5)]
    public abstract class IterationStatement : Statement
    {
        protected IterationStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "iteration-statement (variant 1)",
             Description = "iteration-statement: while ( expression ) statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_5)]
    public class IterationStatement_V1 : IterationStatement
    {
        public const string WhileKeyword = GrammarCKeywords.Keyword_while;
        public const char WhileOpenBracket = GrammarCConstants.BracketLeft;
        Expression Expression;
        public const char WhileCloseBracket = GrammarCConstants.BracketRight;
        Statement Statement;

        public IterationStatement_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "iteration-statement (variant 2)",
             Description = "iteration-statement: do statement while ( expression ) ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_5)]
    public class IterationStatement_V2 : IterationStatement
    {
        public const string DoKeyword = GrammarCKeywords.Keyword_do;
        Statement DoStatement;
        public const string WhileKeyword = GrammarCKeywords.Keyword_while;
        public const char WhileOpenBracket = GrammarCConstants.BracketLeft;
        Expression WhileExpression;
        public const char WhileCloseBracket = GrammarCConstants.BracketRight;
        public const char WhileSeparator = GrammarCConstants.Semicolon;

        public IterationStatement_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "iteration-statement (variant 3)",
             Description = "iteration-statement: for ( expression_opt ; expression_opt ; expression_opt ) statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_5)]
    public class IterationStatement_V3 : IterationStatement
    {
        public const string ForKeyword = GrammarCKeywords.Keyword_for;
        public const char ForOpenBracket = GrammarCConstants.BracketLeft;
        Expression? Expression1;
        public const char ForSeparator1 = GrammarCConstants.Semicolon;
        Expression? Expression2;
        public const char ForSeparator2 = GrammarCConstants.Semicolon;
        Expression? Expression3;
        public const char ForCloseBracket = GrammarCConstants.BracketRight;
        Statement ForStatement;

        public IterationStatement_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "iteration-statement (variant 4)",
             Description = "iteration-statement: for ( declaration expression_opt ; expression_opt ) statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_5)]
    public class IterationStatement_V4 : IterationStatement
    {
        public const string ForKeyword = GrammarCKeywords.Keyword_for;
        public const char ForOpenBracket = GrammarCConstants.BracketLeft;
        Declaration Declaration;
        Expression? Expression1;
        public const char ForSeparator = GrammarCConstants.Semicolon;
        Expression? Expression2;
        public const char ForCloseBracket = GrammarCConstants.BracketRight;
        Statement ForStatement;

        public IterationStatement_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
