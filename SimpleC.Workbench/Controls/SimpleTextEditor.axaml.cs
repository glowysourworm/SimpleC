using Avalonia.Controls;

using AvaloniaEdit;
using AvaloniaEdit.TextMate;

using SimpleC.Workbench.ViewModels;

using TextMateSharp.Grammars;

namespace SimpleC.Workbench.Controls
{
    public partial class SimpleTextEditor : UserControl
    {
        public SimpleTextEditor()
        {
            InitializeComponent();

            // [glowysourworm] https://github.com/avaloniaui/avaloniaedit (AvaloniaEdit setup)

            //First of all you need to have a reference for your TextEditor for it to be used inside AvaloniaEdit.TextMate project.
            var _textEditor = this.FindControl<TextEditor>("Editor");

            if (_textEditor != null)
            {
                //Here we initialize RegistryOptions with the theme we want to use.
                var _registryOptions = new RegistryOptions(ThemeName.HighContrastLight);

                //Initial setup of TextMate.
                var _textMateInstallation = _textEditor.InstallTextMate(_registryOptions);

                //Here we are getting the language by the extension and right after that we are initializing grammar with this language.
                //And that's all 😀, you are ready to use AvaloniaEdit with syntax highlighting!
                _textMateInstallation.SetGrammar(_registryOptions.GetScopeByLanguageId(_registryOptions.GetLanguageByExtension(".cs").Id));
            }

            this.DataContextChanged += SimpleTextEditor_DataContextChanged;
        }

        ~SimpleTextEditor()
        {
            this.DataContextChanged -= SimpleTextEditor_DataContextChanged;
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
    }
}