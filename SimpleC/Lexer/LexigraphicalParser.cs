using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

using SimpleC.Base;
using SimpleC.Code;
using SimpleC.Grammar.LexicalElements;
using SimpleC.Lexer.Interface;
using SimpleC.Main;
using SimpleC.Main.Interface;

namespace SimpleC.Lexer
{
    public class LexigraphicalParser : ILexigraphicalParser
    {
        public event SimpleHandler<ICCompilerEventData> ParserEvent;

        private readonly LexigraphicalGrammar _grammar;

        public LexigraphicalParser(LexigraphicalGrammar grammar)
        {
            _grammar = grammar;
        }

        public LexigraphicalParserResult? Parse(CodeFile file)
        {
            var fileContents = "";

            try
            {
                fileContents = File.ReadAllText(file.Path);
            }
            catch (Exception error)
            {
                throw new CodeFileException(file, "Error reading file {0}. Compilation Stopped.", error);
            }

            if (!string.IsNullOrEmpty(fileContents))
            {
                return ParserImpl(fileContents);
            }

            return null;
        }

        private LexigraphicalParserResult ParserImpl(string fileContents)
        {
            // Procdure: ParserImpl should identify a ScopeTree; and fill it out recursively.
            //           The beginning of this routine should be to identify the next ScopeBlock.
            //           There will be a definition of expected syntax at this point in the parsing.
            //
            // 0) Expected Syntax:  Preprocessors, Keywords, Identifiers (user-defined)
            // 
            // 1) Preprocessors: TBD
            // 
            // 2) Keywords: 
            // 
            // 3) Identifiers
            //

            var result = new LexigraphicalParserResult(CCompilerPass.Parsing);
            var topLevelBlock = new ScopeBlock(null, fileContents, ScopeBlockType.TopLevel);
            var currentBlock = topLevelBlock;
            var finished = false;

            // Recursing through the code file should be a matter of re-trying syntax until all possible
            // further parsing is ruled out.
            //
            while (!finished)
            {
                var scopeBlocks = new SimpleList<ScopeBlock>();

                // Preprocessors

                // Keywords
                var nextBlock = ParseKeyword(currentBlock);

                // Identifiers
            }

            result.AddBlock(topLevelBlock);

            return result;
        }

        private ScopeBlock? ParseKeyword(ScopeBlock currentBlock)
        {
            // Parse out a keyword

            Token? keyword = null;
            var firstKeywordIndex = FirstKeyword(currentBlock, out keyword);

            if (keyword != null)
            {
                
            }

            return null;
        }

        private int FirstKeyword(ScopeBlock block, out Token? keyword)
        {
            // TODO: Worry about performance later

            var firstIndex = int.MaxValue;
            keyword = null;

            //foreach (var token in _grammar.GetKeywords())
            //{
            //    // Find the first occurrence of the next keyword
            //    var nextIndex = block.Code.First(token.Value);

            //    if (nextIndex >= 0 && firstIndex > nextIndex)
            //    {
            //        firstIndex = nextIndex;
            //        keyword = token;
            //    }
            //}

            //if (firstIndex == int.MaxValue)
            //    firstIndex = -1;

            return firstIndex;
        }
    }
}
