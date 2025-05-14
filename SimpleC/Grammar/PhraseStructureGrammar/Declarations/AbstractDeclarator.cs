namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class AbstractDeclarator : GrammarBase
    {
        Pointer _pointer1;

        Pointer? _pointer2;
        DirectAbstractDeclarator _directAbstractDeclarator;

        public Pointer Pointer1
        {
            get { return _pointer1; }
            set { this.RaiseAndSetIfChanged(ref _pointer1, value); }
        }
        public Pointer? Pointer2
        {
            get { return _pointer2; }
            set { this.RaiseAndSetIfChanged(ref _pointer2, value); }
        }
        public DirectAbstractDeclarator DirectAbstractDeclarator
        {
            get { return _directAbstractDeclarator; }
            set { this.RaiseAndSetIfChanged(ref _directAbstractDeclarator, value); }
        }


        public AbstractDeclarator()
        {
            this.Pointer1 = new Pointer();
            this.Pointer2 = null;
            this.DirectAbstractDeclarator = new DirectAbstractDeclarator();
        }
    }
}
