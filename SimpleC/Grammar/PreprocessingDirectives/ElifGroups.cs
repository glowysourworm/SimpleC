using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "elif-groups (base)",
             Description = "elif-groups: (2 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class ElifGroups : GrammarBase
    {
        protected ElifGroups(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "elif-groups (variant 1)",
             Description = "elif-groups: elif-group",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ElifGroups_V1 : ElifGroups
    {
        ElifGroup ElifGroup;

        public ElifGroups_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "elif-groups (variant 2)",
             Description = "elif-groups: elif-groups elif-group",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ElifGroups_V2 : ElifGroups
    {
        ElifGroups ElifGroups;
        ElifGroup ElifGroup;

        public ElifGroups_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
