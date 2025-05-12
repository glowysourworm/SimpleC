using System.Collections.ObjectModel;

namespace SimpleC.Workbench.ViewModels
{
    public partial class ViewModel : ViewModelBase
    {
        FileItemViewModel _projectFiles;

        public FileItemViewModel ProjectFiles
        {
            get { return _projectFiles; }
            set { this.SetProperty(ref _projectFiles, value); }
        }

        public ViewModel()
        {
            this.ProjectFiles = new FileItemViewModel("", false);
        }

        public void Load(string projectFilePath)
        {
            this.ProjectFiles.Load(projectFilePath, true);
        }
    }
}
