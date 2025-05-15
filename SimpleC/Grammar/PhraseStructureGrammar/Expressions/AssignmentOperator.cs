using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "assignment-operator",
             Description = "assigment-operator: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_16)]
    public class AssignmentOperator : GrammarConstant
    {
        // One Of:  = *= /= %= += -= <<= >>= &= ^= |=
        public AssignmentOperator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
