namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class NonDirective : GrammarBase
    {
        PreprocessingTokens _preprocessingTokens1;
        NewLine _newLine1;

        public PreprocessingTokens PreprocessingTokens1
        {
            get { return _preprocessingTokens1; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens1, value); }
        }
        public NewLine NewLine1
        {
            get { return _newLine1; }
            set { this.RaiseAndSetIfChanged(ref _newLine1, value); }
        }

        public NonDirective()
        {
            this.PreprocessingTokens1 = new PreprocessingTokens();
            this.NewLine1 = new NewLine();
        }
    }
}
