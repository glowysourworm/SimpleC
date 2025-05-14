namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class CompoundStatement : Statement
    {
        public const char BlockItemListOpenBracket1 = GrammarCConstants.BracketCurlyLeft;
        BlockItemList? _blockItemList;
        public const char BlockItemListCloseBracket1 = GrammarCConstants.BracketCurlyRight;

        public BlockItemList? BlockItemList
        {
            get { return _blockItemList; }
            set { this.RaiseAndSetIfChanged(ref _blockItemList, value); }
        }

        public CompoundStatement()
        {
            this.BlockItemList = null;
        }
    }
}
