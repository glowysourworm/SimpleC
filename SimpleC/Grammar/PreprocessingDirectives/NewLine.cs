using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "new-line",
             Description = "new-line: the new-line character",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class NewLine : GrammarConstant
    {
        public NewLine(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
