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
        /*

            Front End:

            1) Lexical Analysis
            2) Syntax Analysis
            3) Semantic Analysis
            4) First Pass Code Generation*  (considered "back end") (assembler)

            Back End: (device specific)
            
            5) Optimization
            6) Second Pass Code Generation  (assembler)
            
            Other Components:

            1) Symbol Table Manager
            2) Error Handler
        */

        public event SimpleHandler<ICCompilerEventData> CompilerEvent;

        /// <summary>
        /// The first stage of compilation. 
        /// </summary>
        public LexigraphicalParserResult RunParser();

        public void SetCodeFiles(IEnumerable<CodeFile> codeFiles);
    }
}
