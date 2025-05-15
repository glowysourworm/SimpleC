using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "enumerator (base)",
             Description = "enumerator: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public abstract class Enumerator : GrammarBase
    {
        protected Enumerator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enumerator (variant 1)",
             Description = "enumerator: enumeration-constant",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class Enumerator_V1 : Enumerator
    {
        EnumerationConstant EnumerationConstant;

        public Enumerator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enumerator (variant 2)",
             Description = "enumerator: enumeration-constant = constant-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class Enumerator_V2 : Enumerator
    {
        EnumerationConstant EnumerationConstant;
        public const string AssignmentOperator = GrammarCOperators.Assignment;
        ConstantExpression ConstantExpression;

        public Enumerator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
