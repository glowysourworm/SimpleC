using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "designation",
             Description = "designation: designator-list =",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Designation : GrammarBase
    {
        DesignatorList DesignatorList;
        public const string AssignmentOperator = GrammarCOperators.Assignment;

        public Designation(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
