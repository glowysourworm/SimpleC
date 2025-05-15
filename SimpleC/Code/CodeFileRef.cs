namespace SimpleC.Code
{
    /// <summary>
    /// Reference to a specific piece of text from the code file. This will have start
    /// and end indices to the text.
    /// </summary>
    public class CodeFileRef : CodeRefBase
    {
        string _path;
        CodeFileType _fileType;
        int _startIndex;
        int _endIndex;

        public string Path
        {
            get { return _path; }
            set { this.RaiseAndSetIfChanged(ref _path, value); }
        }
        public CodeFileType FileType
        {
            get { return _fileType; }
            set { this.RaiseAndSetIfChanged(ref _fileType, value); }
        }
        public int StartIndex
        {
            get { return _startIndex; }
            set { this.RaiseAndSetIfChanged(ref _startIndex, value); }
        }
        public int EndIndex
        {
            get { return _endIndex; }
            set { this.RaiseAndSetIfChanged(ref _endIndex, value); }
        }

        public CodeFileRef() : base(string.Empty)
        {
            this.Path = string.Empty;
            this.FileType = CodeFileType.C;
            this.StartIndex = -1;
            this.EndIndex = -1;
        }
    }
}
