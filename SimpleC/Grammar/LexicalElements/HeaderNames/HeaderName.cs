using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    /// <summary>
    /// Not sure if this should be an "expression". The documentation points to 
    /// this being sets of literal constants. So, this would be a static structure
    /// (obviously) for a header name to be evaluated. So, some of these lexical
    /// elements might be named otherwise. (not a token, but not an expression)
    /// </summary>
    public class HeaderName : GrammarBase
    {
    }
}
