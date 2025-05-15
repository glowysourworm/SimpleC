using SimpleC.Code;

namespace SimpleC.Grammar
{
    /// <summary>
    /// Base class for any lexical element in the grammar of the language. There will be sets of elements
    /// that are user defined:  Identifiers (for example). Some elements will be constant for the language:
    /// Example:  GrammarConstant, which is inherited by Keyword.
    /// </summary>
    public abstract class GrammarBase
    {
        /// <summary>
        /// The value of this lexical element: either in terms of the language itself, or the code
        /// file.
        /// </summary>
        public readonly CodeRefBase Ref;

        public GrammarBase(CodeRefBase codeRef)
        {
            this.Ref = codeRef;
        }
    }
}
