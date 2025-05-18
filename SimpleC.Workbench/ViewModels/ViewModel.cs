using System;
using System.Collections.ObjectModel;

namespace SimpleC.Workbench.ViewModels
{
    public partial class ViewModel : ViewModelBase
    {
        FileItemViewModel _projectFiles;

        ObservableCollection<CodeFileViewModel> _codeFiles;
        ObservableCollection<LogViewModel> _logs;
        ObservableCollection<LogViewModel> _parserLogs;

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
        public ObservableCollection<LogViewModel> Logs
        {
            get { return _logs; }
            set { this.SetProperty(ref _logs, value); }
        }
        public ObservableCollection<LogViewModel> ParserLogs
        {
            get { return _parserLogs; }
            set { this.SetProperty(ref _parserLogs, value); }
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
            this.Logs = new ObservableCollection<LogViewModel>();
            this.ParserLogs = new ObservableCollection<LogViewModel>();
        }

        public void Load(string projectFilePath)
        {
            try
            {
                this.ProjectFiles.Load(projectFilePath, projectFilePath, true);
            }
            catch (Exception ex)
            {
                // TODO
            }
        }
    }
}
