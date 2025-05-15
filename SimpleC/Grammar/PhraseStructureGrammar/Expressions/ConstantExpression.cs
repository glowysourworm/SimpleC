using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "constant-expression",
             Description = "constant-expression: conditional-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_6)]
    public class ConstantExpression : GrammarBase
    {
        ConditionalExpression ConditionalExpression;

        public ConstantExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
