using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class PreprocessingTokens : GrammarBase
    {
        PreprocessingToken _preprocessingToken1;

        PreprocessingTokens _preprocessingTokens2;
        PreprocessingToken _preprocessingToken2;

        public PreprocessingToken PreprocessingToken1
        {
            get { return _preprocessingToken1; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingToken1, value); }
        }
        public PreprocessingTokens PreprocessingTokens2
        {
            get { return _preprocessingTokens2; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens2, value); }
        }
        public PreprocessingToken PreprocessingToken2
        {
            get { return _preprocessingToken2; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingToken2, value); }
        }

        public PreprocessingTokens()
        {
            this.PreprocessingToken1 = new PreprocessingToken();
            this.PreprocessingToken2 = new PreprocessingToken();
            this.PreprocessingTokens2 = new PreprocessingTokens();
        }
    }
}
