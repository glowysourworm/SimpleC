namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class BlockItemList : Statement
    {
        BlockItem _blockItem1;

        BlockItemList _blockItemList2;
        BlockItem _blockItem2;

        public BlockItem BlockItem1
        {
            get { return _blockItem1; }
            set { this.RaiseAndSetIfChanged(ref _blockItem1, value); }
        }
        public BlockItemList BlockItemList2
        {
            get { return _blockItemList2; }
            set { this.RaiseAndSetIfChanged(ref _blockItemList2, value); }
        }
        public BlockItem BlockItem2
        {
            get { return _blockItem2; }
            set { this.RaiseAndSetIfChanged(ref _blockItem2, value); }
        }

        public BlockItemList()
        {
            this.BlockItemList2 = new BlockItemList();
            this.BlockItem1 = new BlockItem();
            this.BlockItem2 = new BlockItem();
        }
    }
}
