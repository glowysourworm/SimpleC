using System.Collections.ObjectModel;

namespace SimpleC.Workbench.ViewModels
{
    public partial class ViewModel : ViewModelBase
    {
        FileItemViewModel _projectFiles;

        ObservableCollection<CodeFileViewModel> _codeFiles;

        public FileItemViewModel ProjectFiles
        {
            get { return _projectFiles; }
            set { this.SetProperty(ref _projectFiles, value); }
        }
        public ObservableCollection<CodeFileViewModel> CodeFiles
        {
            get { return _codeFiles; }
            set { this.SetProperty(ref _codeFiles, value); }
        }

        public ViewModel()
        {
            this.ProjectFiles = new FileItemViewModel("", false);
            this.CodeFiles = new ObservableCollection<CodeFileViewModel>()
            {
                new CodeFileViewModel()
                {
                    FullPath = "C:\\Foo\\Backup\\File1.cs",
                    FileNameOrDirectoryName = "File1.cs",
                    Contents = "Hello World! (File1)"
                },
                new CodeFileViewModel()
                {
                    FullPath = "C:\\Foo\\Backup\\File2.cs",
                    FileNameOrDirectoryName = "File2.cs",
                    Contents = "Hello World! (File2)"
                }
            };
        }

        public void Load(string projectFilePath)
        {
            this.ProjectFiles.Load(projectFilePath, true);
        }
    }
}
