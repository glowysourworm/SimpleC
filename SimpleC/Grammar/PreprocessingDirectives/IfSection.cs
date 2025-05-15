using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "if-section",
             Description = "if-section: if-group elif-groups_opt else-group_opt endif-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class IfSection : GrammarBase
    {
        IfGroup IfGroup;
        ElifGroups? ElifGroups;
        ElseGroup? ElseGroup;
        EndifLine EndifLine;

        public IfSection(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
