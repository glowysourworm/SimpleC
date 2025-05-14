namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    public class TranslationUnit : GrammarBase
    {
        ExternalDeclaration _externalDeclaration1;

        TranslationUnit _translationUnit2;
        ExternalDeclaration _externalDeclaration2;

        public ExternalDeclaration ExternalDeclaration1
        {
            get { return _externalDeclaration1; }
            set { this.RaiseAndSetIfChanged(ref _externalDeclaration1, value); }
        }
        public TranslationUnit TranslationUnit2
        {
            get { return _translationUnit2; }
            set { this.RaiseAndSetIfChanged(ref _translationUnit2, value); }
        }
        public ExternalDeclaration ExternalDeclaration2
        {
            get { return _externalDeclaration2; }
            set { this.RaiseAndSetIfChanged(ref _externalDeclaration2, value); }
        }

        public TranslationUnit()
        {
            this.ExternalDeclaration1 = new ExternalDeclaration();
            this.ExternalDeclaration2 = new ExternalDeclaration();
            this.TranslationUnit2 = new TranslationUnit();
        }
    }
}
