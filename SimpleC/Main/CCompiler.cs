using SimpleC.Base;
using SimpleC.Code;
using SimpleC.Lexer;
using SimpleC.Lexer.Interface;
using SimpleC.Main.Interface;

namespace SimpleC.Main
{
    public class CCompiler : ModelBase, ICCompiler
    {
        readonly ILexigraphicalParser _parser;

        public event SimpleHandler<ICCompilerEventData> CompilerEvent;

        private SimpleList<CodeFile> _codeFiles;

        public CCompiler(LexigraphicalGrammar grammar)
        {
            _parser = new LexigraphicalParser(grammar);
            _codeFiles = new SimpleList<CodeFile>();

            _parser.ParserEvent += OnParserEvent;
        }
        ~CCompiler()
        {
            _parser.ParserEvent -= OnParserEvent;
        }

        private void OnParserEvent(ICCompilerEventData data)
        {
            if (this.CompilerEvent != null)
                this.CompilerEvent(data);
        }

        public void SetCodeFiles(IEnumerable<CodeFile> codeFiles)
        {
            _codeFiles.Clear();
            _codeFiles.AddRange(codeFiles);
        }

        public LexigraphicalParserResult RunParser()
        {
            // For now, we're just testing the very basic parser. Just open and read
            // the file(s) here.

            var combinedResult = new LexigraphicalParserResult(CCompilerPass.Parsing);

            foreach (var file in _codeFiles)
            {
                var result = _parser.Parse(file);

                // Combine results in sequence (FOR TEST ONLY)
                foreach (var block in result.GetBlockSequence())
                    combinedResult.AddBlock(block);
            }

            return null;
        }
    }
}
