using System;
using System.Threading.Tasks;

using Avalonia.Controls;
using Avalonia.Threading;

using AvaloniaEdit.TextMate;

using SimpleC.Workbench.Component;
using SimpleC.Workbench.ViewModels;

using TextMateSharp.Grammars;

using static AvaloniaEdit.TextMate.TextMate;

namespace SimpleC.Workbench.Controls
{
    public partial class SimpleTextEditor : UserControl
    {
        private Installation _textMateInstallation;
        private RegistryOptions _registryOptions;
        private Debouncer _debouncer;

        public SimpleTextEditor()
        {
            InitializeComponent();

            // [glowysourworm] https://github.com/avaloniaui/avaloniaedit (AvaloniaEdit setup)

            // Here we initialize RegistryOptions with the theme we want to use.
            _registryOptions = new RegistryOptions(ThemeName.Monokai);

            // (FIX THIS TO EMBEDDED RESOURCES!) Load grammars from the assets directory
            _registryOptions.LoadFromLocalDir(@"C:\Backup\_Source\Git\SimpleC\SimpleC.Workbench\Assets\TextMateGrammars");

            // Initial setup of TextMate.
            _textMateInstallation = this.Editor.InstallTextMate(_registryOptions);

            // Debounce the code parser
            _debouncer = new Debouncer(300);

            // Set default language
            SetGrammar(_registryOptions.GetLanguageByExtension(".c"));

            // Setup combo box with grammar options
            foreach (var language in _registryOptions.GetAvailableLanguages())
            {
                this.GrammarCB.Items.Add(language);
            }

            this.GrammarCB.SelectionChanged += GrammarCB_SelectionChanged;
            this.DataContextChanged += SimpleTextEditor_DataContextChanged;
            this.Editor.TextChanged += Editor_TextChanged;
        }

        ~SimpleTextEditor()
        {
            this.GrammarCB.SelectionChanged -= GrammarCB_SelectionChanged;
            this.DataContextChanged -= SimpleTextEditor_DataContextChanged;
            this.Editor.TextChanged -= Editor_TextChanged;
        }

        private void SetGrammar(Language language)
        {
            //Here we are getting the language by the extension and right after that we are initializing grammar with this language.
            //And that's all 😀, you are ready to use AvaloniaEdit with syntax highlighting!
            _textMateInstallation.SetGrammar(_registryOptions.GetScopeByLanguageId(language.Id));
        }

        private void GrammarCB_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            var language = this.GrammarCB.SelectedItem as Language;

            if (language != null)
            {
                SetGrammar(language);
            }
        }

        private void SimpleTextEditor_DataContextChanged(object? sender, System.EventArgs e)
        {
            var viewModel = this.DataContext as CodeFileViewModel;

            if (viewModel != null)
            {
                this.Editor.Clear();
                this.Editor.AppendText(viewModel.Contents);
            }
        }

        private void Editor_TextChanged(object? sender, System.EventArgs e)
        {
            _debouncer.Debounce(RaiseTextEvent);
        }

        private void RaiseTextEvent()
        {
            Dispatcher.UIThread.Invoke(() =>
            {
                var viewModel = this.Editor.DataContext as CodeFileViewModel;
                if (viewModel != null)
                {
                    viewModel.RaiseTextChanged(this.Editor.Text);
                }
            });
        }
    }
}