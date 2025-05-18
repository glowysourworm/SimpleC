using Antlr4.Runtime;

namespace SimpleC.ParserGenerator.Component
{
    public class CLexerErrorListener : IAntlrErrorListener<int>
    {
        public event EventHandler<string> ErrorEvent;

        public void SyntaxError(TextWriter output,
                                IRecognizer recognizer,
                                int offendingSymbol,
                                int line,
                                int charPositionInLine,
                                string msg,
                                RecognitionException e)
        {
            if (this.ErrorEvent != null)
            {
                this.ErrorEvent(this, msg);
            }
        }
    }
}
