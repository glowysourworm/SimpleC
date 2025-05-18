using System;
using System.Collections.Generic;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using SimpleC.ParserGenerator.Component;
using SimpleC.Workbench.ViewModels;

namespace SimpleC.Workbench.Models
{
    public class CodeParser
    {
        CodeParserInputStream _inputStream;
        CommonTokenStream _tokenStream;
        CLexer _lexer;
        CLexerErrorListener _lexerErrorListener;
        CParser _parser;
        CParseTreeListener _parserListener;

        public List<string> TokenMessages { get; set; }

        public event EventHandler<LogViewModel> LogEvent;

        public CodeParser()
        {
            _inputStream = new CodeParserInputStream();
            _lexer = new CLexer(_inputStream);
            _lexerErrorListener = new CLexerErrorListener();

            _lexer.AddErrorListener(_lexerErrorListener);
            _tokenStream = new CommonTokenStream(_lexer);

            _parser = new CParser(_tokenStream);

            _parserListener = new CParseTreeListener();
            _parserListener.VisitErrorNodeEvent += OnVisitErrorNodeEvent;
            _parserListener.VisitTerminalEvent += OnVisitTerminalNodeEvent;
            _parser.AddParseListener(_parserListener);

            this.TokenMessages = new List<string>();
        }

        ~CodeParser()
        {
            _parserListener.VisitErrorNodeEvent -= OnVisitErrorNodeEvent;
            _parserListener.VisitTerminalEvent -= OnVisitTerminalNodeEvent;
        }

        public void Run(string codeString)
        {
            // POC: Parse code string using the CParser / CLexer and show output in the output log view

            try
            {
                _inputStream.Seek(0);
                _inputStream.Load(codeString);
                _parser.Reset();
                _lexer.Reset();

                var unit = _parser.compilationUnit();
                var walker = new ParseTreeWalker();
                walker.Walk(_parserListener, unit);

                this.TokenMessages.Clear();

                foreach (var token in _lexer.GetAllTokens())
                {
                    var message = "Token:  Name={0} Source={1} Type={2} Line={3} Column={4}";
                    var formattedMessage = string.Format(message, 
                                                         token.Text, 
                                                         token.TokenSource.SourceName, 
                                                         _parser.Vocabulary.GetDisplayName(token.Type) ?? "", 
                                                         token.Line, token.Column);
                    this.TokenMessages.Add(formattedMessage);
                }

                OnLog("Parser ran successfully", LogType.Message, LogSeverity.Info);
            }
            catch (Exception ex)
            {
                OnLog("Error Parsing:  " + ex.Message, LogType.Message, LogSeverity.Error);
            }
        }

        private void OnLog(string messageFormat, LogType type, LogSeverity severity, params object[] parameters)
        {
            if (this.LogEvent != null)
            {
                this.LogEvent(this, new LogViewModel()
                {
                    Message = string.Format(messageFormat, parameters),
                    Severity = severity,
                    Type = type,
                    Timestamp = DateTime.Now
                });
            }
        }

        private void OnVisitTerminalNodeEvent(object? sender, ITerminalNode e)
        {
            //OnLog("Visit Terminal Node:  " + e.GetText(), LogType.Code, LogSeverity.Info);
        }

        private void OnVisitErrorNodeEvent(object? sender, IErrorNode e)
        {
            //OnLog("Visit Error Node:  " + e.GetText(), LogType.Code, LogSeverity.Info);
        }
    }
}
