using System.IO;

using Avalonia.Controls;
using Avalonia.Platform.Storage;

using SimpleC.Workbench.ViewModels;

namespace SimpleC.Workbench.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Workspace_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // Get top level from the current control. Alternatively, you can use Window reference instead.
            var topLevel = TopLevel.GetTopLevel(this);
            var viewModel = this.DataContext as ViewModel;

            if (topLevel != null && viewModel != null)
            {
                // Start async operation to open the dialog.
                var folders = await topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
                {
                    Title = "Open Workspace",
                    AllowMultiple = false                    
                });

                if (folders.Count >= 1)
                {
                    // Open reading stream from the first file.
                    var path = folders[0].Path.LocalPath;

                    // Set project files (will scan directories)
                    viewModel.ProjectFiles = new FileItemViewModel(path.ToString(), true);
                }
            }
        }
    }
}