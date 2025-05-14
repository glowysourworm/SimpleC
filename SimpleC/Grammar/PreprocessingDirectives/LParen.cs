namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class LParen : GrammarBase
    {
        // (see Annex A.2.4 -> 6.10) lparen:  a ( character not immediately preceded by white-space

        public const char LeftParen = GrammarCConstants.BracketLeft;
    }
}
