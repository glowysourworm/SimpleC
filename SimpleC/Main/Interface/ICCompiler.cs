using SimpleC.Base;
using SimpleC.Code;
using SimpleC.Lexer;

namespace SimpleC.Main.Interface
{
    /// <summary>
    /// The phases of a compiler:  Lexical Analysis, Syntax Analysis, Semantic Analysis, 
    /// First Pass Code Generation, Optimization, Second Pass Code Generation. Please see 
    /// method comments for more information.
    /// </summary>
    public interface ICCompiler
    {
        public event SimpleHandler<ICCompilerEventData> CompilerEvent;

        /// <summary>
        /// The first stage of compilation. 
        /// </summary>
        public LexigraphicalParserResult RunParser();

        public void SetCodeFiles(IEnumerable<CodeFile> codeFiles);
    }
}
