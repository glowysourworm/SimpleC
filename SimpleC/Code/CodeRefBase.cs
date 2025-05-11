using SimpleC.Base;

namespace SimpleC.Code
{
    /// <summary>
    /// Reference to a specific piece of text from the code file; or from
    /// the base grammar of the language.
    /// </summary>
    public abstract class CodeRefBase : ModelBase
    {
        string _value;

        public string Value
        {
            get { return _value; }
            set { this.RaiseAndSetIfChanged(ref _value, value); }
        }
        public CodeRefBase()
        {
            this.Value = string.Empty;
        }
    }
}
