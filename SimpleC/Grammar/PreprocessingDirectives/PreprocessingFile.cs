using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "preprocessing-file",
             Description = "preprocessing-file: group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class PreprocessingFile : GrammarBase
    {
        Group? Group;

        public PreprocessingFile(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
