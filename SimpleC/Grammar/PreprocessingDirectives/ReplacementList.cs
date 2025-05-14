namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class ReplacementList : GrammarBase
    {
        PreprocessingTokens? _preprocessingTokens;

        public PreprocessingTokens? PreprocessingTokens
        {
            get { return _preprocessingTokens; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens, value); }
        }

        public ReplacementList()
        {
            this.PreprocessingTokens = null;
        }
    }
}
