using System;
using System.Linq;

using Avalonia.Controls;
using Avalonia.Interactivity;

using SimpleC.Workbench.Models;
using SimpleC.Workbench.ViewModels;

namespace SimpleC.Workbench.Views
{
    public partial class MainView : UserControl
    {
        CodeParser _parser;

        public MainView()
        {
            InitializeComponent();

            _parser = new CodeParser();
            _parser.LogEvent += OnLog;
        }
        ~MainView()
        {
            _parser.LogEvent -= OnLog;
        }

        protected override void OnLoaded(RoutedEventArgs e)
        {
            base.OnLoaded(e);

            // POC:  Look through the tabs for SimpleTextEditor instances, hook their text changed event, try using
            //       the C parser.

            foreach (var viewModel in this.CodeTabControl.Items.Cast<CodeFileViewModel>())
            {
                viewModel.CodeChangedEvent += OnCodeChanged;
            }
        }

        private void OnCodeChanged(object? sender, string codeString)
        {
            _parser.Run(codeString);

            // Clear out Parser Logs and re-apply the token list
            var viewModel = this.DataContext as ViewModel;
            if (viewModel != null)
            {
                viewModel.ParserLogs.Clear();
                foreach (var token in _parser.TokenMessages)
                {
                    viewModel.ParserLogs.Add(new LogViewModel()
                    {
                        Message = token,
                        Severity = LogSeverity.Info,
                        Type = LogType.Code,
                        Timestamp = DateTime.Now
                    });
                }
            }
        }

        private void OnLog(object? sender, LogViewModel log)
        {
            var viewModel = this.DataContext as ViewModel;

            viewModel?.Logs.Add(log);
        }

        private void OpenItem_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }
        private void SaveItem_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }
        private void CloseItem_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }
    }
}
