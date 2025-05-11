using SimpleC.Code;
using SimpleC.Main.Interface;

namespace SimpleC.Main
{
    public enum CCompilerPass
    {
        Parsing,
        Syntax,
        Semantic,
        CodeGen1,
        Optimization,
        CodeGen2
    }

    /// <summary>
    /// Severity of the compiler event
    /// </summary>
    public enum CCompilerEventSeverity
    {
        Info,
        Warning,
        Error
    }

    public enum CCompilerEventType
    {
        /// <summary>
        /// Specific event about lexigraphical analysis (of severity CCompilerEventSeverity)
        /// </summary>
        LexerEvent1,
        LexerEvent2,
    }

    public class CCompilerEventData : ICCompilerEventData
    {
        public CCompilerPass Pass { get; set; }
        public string Message { get; set; }
        public CCompilerEventType Type { get; set; }
        public CCompilerEventSeverity Severity { get; set; }

        // Relationship to code files
        public CodeFile File { get; set; }

        public CCompilerEventData(CodeFile file)
        {
            this.Message = "";
            this.File = file;
        }

        public override string ToString()
        {
            return string.Format("Pass: {0}\r\nMessage: {1}\r\nType: {2}\r\nSeverity: {3}", this.Pass, this.Message, this.Type, this.Severity);
        }
    }
}
