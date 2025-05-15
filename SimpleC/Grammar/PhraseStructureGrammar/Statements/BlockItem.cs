using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "block-item (base)",
             Description = "block-item: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public abstract class BlockItem : GrammarBase
    {
        protected BlockItem(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "block-item (variant 1)",
             Description = "block-item: declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public class BlockItem_V1 : BlockItem
    {
        Declaration Declaration;

        public BlockItem_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "block-item (variant 2)",
             Description = "block-item: statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public class BlockItem_V2 : BlockItem
    {
        Statement Statement;

        public BlockItem_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
