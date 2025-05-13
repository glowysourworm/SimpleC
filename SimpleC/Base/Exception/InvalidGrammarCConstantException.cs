using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Base.Standard;

namespace SimpleC.Base.Exception
{
    /// <summary>
    /// Class for an improper use of a grammar constant
    /// </summary>
    public class InvalidGrammarCConstantException : SimpleCException
    {
        char _grammarCConstant;
        ISOCStandardRef _standardRef;

        public InvalidGrammarCConstantException(char grammarCConstant, ISOCStandardRef standardRef)
            : base(InvalidGrammarCConstantException.Format(grammarCConstant, standardRef))
        {
            _grammarCConstant = grammarCConstant;
            _standardRef = standardRef;
        }

        private static string Format(char grammarCConstant, ISOCStandardRef standardRef)
        {
            var messageFormat = "Improper use of Grammar Constant \"{0}\" - please see ISO Standard {1}";
            var isoFormat = standardRef.ToString();
            return string.Format(messageFormat, grammarCConstant, isoFormat);
        }
    }
}
