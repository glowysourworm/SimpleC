using System;
using System.IO;

using Antlr4.Runtime;

using SimpleC.Workbench.ViewModels.CodeAnalysis;

namespace SimpleC.Workbench.Component.CodeAnalysis
{
    public class CLexerErrorListener : IAntlrErrorListener<int>
    {
        public event EventHandler<SyntaxErrorViewModel> SyntaxErrorEvent;

        public void SyntaxError(TextWriter output,
                                IRecognizer recognizer,
                                int offendingSymbol,
                                int line,
                                int charPositionInLine,
                                string msg,
                                RecognitionException e)
        {
            if (this.SyntaxErrorEvent != null)
            {
                this.SyntaxErrorEvent(this, new SyntaxErrorViewModel()
                {
                    Column = charPositionInLine,
                    Line = line,
                    HelpLink = e.HelpLink ?? "",
                    Message = msg,
                    Rule = recognizer.RuleNames[e.Context.RuleIndex],
                    Symbol = e.OffendingToken.Text
                });
            }
        }
    }
}
