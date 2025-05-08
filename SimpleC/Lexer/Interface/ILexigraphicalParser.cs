using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Lexer.Interface
{
    /// <summary>
    /// The purpose of this component is to parse an input scope block into child block(s) working with
    /// the proper language semantics and syntax.
    /// </summary>
    public interface ILexigraphicalParser
    {
        /// <summary>
        /// Sets the tokens for the language (prior to parsing)
        /// </summary>
        void SetLanguageTokens(IEnumerable<Token> tokens);

        /// <summary>
        /// Parses input blocks into nested child blocks - to be used recursively.
        /// </summary>
        IEnumerable<ScopeBlock> Parse(ScopeBlock block);
    }
}
