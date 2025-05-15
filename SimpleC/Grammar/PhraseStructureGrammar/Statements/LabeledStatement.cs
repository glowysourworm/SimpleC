using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "labeled-statement (base)",
             Description = "labeled-statement: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_1)]
    public abstract class LabeledStatement : Statement
    {
        protected LabeledStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "labeled-statement (variant 1)",
             Description = "labeled-statement: identifier : statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_1)]
    public class LabeledStatement_V1 : Statement
    {
        Identifier Identifier;
        public const char ColonSeparator = GrammarCConstants.Colon;
        Statement Statement;

        public LabeledStatement_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "labeled-statement (variant 2)",
             Description = "labeled-statement: case constant-expression : statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_1)]
    public class LabeledStatement_V2 : Statement
    {
        public const string CaseKeyword = GrammarCKeywords.Keyword_case;
        ConstantExpression ConstantExpression;
        public const char ColonSeparator = GrammarCConstants.Colon;
        Statement Statement;

        public LabeledStatement_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "labeled-statement (variant 3)",
             Description = "labeled-statement: default : statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_1)]
    public class LabeledStatement_V3 : Statement
    {
        public const string DefaultKeyword = GrammarCKeywords.Keyword_default;
        public const char ColonSeparator = GrammarCConstants.Colon;
        Statement Statement;

        public LabeledStatement_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
