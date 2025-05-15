using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "unary-expression",
             Description = "unary-expression: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryOperator : GrammarConstant
    {
        // One of:  & * + - ~ !
        public UnaryOperator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
