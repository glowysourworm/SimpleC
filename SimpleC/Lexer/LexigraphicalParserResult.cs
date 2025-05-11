using SimpleC.Base;
using SimpleC.Code;
using SimpleC.Main;
using SimpleC.Main.Interface;

namespace SimpleC.Lexer
{
    public class LexigraphicalParserResult : CompilerResultBase
    {
        /// <summary>
        /// Primary sequence of scope blocks - which are, themselves, recursive trees of code - broken down by
        /// type:  1) Preprocessor, 2) Keyword, or 3) Identifier. Each block will be parsed according to the 
        /// language grammar.
        /// </summary>
        protected SimpleList<ScopeBlock> BlockSequence { get; private set; }

        public LexigraphicalParserResult(CCompilerPass pass) : base(Enumerable.Empty<ICCompilerEventData>(), pass)
        {
            this.BlockSequence = new SimpleList<ScopeBlock>();
        }

        public void AddBlock(ScopeBlock block)
        {
            this.BlockSequence.Add(block);
        }

        public IEnumerable<ScopeBlock> GetBlockSequence()
        {
            return this.BlockSequence;
        }
    }
}
