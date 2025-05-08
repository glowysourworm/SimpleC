using SimpleC.Lexer.Interface;

namespace SimpleC.Lexer
{
    public class LexigraphicalParser : ILexigraphicalParser
    {
        public IEnumerable<ScopeBlock> Parse(ScopeBlock block)
        {
            throw new NotImplementedException();
        }

        public void SetLanguageTokens(IEnumerable<Token> tokens)
        {
            throw new NotImplementedException();
        }
    }
}
