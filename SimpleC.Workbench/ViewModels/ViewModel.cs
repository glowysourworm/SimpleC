using System;
using System.Collections.ObjectModel;

using SimpleC.Workbench.ViewModels.CodeAnalysis;

namespace SimpleC.Workbench.ViewModels
{
    public partial class ViewModel : ViewModelBase
    {
        FileItemViewModel _projectFiles;

        ObservableCollection<CodeFileViewModel> _codeFiles;
        ObservableCollection<LogViewModel> _logs;
        ObservableCollection<TokenViewModel> _tokens;
        ObservableCollection<SyntaxErrorViewModel> _syntaxErrors;

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
        public ObservableCollection<TokenViewModel> Tokens
        {
            get { return _tokens; }
            set { this.SetProperty(ref _tokens, value); }
        }
        public ObservableCollection<SyntaxErrorViewModel> SyntaxErrors
        {
            get { return _syntaxErrors; }
            set { this.SetProperty(ref _syntaxErrors, value); }
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
            this.Tokens = new ObservableCollection<TokenViewModel>();
            this.SyntaxErrors = new ObservableCollection<SyntaxErrorViewModel>();
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
