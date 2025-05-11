namespace SimpleC.Code
{
    /// <summary>
    /// Reference to a specific piece of text from the base grammar.
    /// </summary>
    public class CodeRef : CodeRefBase
    {
        CodeFileType _fileType;

        /// <summary>
        /// This would indicate the type of value stored in this code reference (Asm or C)
        /// </summary>
        public CodeFileType FileType
        {
            get { return _fileType; }
            set { this.RaiseAndSetIfChanged(ref _fileType, value); }
        }

        public CodeRef() : base()
        {
            this.FileType = CodeFileType.C;
            this.Value = string.Empty;
        }
    }
}
