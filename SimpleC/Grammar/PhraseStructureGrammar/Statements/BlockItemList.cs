using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "block-item-list (base)",
             Description = "block-item-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public abstract class BlockItemList : Statement
    {
        protected BlockItemList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "block-item-list (variant 1)",
             Description = "block-item-list: block-item",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public class BlockItemList_V1 : BlockItemList
    {
        BlockItem BlockItem;

        public BlockItemList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "block-item-list (variant 2)",
             Description = "block-item-list: block-item-list block-item",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public class BlockItemList_V2 : BlockItemList
    {
        BlockItemList BlockItemList;
        BlockItem BlockItem;

        public BlockItemList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
