using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "group-part (base)",
             Description = "group-part: (4 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class GroupPart : GrammarBase
    {
        protected GroupPart(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group-part (variant 1)",
             Description = "group-part: if-section",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class GroupPart_V1 : GroupPart
    {
        IfSection IfSection;

        public GroupPart_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group-part (variant 2)",
             Description = "group-part: control-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class GroupPart_V2 : GroupPart
    {
        ControlLine ControlLine;

        public GroupPart_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group-part (variant 3)",
             Description = "group-part: text-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class GroupPart_V3 : GroupPart
    {
        TextLine TextLine;

        public GroupPart_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "group-part (variant 4)",
             Description = "group-part: # non-directive",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class GroupPart_V4 : GroupPart
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        NonDirective NonDirective;

        public GroupPart_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
