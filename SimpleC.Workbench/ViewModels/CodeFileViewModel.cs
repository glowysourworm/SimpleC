using System;

namespace SimpleC.Workbench.ViewModels
{
    public class CodeFileViewModel : ViewModelBase
    {
        string _fullPath;
        string _fileNameOrDirectoryName;
        string _contents;

        public string FullPath
        {
            get { return _fullPath; }
            set { this.SetProperty(ref _fullPath, value); }
        }
        public string FileNameOrDirectoryName
        {
            get { return _fileNameOrDirectoryName; }
            set { this.SetProperty(ref _fileNameOrDirectoryName, value); }
        }
        public string Contents
        {
            get { return _contents; }
            set { this.SetProperty(ref _contents, value); }
        }

        public event EventHandler<string> CodeChangedEvent;

        public void RaiseTextChanged(string theText)
        {
            if (this.CodeChangedEvent != null)
                this.CodeChangedEvent(this, theText);
        }

        public CodeFileViewModel()
        {
            this.FullPath = "";
            this.FileNameOrDirectoryName = "";
            this.Contents = "";
        }
    }
}
