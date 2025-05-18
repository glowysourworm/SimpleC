namespace SimpleC.Workbench.ViewModels.CodeAnalysis
{
    public class TokenViewModel : ViewModelBase
    {
        string _text;
        string _source;
        string _type;
        string _channel;
        int _column;
        int _line;

        public string Text
        {
            get { return _text; }
            set { this.SetProperty(ref _text, value); }
        }
        public string Source
        {
            get { return _source; }
            set { this.SetProperty(ref _source, value); }
        }
        public string Type
        {
            get { return _type; }
            set { this.SetProperty(ref _type, value); }
        }
        public string Channel
        {
            get { return _channel; }
            set { this.SetProperty(ref _channel, value); }
        }
        public int Column
        {
            get { return _column; }
            set { this.SetProperty(ref _column, value); }
        }
        public int Line
        {
            get { return _line; }
            set { this.SetProperty(ref _line, value); }
        }

        public TokenViewModel()
        {
            this.Source = string.Empty;
            this.Text = string.Empty;
            this.Type = string.Empty;
            this.Channel = string.Empty;
        }
    }
}
