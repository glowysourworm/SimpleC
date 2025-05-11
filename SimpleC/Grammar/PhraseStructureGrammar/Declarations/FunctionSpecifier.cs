using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    /// <summary>
    /// (see A.2.2 -> 6.7.4) function-specifier: This class should be just a keyword; but there may be other contextual data.
    /// </summary>
    public class FunctionSpecifier : GrammarBase
    {
        Keyword _keyword;
    }
}
