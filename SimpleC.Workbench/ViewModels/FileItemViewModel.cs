using System.Collections.ObjectModel;
using System.IO;

namespace SimpleC.Workbench.ViewModels
{
    public class FileItemViewModel : ViewModelBase
    {
        string _fullPath;
        string _fileNameOrDirectoryName;
        bool _isDirectory;
        bool _valid;

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
        public bool IsDirectory
        {
            get { return _isDirectory; }
            set { this.SetProperty(ref _isDirectory, value); }
        }
        public bool Valid
        {
            get { return _valid; }
            set { this.SetProperty(ref _valid, value); }
        }

        public ObservableCollection<FileItemViewModel> DirectoryFiles { get; private set; }

        public FileItemViewModel(string fullPath, bool isDirectory)
        {
            Load(fullPath, fullPath, isDirectory);
        }

        public void Load(string fullPathBase, string fullPath, bool isDirectory)
        {
            if (isDirectory)
            {
                if (Directory.Exists(fullPath))
                {
                    LoadImpl(fullPathBase, fullPath, isDirectory);
                }
                else
                {
                    this.DirectoryFiles = new ObservableCollection<FileItemViewModel>();
                    this.IsDirectory = isDirectory;
                    this.FullPath = "";
                    this.FileNameOrDirectoryName = "";
                    this.Valid = false;
                }
            }
            else
            {
                if (Path.Exists(fullPath))
                {
                    LoadImpl(fullPathBase, fullPath, isDirectory);
                }
                else
                {
                    this.DirectoryFiles = new ObservableCollection<FileItemViewModel>();
                    this.IsDirectory = isDirectory;
                    this.FullPath = "";
                    this.FileNameOrDirectoryName = "";
                    this.Valid = false;
                }
            }
        }

        private void LoadImpl(string fullPathBase, string fullPath, bool isDirectory)
        {
            this.DirectoryFiles = new ObservableCollection<FileItemViewModel>();
            this.IsDirectory = isDirectory;
            this.FullPath = fullPath;

            if (isDirectory)
            {
                // Short Name
                var directoryName = Path.GetDirectoryName(fullPath) ?? "";
                this.FileNameOrDirectoryName = Path.GetRelativePath(directoryName, fullPathBase);

                foreach (var directory in System.IO.Directory.GetDirectories(fullPath))
                {
                    this.DirectoryFiles.Add(new FileItemViewModel(directory, true));
                }
                foreach (var file in System.IO.Directory.GetFiles(fullPath))
                {
                    this.DirectoryFiles.Add(new FileItemViewModel(file, false));
                }
            }
            else
            {
                this.FileNameOrDirectoryName = Path.GetFileName(fullPath);
            }
        }
    }
}
