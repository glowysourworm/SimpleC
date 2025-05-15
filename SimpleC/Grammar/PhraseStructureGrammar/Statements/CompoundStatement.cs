using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "compound-statement",
             Description = "compound-statement: { block-item-list_opt }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8_2)]
    public class CompoundStatement : Statement
    {
        public const char BlockItemListOpenBracket = GrammarCConstants.BracketCurlyLeft;
        BlockItemList? BlockItemList;
        public const char BlockItemListCloseBracket = GrammarCConstants.BracketCurlyRight;

        public CompoundStatement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
