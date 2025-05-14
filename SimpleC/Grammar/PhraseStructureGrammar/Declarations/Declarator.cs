namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Declarator : GrammarBase
    {
        Pointer? _pointer;
        DirectDeclarator _directDeclarator;

        public Pointer? Pointer
        {
            get { return _pointer; }
            set { this.RaiseAndSetIfChanged(ref _pointer, value); }
        }
        public DirectDeclarator DirectDeclarator
        {
            get { return _directDeclarator; }
            set { this.RaiseAndSetIfChanged(ref _directDeclarator, value); }
        }

        public Declarator()
        {
            this.Pointer = null;
            this.DirectDeclarator = new DirectDeclarator();
        }
    }
}
