using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "expression-statement",
             Description = "expression-statement: expression_opt ;",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_3)]
    public class ExpressionStatement : Statement
    {
        Expression? Expression;
        public const char StatementSeparator = GrammarCConstants.Semicolon;

        public ExpressionStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
