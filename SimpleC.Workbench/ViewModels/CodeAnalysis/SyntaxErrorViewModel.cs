using System.Collections.ObjectModel;

namespace SimpleC.Workbench.ViewModels.CodeAnalysis
{
    public class SyntaxErrorViewModel : ViewModelBase
    {
        string _symbol;
        int _line;
        int _column;
        string _message;
        string _rule;
        string _helpLink;

        ObservableCollection<TokenViewModel> _expectedTokens;

        public string Symbol
        {
            get { return _symbol; }
            set { this.SetProperty(ref _symbol, value); }
        }
        public int Line
        {
            get { return _line; }
            set { this.SetProperty(ref _line, value); }
        }
        public int Column
        {
            get { return _column; }
            set { this.SetProperty(ref _column, value); }
        }
        public string Message
        {
            get { return _message; }
            set { this.SetProperty(ref _message, value); }
        }
        public string Rule
        {
            get { return _rule; }
            set { this.SetProperty(ref _rule, value); }
        }
        public string HelpLink
        {
            get { return _helpLink; }
            set { this.SetProperty(ref _helpLink, value); }
        }

        public ObservableCollection<TokenViewModel> ExpectedTokens
        {
            get { return _expectedTokens; }
            set { this.SetProperty(ref _expectedTokens, value); }
        }

        public SyntaxErrorViewModel()
        {
            this.ExpectedTokens = new ObservableCollection<TokenViewModel>();
            this.Symbol = "";
            this.HelpLink = "";
            this.Message = "";
        }

    }
}
