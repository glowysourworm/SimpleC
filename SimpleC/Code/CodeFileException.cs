namespace SimpleC.Code
{
    public class CodeFileException : Exception
    {
        public CodeFile CodeFile { get; set; }

        public CodeFileException(CodeFile codeFile, string message, Exception innerException) : base(message, innerException)
        {
            this.CodeFile = codeFile;
        }
    }
}
