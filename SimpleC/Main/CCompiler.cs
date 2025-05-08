using SimpleC.Base;
using SimpleC.Lexer;
using SimpleC.Lexer.Interface;

namespace SimpleC.Main
{
    public class CCompiler : ModelBase
    {
        readonly ILexigraphicalParser _parser;

        public CCompiler()
        {
            _parser = new LexigraphicalParser();
        }
    }
}
