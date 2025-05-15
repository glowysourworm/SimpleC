using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "group (base)",
             Description = "group: (2 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class Group : GrammarBase
    {
        protected Group(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group (variant 1)",
             Description = "group: group-part",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class Group_V1 : Group
    {
        GroupPart GroupPart;

        public Group_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group (variant 2)",
             Description = "group: group group-part",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class Group_V2 : Group
    {
        Group Group;
        GroupPart GroupPart;

        public Group_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
