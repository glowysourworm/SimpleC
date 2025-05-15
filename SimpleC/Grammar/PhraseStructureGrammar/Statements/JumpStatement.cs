using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "jump-statement (base)",
             Description = "jump-statement: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_6)]
    public abstract class JumpStatement : Statement
    {
        protected JumpStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "jump-statement (variant 1)",
             Description = "jump-statement: goto identifier ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_6)]
    public class JumpStatement_V1 : JumpStatement
    {
        public const string GotoKeyword = GrammarCKeywords.Keyword_goto;
        Identifier Identifier;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public JumpStatement_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "jump-statement (variant 2)",
             Description = "jump-statement: continue ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_6)]
    public class JumpStatement_V2 : JumpStatement
    {
        public const string ContinueKeyword = GrammarCKeywords.Keyword_continue;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public JumpStatement_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "jump-statement (variant 3)",
             Description = "jump-statement: break ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_6)]
    public class JumpStatement_V3 : JumpStatement
    {
        public const string BreakKeyword = GrammarCKeywords.Keyword_break;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public JumpStatement_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "jump-statement (variant 4)",
             Description = "jump-statement: return expression_opt ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_6)]
    public class JumpStatement_V4 : JumpStatement
    {
        public const string ReturnKeyword = GrammarCKeywords.Keyword_return;
        public Expression? Expression;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public JumpStatement_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
