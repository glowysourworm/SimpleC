using SimpleC.Code;

namespace SimpleC.Grammar
{
    /// <summary>
    /// This represents an absolute constant for the grammar. Example:  Keyword (one of) auto, break, case, ... 
    /// </summary>
    public abstract class GrammarConstant : GrammarBase
    {
        protected GrammarConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
