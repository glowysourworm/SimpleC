using SimpleC.Base;

namespace SimpleC.Code
{
    /// <summary>
    /// Reference to a specific piece of text from the code file; or from
    /// the base grammar of the language.
    /// </summary>
    public abstract class CodeRefBase : ModelBase
    {
        string _code;

        /// <summary>
        /// Readonly value of the code from which the code ref came. This is a raw-unprocessed value; and 
        /// is a substring of a code file or in-memory string.
        /// </summary>
        public string Code
        {
            get { return _code; }
        }
        public CodeRefBase(string code)
        {
            _code = code;       // TODO: Create string wrapper class to prevent string copying
        }
    }
}
