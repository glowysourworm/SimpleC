using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Base;
using SimpleC.Code;
using SimpleC.Main.Interface;

namespace SimpleC.Lexer.Interface
{
    /// <summary>
    /// The purpose of this component is to parse an input scope block into child block(s) working with
    /// the proper language semantics and syntax. While building this data structure, data about parsing
    /// is fowarded via the ParserEvent - which will allow the compiler to list events that happened
    /// during parsing - to the user.
    /// </summary>
    public interface ILexigraphicalParser
    {
        /// <summary>
        /// Event used to forward details back to the ICCompiler
        /// </summary>
        public event SimpleHandler<ICCompilerEventData> ParserEvent;

        /// <summary>
        /// Parses input blocks into nested child blocks - to be used recursively.
        /// </summary>
        LexigraphicalParserResult Parse(CodeFile file);
    }
}
