using SimpleC.Code;

namespace SimpleC.Main.Interface
{
    public interface ICCompilerEventData
    {
        public CCompilerPass Pass { get; set; }
        public string Message { get; set; }
        public CCompilerEventType Type { get; set; }
        public CCompilerEventSeverity Severity { get; set; }

        // Relationship to code files
        public CodeFile File { get; set; }
    }
}
