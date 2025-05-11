using SimpleC.Base;

namespace SimpleC.Code
{
    public enum CodeFileType
    {
        C,
        Assembler
    }

    public class CodeFile : ModelBase
    {
        string _path;
        CodeFileType _type;

        public string Path
        {
            get { return _path; }
            set { this.RaiseAndSetIfChanged(ref _path, value); }
        }
        public CodeFileType Type
        {
            get { return _type; }
            set { this.RaiseAndSetIfChanged(ref _type, value); }
        }

        /// <summary>
        /// Utilize a central file-manager to determine file types for the 
        /// assembler:  What type of file is a *.S file? It depends on the 
        /// assembler (?)
        /// </summary>
        public CodeFile(string path, CodeFileType type)
        {
            this.Path = path;
            this.Type = type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Path, this.Type);
        }
    }
}
