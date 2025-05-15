using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    [Grammar(Name = "q-char (base)",
             Description = "q-char: any member of the source character set except the new-line character and \"",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_8,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_7)]
    public class QChar : GrammarBase
    {
        public QChar(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
