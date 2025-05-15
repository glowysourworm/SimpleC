using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements
{
    [Grammar(Name = "keyword",
             Description = "keyword: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_1)]
    public class Keyword : GrammarBase
    {
        public Keyword(CodeRefBase codeRef) : base(codeRef)
        {
            // TODO: Validation (One Of: ...)
        }
    }
}
