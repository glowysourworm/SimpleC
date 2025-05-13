using SimpleC.Base;
using SimpleC.Code;

namespace SimpleC.Grammar
{
    /// <summary>
    /// Base class for any lexical element in the grammar of the language. There will be sets of elements
    /// that are user defined:  Identifiers (for example). Some elements will be constant for the language:
    /// Example:  GrammarConstant, which is inherited by Keyword.
    /// </summary>
    public abstract class GrammarBase : ModelBase
    {
        string _name;
        CodeRefBase _value;
        string _description;
        bool _ourSupport;
        string _ourSupportMessage;

        /// <summary>
        /// The ISO-Standard C name for the element. This should follow the documentation for
        /// clarity on language specifics. Example:  header-name is the (this.Name) of the Header
        /// Name lexical element from the standard.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { RaiseAndSetIfChanged(ref _name, value); }
        }

        /// <summary>
        /// The value of this lexical element: either in terms of the language itself, or the code
        /// file.
        /// </summary>
        public CodeRefBase Ref
        {
            get { return _value; }
            set { RaiseAndSetIfChanged(ref _value, value); }
        }
        public string Description
        {
            get { return _description; }
            set { RaiseAndSetIfChanged(ref _description, value); }
        }
        public bool OurSupport
        {
            get { return _ourSupport; }
            set { RaiseAndSetIfChanged(ref _ourSupport, value); }
        }
        public string OurSupportMessage
        {
            get { return _ourSupportMessage; }
            set { RaiseAndSetIfChanged(ref _ourSupportMessage, value); }
        }

        public GrammarBase()
        {
            this.Name = "";            
            this.Description = "";
            this.OurSupport = true;
            this.OurSupportMessage = "";
        }
    }
}
